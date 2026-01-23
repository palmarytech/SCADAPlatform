using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusLib.Base;
using ModbusLib.Library;
using Serilog;

namespace SCADAPlatform
{
    public partial class FrmMain : Form
    {
        private Button _currentBtn;
        private Panel _leftBorderBtn;
        private Form _currentChildForm;

        private ModbusRTULib _modbusRtuLib = new ModbusRTULib();

        public FrmMain()
        {
            InitializeComponent();
            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size(10, 68);
            panel_Menu.Controls.Add(_leftBorderBtn);


            _modbusRtuLib.RcvTimeOut = 2000;   // 整体超时 2 秒
            _modbusRtuLib.WaitingTime = 10;    // 轮询间隔 10ms
            _modbusRtuLib.OpenSerialPort("COM10");
            this.FormClosing += FrmMain_FormClosing;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var response = _modbusRtuLib.WriteMultipleCoils(0, new bool[]{true, true, false});
            if (response.IsSuccess)
            {
                textBox1.Text = $"写入数据成功";
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _modbusRtuLib.CloseSerialPort();
        }



        #region 窗体切换方法
        private struct RgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActiveButton(object senderBtn, Color color) //
        {
            if (senderBtn != null)
            {
                DisableButton();
                _currentBtn = (Button)senderBtn;
                _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                _currentBtn.ForeColor = color;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                _currentBtn.Padding = new Padding(0, 0, 20, 0);

                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point(3, _currentBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (childForm == null) return;
            // ===== 新增：如果已经是当前子窗体，直接返回，不重复操作 =====
            if (_currentChildForm == childForm && panel_Main.Controls.Contains(childForm))
            {
                childForm.BringToFront();
                return;
            }
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
                panel_Main.Controls.Remove(_currentChildForm);
            }
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                _currentBtn.ForeColor = Color.Gainsboro;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                _currentBtn.Padding = new Padding(20, 0, 0, 0);
            }
        }

        #endregion

        #region 按钮Click事件
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color1);
            OpenChildForm(new FrmDashboard());

            //测试Log
            Log.Information("测试: {sender}", sender);
        }

        private void btn_Trend_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color2);
            OpenChildForm(new FrmTrend());
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color3);
            OpenChildForm(new FrmSetting());
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color4);
            OpenChildForm(new FrmHistory());
        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color5);
            OpenChildForm(new FrmAlarm());
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color6);
            OpenChildForm(new FrmReport());
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color1);
            OpenChildForm(new FrmAccount());
        }

        //窗口关闭
        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗口最小化
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //窗口最大化
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        //窗口拖动
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion


    }
}
