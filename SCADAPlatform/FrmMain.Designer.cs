namespace SCADAPlatform
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.ssl_SerialState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_ResponseTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_Login = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Alarm = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Trend = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusBar.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_TitleBar.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl_SerialState,
            this.ssl_ResponseTime,
            this.toolStripStatusLabel3,
            this.ssl_Login,
            this.ssl_DateTime});
            this.statusBar.Location = new System.Drawing.Point(0, 711);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1280, 29);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // ssl_SerialState
            // 
            this.ssl_SerialState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_SerialState.Image = global::SCADAPlatform.Properties.Resources.serial;
            this.ssl_SerialState.Name = "ssl_SerialState";
            this.ssl_SerialState.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.ssl_SerialState.Size = new System.Drawing.Size(98, 24);
            this.ssl_SerialState.Text = "串口连接";
            // 
            // ssl_ResponseTime
            // 
            this.ssl_ResponseTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_ResponseTime.Image = global::SCADAPlatform.Properties.Resources.changeresponse_;
            this.ssl_ResponseTime.Name = "ssl_ResponseTime";
            this.ssl_ResponseTime.Size = new System.Drawing.Size(84, 24);
            this.ssl_ResponseTime.Text = "10000ms";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(823, 24);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // ssl_Login
            // 
            this.ssl_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_Login.Image = global::SCADAPlatform.Properties.Resources.loginu;
            this.ssl_Login.Name = "ssl_Login";
            this.ssl_Login.Size = new System.Drawing.Size(110, 24);
            this.ssl_Login.Text = "xxx未登录      ";
            // 
            // ssl_DateTime
            // 
            this.ssl_DateTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_DateTime.Image = global::SCADAPlatform.Properties.Resources.time;
            this.ssl_DateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ssl_DateTime.Name = "ssl_DateTime";
            this.ssl_DateTime.Size = new System.Drawing.Size(150, 24);
            this.ssl_DateTime.Text = "2025-12-15 15:44:59";
            this.ssl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_Menu.Controls.Add(this.btn_Account);
            this.panel_Menu.Controls.Add(this.btn_Report);
            this.panel_Menu.Controls.Add(this.btn_Alarm);
            this.panel_Menu.Controls.Add(this.btn_History);
            this.panel_Menu.Controls.Add(this.btn_Setting);
            this.panel_Menu.Controls.Add(this.btn_Trend);
            this.panel_Menu.Controls.Add(this.btn_Dashboard);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(240, 711);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Account.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Account.Image = global::SCADAPlatform.Properties.Resources.account;
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(0, 558);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(240, 68);
            this.btn_Account.TabIndex = 7;
            this.btn_Account.Text = "     用户管理";
            this.btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Report.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Report.Image = global::SCADAPlatform.Properties.Resources.report;
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Location = new System.Drawing.Point(0, 490);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(240, 68);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "     数据报表";
            this.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Alarm
            // 
            this.btn_Alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Alarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Alarm.FlatAppearance.BorderSize = 0;
            this.btn_Alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alarm.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Alarm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Alarm.Image = global::SCADAPlatform.Properties.Resources.报警记录;
            this.btn_Alarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alarm.Location = new System.Drawing.Point(0, 422);
            this.btn_Alarm.Name = "btn_Alarm";
            this.btn_Alarm.Size = new System.Drawing.Size(240, 68);
            this.btn_Alarm.TabIndex = 5;
            this.btn_Alarm.Text = "     报警记录";
            this.btn_Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alarm.UseVisualStyleBackColor = false;
            this.btn_Alarm.Click += new System.EventHandler(this.btn_Alarm_Click);
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_History.FlatAppearance.BorderSize = 0;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_History.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_History.Image = global::SCADAPlatform.Properties.Resources.history_data;
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(0, 354);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(240, 68);
            this.btn_History.TabIndex = 4;
            this.btn_History.Text = "     历史趋势";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Setting.Image = global::SCADAPlatform.Properties.Resources.settings;
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 286);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(240, 68);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "     参数设置";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Trend
            // 
            this.btn_Trend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Trend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Trend.FlatAppearance.BorderSize = 0;
            this.btn_Trend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trend.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Trend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Trend.Image = global::SCADAPlatform.Properties.Resources.Trend;
            this.btn_Trend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Trend.Location = new System.Drawing.Point(0, 218);
            this.btn_Trend.Name = "btn_Trend";
            this.btn_Trend.Size = new System.Drawing.Size(240, 68);
            this.btn_Trend.TabIndex = 2;
            this.btn_Trend.Text = "     实时趋势";
            this.btn_Trend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Trend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Trend.UseVisualStyleBackColor = false;
            this.btn_Trend.Click += new System.EventHandler(this.btn_Trend_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Dashboard.Image = global::SCADAPlatform.Properties.Resources.gauge;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 150);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(240, 68);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "     集中控制";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(240, 150);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCADAPlatform.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_TitleBar.Controls.Add(this.btn_Minimize);
            this.panel_TitleBar.Controls.Add(this.btn_Maximize);
            this.panel_TitleBar.Controls.Add(this.btn_CloseWindow);
            this.panel_TitleBar.Controls.Add(this.label1);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(240, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(1040, 65);
            this.panel_TitleBar.TabIndex = 2;
            this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Image = global::SCADAPlatform.Properties.Resources.minimize;
            this.btn_Minimize.Location = new System.Drawing.Point(942, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(27, 27);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Image = global::SCADAPlatform.Properties.Resources.window_maximize;
            this.btn_Maximize.Location = new System.Drawing.Point(975, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(27, 27);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_CloseWindow.FlatAppearance.BorderSize = 0;
            this.btn_CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseWindow.Image = global::SCADAPlatform.Properties.Resources.close;
            this.btn_CloseWindow.Location = new System.Drawing.Point(1008, 0);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(27, 27);
            this.btn_CloseWindow.TabIndex = 1;
            this.btn_CloseWindow.UseVisualStyleBackColor = false;
            this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "烟气在线连续监测系统";
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_Main.Controls.Add(this.textBox1);
            this.panel_Main.Controls.Add(this.button1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(240, 65);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1040, 646);
            this.panel_Main.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 26);
            this.textBox1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Alarm;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Trend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.ToolStripStatusLabel ssl_SerialState;
        private System.Windows.Forms.ToolStripStatusLabel ssl_ResponseTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssl_Login;
        private System.Windows.Forms.ToolStripStatusLabel ssl_DateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

