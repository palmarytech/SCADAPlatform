using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.DataConvertLib;

namespace ModbusLib.Base
{
    public interface IModbusRW
    {
        /// <summary>
        /// Modbus读线圈功能
        /// </summary>
        /// <param name="startAddress">起始线圈地址</param>
        /// <param name="length">读线圈数量</param>
        /// <param name="slaveId">从站地址</param>
        /// <returns>返回的数据,这里是布尔数组</returns>
        OperateResult<bool[]> ReadCoils(ushort startAddress, ushort length, byte slaveId = 1);
        OperateResult<bool[]> ReadInputs(ushort startAddress, ushort length, byte slaveId = 1);
        OperateResult<byte[]> ReadHoldingRegisters(ushort startAddress, ushort length, byte slaveId = 1);
        OperateResult<byte[]> ReadInputRegisters(ushort startAddress, ushort length, byte slaveId = 1);
    }
}
