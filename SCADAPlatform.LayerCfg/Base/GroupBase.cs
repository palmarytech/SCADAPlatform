using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SCADAPlatform.LayerCfg
{
    public class GroupBase : INotifyPropertyChanged
    {
        
        private string _groupName = "newGroup";
        [Category("通信组属性"), DisplayName("通信组名称"), Description("通信组名称")]
        public string GroupName
        {
            get => _groupName;
            set
            {
                if (_groupName == value) return;
                _groupName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GroupName)));
            }
        }

        [Browsable(false)]
        public bool IsNormalState { get; set; } = true;
        [Category("通信组属性"), DisplayName("重试次数"), Description("通信组重试次数")]
        public int RetryTimes { get; set; } = 2;
        [Category("通信组属性"), DisplayName("延迟时间"), Description("通信组延迟时间，单位毫秒")]
        public int DelayTime { get; set; } = 1000; //ms
        [Browsable(false)]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
