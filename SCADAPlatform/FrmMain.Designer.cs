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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ssl_SerialState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_ResponseTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_Login = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssl_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl_SerialState,
            this.ssl_ResponseTime,
            this.toolStripStatusLabel3,
            this.ssl_Login,
            this.ssl_DateTime});
            this.statusBar.Location = new System.Drawing.Point(0, 718);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1280, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_Menu.Controls.Add(this.button6);
            this.panel_Menu.Controls.Add(this.button5);
            this.panel_Menu.Controls.Add(this.button4);
            this.panel_Menu.Controls.Add(this.button3);
            this.panel_Menu.Controls.Add(this.button2);
            this.panel_Menu.Controls.Add(this.button1);
            this.panel_Menu.Controls.Add(this.btn_Dashboard);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(240, 718);
            this.panel_Menu.TabIndex = 1;
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
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(240, 65);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1040, 653);
            this.panel_Main.TabIndex = 3;
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
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(855, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Image = global::SCADAPlatform.Properties.Resources.minimize;
            this.btn_Minimize.Location = new System.Drawing.Point(942, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(27, 27);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Image = global::SCADAPlatform.Properties.Resources.window_maximize;
            this.btn_Maximize.Location = new System.Drawing.Point(975, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(27, 27);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.btn_CloseWindow.FlatAppearance.BorderSize = 0;
            this.btn_CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseWindow.Image = global::SCADAPlatform.Properties.Resources.close;
            this.btn_CloseWindow.Location = new System.Drawing.Point(1008, 0);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(27, 27);
            this.btn_CloseWindow.TabIndex = 1;
            this.btn_CloseWindow.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Image = global::SCADAPlatform.Properties.Resources.account;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 558);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 68);
            this.button6.TabIndex = 7;
            this.button6.Text = "     用户管理";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = global::SCADAPlatform.Properties.Resources.report;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 68);
            this.button5.TabIndex = 6;
            this.button5.Text = "     数据报表";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::SCADAPlatform.Properties.Resources.报警记录;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "     报警记录";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::SCADAPlatform.Properties.Resources.history_data;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "     历史趋势";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::SCADAPlatform.Properties.Resources.settings;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "     参数设置";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::SCADAPlatform.Properties.Resources.Trend;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "     实时趋势";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
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
            // ssl_SerialState
            // 
            this.ssl_SerialState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_SerialState.Image = global::SCADAPlatform.Properties.Resources.serial;
            this.ssl_SerialState.Name = "ssl_SerialState";
            this.ssl_SerialState.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.ssl_SerialState.Size = new System.Drawing.Size(90, 17);
            this.ssl_SerialState.Text = "串口连接";
            // 
            // ssl_ResponseTime
            // 
            this.ssl_ResponseTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_ResponseTime.Image = global::SCADAPlatform.Properties.Resources.changeresponse_;
            this.ssl_ResponseTime.Name = "ssl_ResponseTime";
            this.ssl_ResponseTime.Size = new System.Drawing.Size(76, 17);
            this.ssl_ResponseTime.Text = "10000ms";
            // 
            // ssl_Login
            // 
            this.ssl_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_Login.Image = global::SCADAPlatform.Properties.Resources.loginu;
            this.ssl_Login.Name = "ssl_Login";
            this.ssl_Login.Size = new System.Drawing.Size(102, 17);
            this.ssl_Login.Text = "xxx未登录      ";
            // 
            // ssl_DateTime
            // 
            this.ssl_DateTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ssl_DateTime.Image = global::SCADAPlatform.Properties.Resources.time;
            this.ssl_DateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ssl_DateTime.Name = "ssl_DateTime";
            this.ssl_DateTime.Size = new System.Drawing.Size(142, 17);
            this.ssl_DateTime.Text = "2025-12-15 15:44:59";
            this.ssl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel_TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.ToolStripStatusLabel ssl_SerialState;
        private System.Windows.Forms.ToolStripStatusLabel ssl_ResponseTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssl_Login;
        private System.Windows.Forms.ToolStripStatusLabel ssl_DateTime;
    }
}

