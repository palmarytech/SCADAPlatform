using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using xbd.DataConvertLib;

namespace ModbusLib.Base
{
    public class SerialBase
    {
        /// <summary>
        /// 串口通信对象，用于数据的发送与接收。
        /// </summary>
        private SerialPort _serialPort = null;

        /// <summary>
        /// 串口读取超时时间（毫秒）。超过该时间未读取到数据则抛出超时异常。
        /// </summary>
        public int ReadTimeout { get; set; } = 500;

        /// <summary>
        /// 串口写入超时时间（毫秒）。超过该时间未写入完成则抛出超时异常。
        /// </summary>
        public int WriteTimeout { get; set; } = 500;

        /// <summary>
        /// 接收数据的整体超时时间（毫秒）。超过该时间未收到完整数据则认为接收超时。
        /// </summary>
        public int RcvTimeOut { get; set; } = 2000;

        /// <summary>
        /// 轮询等待间隔时间（毫秒）。用于接收数据时的等待间隔。
        /// </summary>
        public int WaitingTime { get; set; } = 10;

        /// <summary>
        /// 串口操作锁对象，确保多线程环境下串口操作的线程安全。
        /// </summary>
        private readonly object _serialLock = new object();

        /// <summary>
        /// 打开串口方法
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        /// <returns></returns>
        public OperateResult OpenSerialPort(string portName, int baudRate = 9600, int dataBits = 8, StopBits stopBits = StopBits.One, Parity parity = Parity.None)
        {
            try
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
                _serialPort.ReadTimeout = ReadTimeout;
                _serialPort.WriteTimeout = WriteTimeout;
                //打开串口
                _serialPort.Open();
                Log.Information($"串口[{portName}]已打开，波特率：{baudRate}，数据位：{dataBits}，停止位：{stopBits}，校验位：{parity}");
                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex)
            {
                Log.Error($"打开串口失败: {ex.Message}");
                return new OperateResult(ex.Message);
            }
        }
        /// <summary>
        /// 关闭串口方法
        /// </summary>
        public void CloseSerialPort()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                Log.Information("串口关闭");
            }
        }

        /// <summary>
        /// 发送请求数据到串口并接收响应数据。
        /// </summary>
        /// <param name="request">要发送的请求报文字节数组。</param>
        /// <returns>
        /// 操作结果对象，成功时包含接收到的响应数据字节数组，失败时包含错误信息。
        /// </returns>
        /// <remarks>
        /// 该方法线程安全，采用锁机制防止多线程并发访问串口。
        /// 发送前会清空串口输入输出缓冲区，确保数据准确性。
        /// 发送后循环读取串口数据，直到满足以下任一条件：
        /// 1. 超过接收超时时间（RcvTimeOut），此时如果已接收到部分数据则返回已接收内容，否则返回超时错误；
        /// 2. 已经接收到数据且连续5次未检测到新数据（每次间隔WaitingTime毫秒），认为数据接收完毕。
        /// 若接收过程中发生异常，将返回失败结果并包含异常信息。
        /// </remarks>
        public OperateResult<byte[]> SendAndRcv(byte[] request)
        {
            lock (_serialLock)
            {
                MemoryStream memoryStream = null;
                try
                {
                    memoryStream = new MemoryStream();
                    // 清空串口缓冲区，避免残留数据影响本次通信
                    _serialPort.DiscardInBuffer();
                    _serialPort.DiscardOutBuffer();
                    // 发送请求报文
                    _serialPort.Write(request, 0, request.Length);

                    DateTime start = DateTime.Now;
                    byte[] buffer = new byte[256];
                    bool dataReceived = false;
                    int consecutiveNoDataCount = 0;  // 连续未收到数据的次数

                    while (true)
                    {
                        // 判断是否超时
                        if ((DateTime.Now - start).TotalMilliseconds > RcvTimeOut)
                        {
                            return memoryStream.Length > 0
                                ? OperateResult.CreateSuccessResult(memoryStream.ToArray())  // 返回已接收的数据
                                : OperateResult.CreateFailResult<byte[]>("接收数据超时");
                        }
                        // 检查是否有可读数据
                        if (_serialPort.BytesToRead > 0)
                        {
                            int bytesToRead = Math.Min(_serialPort.BytesToRead, buffer.Length);
                            int readCount = _serialPort.Read(buffer, 0, bytesToRead);
                            memoryStream.Write(buffer, 0, readCount);
                            dataReceived = true;
                            consecutiveNoDataCount = 0;  // 重置无数据计数
                        }
                        else
                        {
                            consecutiveNoDataCount++;
                            // 如果已收到数据且连续5次未检测到新数据，认为数据接收完毕
                            if (dataReceived && consecutiveNoDataCount >= 5)
                            {
                                break;
                            }
                            Thread.Sleep(WaitingTime); // 等待一段时间后再次检测
                        }
                    }
                    // 判断是否接收到数据
                    if (memoryStream.Length == 0)
                    {
                        return OperateResult.CreateFailResult<byte[]>("未接收到任何数据");
                    }
                    byte[] response = memoryStream.ToArray();
                    return OperateResult.CreateSuccessResult(response);
                }
                catch (Exception ex)
                {

                    return OperateResult.CreateFailResult<byte[]>(ex.Message);
                }
                finally
                {
                    memoryStream?.Dispose();
                }
            }


        }
    }
}
