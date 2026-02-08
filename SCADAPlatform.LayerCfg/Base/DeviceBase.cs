using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xbd.DataConvertLib;

namespace SCADAPlatform.LayerCfg
{
    public class DeviceBase : INotifyPropertyChanged
    {
        private string _deviceName = "newDevice";
        [Category("设备属性"), DisplayName("设备名称"), Description("设备名称")]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                if (_deviceName == value) return;
                _deviceName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DeviceName)));
            }
        }
        [Category("设备属性"), DisplayName("数据格式"), Description("设备数据格式, 大小端排列顺序选择")]
        public DataFormat DataFormat { get; set; } = DataFormat.ABCD;
        [Category("设备属性"), DisplayName("连接状态"), Description("设备连接状态, false表示设备未连接")]
        public bool IsConnected { get; set; } = false;
        [Category("设备属性"), DisplayName("首次连接"), Description("是否为首次连接, true表示设备首次连接")]
        public bool IsFirstConnect { get; set; } = true;
        [Category("设备属性"), DisplayName("重试次数"), Description("设备连接失败后的重试次数")]
        public int RetryTimeCycle { get; set; } = 2000; // 重试时间周期，单位毫秒
        //不显示此属性
        [Browsable(false)]
        public CancellationTokenSource Cts { get; set; } = null;
        [Browsable(false)]
        public Dictionary<string, object> RtValueDict { get; set; } = new Dictionary<string, object>();//保存实时数据的字典, key=VarName, object=VarValue
        [Browsable(false)]
        public Stopwatch CommunicationStopWatch { get; set; }
        [Browsable(false)]
        public long CommunicationPeriod { get; set; }
        [Browsable(false)]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
