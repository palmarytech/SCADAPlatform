using System.Collections.Generic;
using System.ComponentModel;

namespace SCADAPlatform.LayerCfg
{
    public class ModbusRtuGroup:GroupBase
    {
        [Browsable(false)]
        public List<ModbusRtuVariable> VarList { get; set; } = new List<ModbusRtuVariable>();
        [Category("通信参数属性"), DisplayName("存储区"), Description("Modbus存储区")]
        public StoreArea StoreArea { get; set; }
        [Category("通信参数属性"), DisplayName("从站地址"), Description("Modbus从站地址")]
        public byte SlaveId { get; set; }
        [Category("通信参数属性"), DisplayName("起始地址"), Description("Modbus起始地址")]
        public ushort StartAddress { get; set; }
        [Category("通信参数属性"), DisplayName("寄存器数量"), Description("Modbus寄存器数量")]
        public ushort Count { get; set; }
    }

    public enum StoreArea
    {
        [Description("输入寄存器(4x)")]
        InputRegister4x,
        [Description("保持寄存器(3x)")]
        HoldingRegister3x,
        [Description("离散输入(1x)")]
        DiscreteInput1x,
        [Description("数字输出(0x)")]
        DigitalOutput0x
    }
}