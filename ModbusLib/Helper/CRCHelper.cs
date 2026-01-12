using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusLib.Helper
{
    public class CRCHelper
    {
        /// <summary>
        /// 计算 Modbus RTU 的 CRC-16 值（多项式 0xA001，反向）
        /// </summary>
        /// <param name="data">要计算CRC的数据</param>
        /// <param name="length">要计算的数据长度（从0开始计算多少个字节）</param>
        /// <returns>2字节的CRC校验码，低字节在前，高字节在后（Modbus RTU的标准顺序）</returns>
        public static byte[] CRC16(byte[] data, int length)
        {
            ushort crc = 0xFFFF;           // 初始值固定为 0xFFFF

            for (int i = 0; i < length; i++)
            {
                crc ^= data[i];            // 当前字节与CRC低8位异或

                for (int j = 0; j < 8; j++) // 对当前字节做8次循环
                {
                    if ((crc & 0x0001) != 0) // 如果最低位为1
                    {
                        crc >>= 1;             // 右移一位
                        crc ^= 0xA001;         // 与多项式异或（反向多项式）
                    }
                    else
                    {
                        crc >>= 1;             // 最低位是0，直接右移
                    }
                }
            }

            // Modbus RTU CRC 是 低字节在前，高字节在后
            return new byte[] { (byte)(crc & 0xFF), (byte)(crc >> 8) };
        }

        /// <summary>
        /// 验证 Modbus RTU 报文的 CRC 是否正确
        /// </summary>
        /// <param name="value">完整的接收到的报文（包含地址、功能码、数据、CRC两个字节）</param>
        /// <returns>CRC校验是否通过</returns>
        /// <remarks>
        /// 约定：value 最后两个字节为收到的CRC（低字节在前，高字节在后）
        /// </remarks>
        public static bool CheckCRC(byte[] value)
        {
            if (value == null || value.Length < 4)
                return false;

            int dataLength = value.Length - 2;

            byte[] calculated = CRC16(value, dataLength);

            // 使用 Length 计算下标 - 最安全、最兼容（C# 所有版本都支持）
            return calculated[0] == value[value.Length - 2] &&
                   calculated[1] == value[value.Length - 1];
        }
    }
}
