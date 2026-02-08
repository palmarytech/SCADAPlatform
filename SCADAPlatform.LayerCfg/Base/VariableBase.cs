using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using xbd.DataConvertLib;

namespace SCADAPlatform.LayerCfg
{
    public class VariableBase : INotifyPropertyChanged
    {

        private string _varName = "newVariable";
        [Category("变量属性"), DisplayName("变量名称"), Description("变量名称")]
        public string VarName
        {
            get=> _varName;
            set
            {
                if (_varName == value) return;
                _varName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VarName)));
            }
        }
        [Category("变量属性"), DisplayName("数据类型"), Description("变量数据类型")]
        public DataType DataType { get; set; }
        
        [Category("变量属性"), DisplayName("变量地址"), Description("变量地址")]
        public string VarAddress { get; set; }
        [Category("变量属性"), DisplayName("增益值"), Description("变量增益值")]
        public float Gain { get; set; } = 1.0f;

        [Category("变量属性"), DisplayName("偏置值"), Description("变量偏置值")]
        public float Offset { get; set; } = 0.0f;
        [Category("变量属性"), DisplayName("是否有高报警"), Description("变量是否有高报警")]
        public bool HasHighAlarm { get; set; } = true;

        [Category("变量属性"), DisplayName("高报警描述"), Description("变量高报警描述")]
        public string HighAlarmDescription { get; set; }
        [Browsable(false)]
        public float HighAlarmValue { get; set; }
        [Browsable(false)]
        public float HighAlarmLastValue { get; set; } = float.MinValue;

        [Category("变量属性"), DisplayName("是否有低报警"), Description("变量是否有低报警")]
        public bool HasLowAlarm { get; set; } = false;
        
        [Category("变量属性"), DisplayName("低报警描述"), Description("变量低报警描述")]
        public string LowAlarmDescription { get; set; }
        [Browsable(false)]
        public float LowAlarmValue { get; set; }
        [Browsable(false)]
        public float LowAlarmLastValue { get; set; } = float.MaxValue;
        [Category("变量属性"), DisplayName("最大值"), Description("变量最大值")]
        public float MaxRange { get; set; }

        [Category("变量属性"), DisplayName("最小值"), Description("变量最小值")]
        public float MinRange { get; set; } = 0.0f;
        [Browsable(false)]
        public Object VarValue { get; set; }
        [Browsable(false)]
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
