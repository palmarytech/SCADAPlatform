using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModbusLib.Base;
using ModbusLib.Helper;
using xbd.DataConvertLib;

namespace ModbusLib.Library
{
    public class ModbusRTULib : SerialBase, IModbusRW
    {
        public OperateResult<bool[]> ReadCoils(ushort startAddress, ushort length, byte slaveId = 1)
        {
            //[1]拼接报文 (从站地址, 功能码, 起始线圈地址, 线圈数量, CRC校验)
            List<byte> request = new List<byte>();// 创建一个List保存请求报文
            request.Add(slaveId);//从站地址 占1字节
            request.Add(0x01); //功能码 占1字节
            request.Add((byte)(startAddress / 256)); //起始线圈地址, 占两字节
            request.Add((byte)(startAddress % 256)); //起始线圈地址, 占两字节
            request.Add((byte)(length / 256)); //读线圈数量, 占两字节
            request.Add((byte)(length % 256)); //读线圈数量, 占两字节
            request.AddRange(CRCHelper.CRC16(request.ToArray(), request.Count)); //CRC校验码, 占两字节
            //[2]发送报文+[3]接收报文
            var response = SendAndRcv(request.ToArray());
            if (response.IsSuccess)
            {
                // 计算 Modbus 读线圈功能响应报文中数据部分的字节长度
                // 公式：向上取整(length / 8)
                // 因为 8 个线圈的状态正好用 1 个字节表示
                int byteLength = length % 8 == 0
                    ? length / 8  // 整除 → 直接除以 8 就够了
                    : length / 8 + 1; // 有余数 → 商再加 1 个字节
                if (response.Content.Length == 5 + byteLength && CRCHelper.CheckCRC(response.Content))
                {
                    //[5]解析报文
                    byte[] content = response.Content.Skip(3).Take(byteLength).ToArray();
                    return OperateResult.CreateSuccessResult(BitLib.GetBitArrayFromByteArray(content).Take(length).ToArray());
                }
                else
                {
                    return OperateResult.CreateFailResult<bool[]>("响应报文错误");
                }
            }
            else
            {
                return OperateResult.CreateFailResult<bool[]>(response.Message);
            }

        }

        public OperateResult<bool[]> ReadInputs(ushort startAddress, ushort length, byte slaveId = 1)
        {
            //[1]拼接报文 (从站地址, 功能码, 起始线圈地址, 线圈数量, CRC校验)
            List<byte> request = new List<byte>();// 创建一个List保存请求报文
            request.Add(slaveId);//从站地址 占1字节
            request.Add(0x02); //功能码 占1字节
            request.Add((byte)(startAddress / 256)); //起始线圈地址, 占两字节
            request.Add((byte)(startAddress % 256)); //起始线圈地址, 占两字节
            request.Add((byte)(length / 256)); //读线圈数量, 占两字节
            request.Add((byte)(length % 256)); //读线圈数量, 占两字节
            request.AddRange(CRCHelper.CRC16(request.ToArray(), request.Count)); //CRC校验码, 占两字节
            //[2]发送报文+[3]接收报文
            var response = SendAndRcv(request.ToArray());
            if (response.IsSuccess)
            {
                // 计算 Modbus 读线圈功能响应报文中数据部分的字节长度
                // 公式：向上取整(length / 8)
                // 因为 8 个线圈的状态正好用 1 个字节表示
                int byteLength = length % 8 == 0
                    ? length / 8  // 整除 → 直接除以 8 就够了
                    : length / 8 + 1; // 有余数 → 商再加 1 个字节
                if (response.Content.Length == 5 + byteLength && CRCHelper.CheckCRC(response.Content))
                {
                    //[5]解析报文
                    byte[] content = response.Content.Skip(3).Take(byteLength).ToArray();
                    return OperateResult.CreateSuccessResult(BitLib.GetBitArrayFromByteArray(content).Take(length).ToArray());
                }
                else
                {
                    return OperateResult.CreateFailResult<bool[]>("响应报文错误");
                }
            }
            else
            {
                return OperateResult.CreateFailResult<bool[]>(response.Message);
            }
        }

        public OperateResult<byte[]> ReadHoldingRegisters(ushort startAddress, ushort length, byte slaveId = 1)
        {
            //[1]拼接报文 (1从站地址, 1功能码, 2起始线圈地址, 2线圈数量, 2CRC校验)
            List<byte> request = new List<byte>();
            request.Add(slaveId);
            request.Add(0x03); //功能码
            request.Add((byte)(startAddress / 256));
            request.Add((byte)(startAddress % 256));
            request.Add((byte)(length / 256));
            request.Add((byte)(length % 256));
            request.AddRange(CRCHelper.CRC16(request.ToArray(), request.Count));
            //[2]发送报文+[3]接收报文
            var response = SendAndRcv(request.ToArray());
            if (response.IsSuccess)
            {//[4]验证报文
                if (response.Content.Length == 5 + length * 2 && CRCHelper.CheckCRC(response.Content))
                {
                    //[5]解析报文
                    byte[] content = response.Content.Skip(3).Take(length * 2).ToArray();
                    return OperateResult.CreateSuccessResult(content.ToArray());
                }
                else
                {
                    return OperateResult.CreateFailResult<byte[]>("响应报文错误");
                }
            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>(response.Message);
            }
        }

        public OperateResult<byte[]> ReadInputRegisters(ushort startAddress, ushort length, byte slaveId = 1)
        {
            //[1]拼接报文 (1从站地址, 1功能码, 2起始线圈地址, 2线圈数量, 2CRC校验)
            List<byte> request = new List<byte>();
            request.Add(slaveId);
            request.Add(0x04); //功能码
            request.Add((byte)(startAddress / 256));
            request.Add((byte)(startAddress % 256));
            request.Add((byte)(length / 256));
            request.Add((byte)(length % 256));
            request.AddRange(CRCHelper.CRC16(request.ToArray(), request.Count));
            //[2]发送报文+[3]接收报文
            var response = SendAndRcv(request.ToArray());
            if (response.IsSuccess)
            {//[4]验证报文
                if (response.Content.Length == 5 + length * 2 && CRCHelper.CheckCRC(response.Content))
                {
                    //[5]解析报文
                    byte[] content = response.Content.Skip(3).Take(length * 2).ToArray();
                    return OperateResult.CreateSuccessResult(content.ToArray());
                }
                else
                {
                    return OperateResult.CreateFailResult<byte[]>("响应报文错误");
                }
            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>(response.Message);
            }
        }
    }
}
