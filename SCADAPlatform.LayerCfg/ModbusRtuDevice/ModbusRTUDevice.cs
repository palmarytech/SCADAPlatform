using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using xbd.DataConvertLib;

namespace SCADAPlatform.LayerCfg
{
    public class ModbusRtuDevice : DeviceBase
    {
        [Browsable(false)]
        public List<ModbusRtuGroup> GroupList { get; set; } = new List<ModbusRtuGroup>();
        [Category("串口参数"), DisplayName("端口名称"), Description("串口端口名称")]
        public string PortName { get; set; }
        [Category("串口参数"), DisplayName("波特率"), Description("串口波特率")]
        public int BaudRate { get; set; }
        [Category("串口参数"), DisplayName("停止位"), Description("串口停止位")]
        public StopBits StopBits { get; set; }
        [Category("串口参数"), DisplayName("奇偶校验"), Description("串口奇偶校验")]
        public Parity Parity { get; set; }
        [Category("串口参数"), DisplayName("数据位"), Description("串口数据位")]
        public int DataBits { get; set; }
        [Category("设备属性"), DisplayName("离线检测"), Description("是否启用离线检测功能, true表示启用")]
        public bool IsOfflineCheck { get; set; } = false;
        [Category("设备属性"), DisplayName("离线检测次数"), Description("设备离线检测次数, 超过该次数则判定为离线状态")]
        public int OfflineCheckTimes { get; set; } = 10;
        [Browsable(false)]
        public Dictionary<string, ModbusRtuVariable> VarDict = new Dictionary<string, ModbusRtuVariable>();

    }
}