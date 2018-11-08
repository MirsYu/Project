namespace Project
{
    partial class FrameUI
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameUI));
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.MenuPathPictrue = new System.Windows.Forms.Button();
			this.MenuLogin = new System.Windows.Forms.Button();
			this.MenuCamera = new System.Windows.Forms.Button();
			this.MenuPathCSV = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.MenuEmg = new System.Windows.Forms.Button();
			this.MenuReset = new System.Windows.Forms.Button();
			this.MenuPause = new System.Windows.Forms.Button();
			this.MenuRun = new System.Windows.Forms.Button();
			this.MenuSRname = new System.Windows.Forms.Button();
			this.MenuAlarm = new System.Windows.Forms.Button();
			this.MenuManual = new System.Windows.Forms.Button();
			this.MenuMain = new System.Windows.Forms.Button();
			this.PanelForm = new System.Windows.Forms.Panel();
			this.timer_Main = new System.Windows.Forms.Timer(this.components);
			this.panel_MainInfo = new System.Windows.Forms.Panel();
			this.label_User = new System.Windows.Forms.Label();
			this.label_Version = new System.Windows.Forms.Label();
			this.label_Day = new System.Windows.Forms.Label();
			this.pnlTitle.SuspendLayout();
			this.panel_MainInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
			this.pnlTitle.Controls.Add(this.MenuPathPictrue);
			this.pnlTitle.Controls.Add(this.MenuLogin);
			this.pnlTitle.Controls.Add(this.MenuCamera);
			this.pnlTitle.Controls.Add(this.MenuPathCSV);
			this.pnlTitle.Controls.Add(this.button2);
			this.pnlTitle.Controls.Add(this.MenuEmg);
			this.pnlTitle.Controls.Add(this.MenuReset);
			this.pnlTitle.Controls.Add(this.MenuPause);
			this.pnlTitle.Controls.Add(this.MenuRun);
			this.pnlTitle.Controls.Add(this.MenuSRname);
			this.pnlTitle.Controls.Add(this.MenuAlarm);
			this.pnlTitle.Controls.Add(this.MenuManual);
			this.pnlTitle.Controls.Add(this.MenuMain);
			this.pnlTitle.Location = new System.Drawing.Point(3, 3);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(1252, 84);
			this.pnlTitle.TabIndex = 1;
			// 
			// MenuPathPictrue
			// 
			this.MenuPathPictrue.BackColor = System.Drawing.Color.Transparent;
			this.MenuPathPictrue.FlatAppearance.BorderSize = 0;
			this.MenuPathPictrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuPathPictrue.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuPathPictrue.Image = global::Project.Properties.Resources.VisionFile;
			this.MenuPathPictrue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuPathPictrue.Location = new System.Drawing.Point(1046, 2);
			this.MenuPathPictrue.Margin = new System.Windows.Forms.Padding(2);
			this.MenuPathPictrue.Name = "MenuPathPictrue";
			this.MenuPathPictrue.Size = new System.Drawing.Size(70, 80);
			this.MenuPathPictrue.TabIndex = 23;
			this.MenuPathPictrue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuPathPictrue.UseVisualStyleBackColor = false;
			// 
			// MenuLogin
			// 
			this.MenuLogin.BackColor = System.Drawing.Color.Transparent;
			this.MenuLogin.FlatAppearance.BorderSize = 0;
			this.MenuLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuLogin.Image = global::Project.Properties.Resources.User;
			this.MenuLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuLogin.Location = new System.Drawing.Point(1132, 2);
			this.MenuLogin.Margin = new System.Windows.Forms.Padding(2);
			this.MenuLogin.Name = "MenuLogin";
			this.MenuLogin.Size = new System.Drawing.Size(73, 80);
			this.MenuLogin.TabIndex = 23;
			this.MenuLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuLogin.UseVisualStyleBackColor = false;
			this.MenuLogin.Click += new System.EventHandler(this.MenuLogin_Click);
			// 
			// MenuCamera
			// 
			this.MenuCamera.BackColor = System.Drawing.Color.Transparent;
			this.MenuCamera.FlatAppearance.BorderSize = 0;
			this.MenuCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuCamera.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuCamera.Image = global::Project.Properties.Resources.Chart;
			this.MenuCamera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuCamera.Location = new System.Drawing.Point(275, 2);
			this.MenuCamera.Margin = new System.Windows.Forms.Padding(2);
			this.MenuCamera.Name = "MenuCamera";
			this.MenuCamera.Size = new System.Drawing.Size(75, 80);
			this.MenuCamera.TabIndex = 23;
			this.MenuCamera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuCamera.UseVisualStyleBackColor = false;
			// 
			// MenuPathCSV
			// 
			this.MenuPathCSV.BackColor = System.Drawing.Color.Transparent;
			this.MenuPathCSV.FlatAppearance.BorderSize = 0;
			this.MenuPathCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuPathCSV.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuPathCSV.Image = global::Project.Properties.Resources.SaveToExcel;
			this.MenuPathCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuPathCSV.Location = new System.Drawing.Point(960, 2);
			this.MenuPathCSV.Margin = new System.Windows.Forms.Padding(2);
			this.MenuPathCSV.Name = "MenuPathCSV";
			this.MenuPathCSV.Size = new System.Drawing.Size(70, 80);
			this.MenuPathCSV.TabIndex = 23;
			this.MenuPathCSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuPathCSV.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new System.Drawing.Point(869, 2);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 80);
			this.button2.TabIndex = 23;
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// MenuEmg
			// 
			this.MenuEmg.BackColor = System.Drawing.Color.Transparent;
			this.MenuEmg.FlatAppearance.BorderSize = 0;
			this.MenuEmg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuEmg.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuEmg.ForeColor = System.Drawing.Color.Transparent;
			this.MenuEmg.Image = global::Project.Properties.Resources.Stop_Gray;
			this.MenuEmg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuEmg.Location = new System.Drawing.Point(778, 2);
			this.MenuEmg.Margin = new System.Windows.Forms.Padding(2);
			this.MenuEmg.Name = "MenuEmg";
			this.MenuEmg.Size = new System.Drawing.Size(75, 80);
			this.MenuEmg.TabIndex = 23;
			this.MenuEmg.UseVisualStyleBackColor = false;
			this.MenuEmg.Click += new System.EventHandler(this.MenuEmg_Click);
			// 
			// MenuReset
			// 
			this.MenuReset.BackColor = System.Drawing.Color.Transparent;
			this.MenuReset.FlatAppearance.BorderSize = 0;
			this.MenuReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuReset.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
			this.MenuReset.Image = global::Project.Properties.Resources.GoHome_Gray;
			this.MenuReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuReset.Location = new System.Drawing.Point(687, 2);
			this.MenuReset.Margin = new System.Windows.Forms.Padding(2);
			this.MenuReset.Name = "MenuReset";
			this.MenuReset.Size = new System.Drawing.Size(75, 80);
			this.MenuReset.TabIndex = 23;
			this.MenuReset.Text = "Refresh";
			this.MenuReset.UseVisualStyleBackColor = false;
			this.MenuReset.Click += new System.EventHandler(this.MenuReset_Click);
			// 
			// MenuPause
			// 
			this.MenuPause.BackColor = System.Drawing.Color.Transparent;
			this.MenuPause.FlatAppearance.BorderSize = 0;
			this.MenuPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuPause.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuPause.Image = global::Project.Properties.Resources.Pause_Gray;
			this.MenuPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuPause.Location = new System.Drawing.Point(596, 2);
			this.MenuPause.Margin = new System.Windows.Forms.Padding(2);
			this.MenuPause.Name = "MenuPause";
			this.MenuPause.Size = new System.Drawing.Size(75, 80);
			this.MenuPause.TabIndex = 23;
			this.MenuPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuPause.UseVisualStyleBackColor = false;
			this.MenuPause.Click += new System.EventHandler(this.MenuPause_Click);
			// 
			// MenuRun
			// 
			this.MenuRun.BackColor = System.Drawing.Color.Transparent;
			this.MenuRun.FlatAppearance.BorderSize = 0;
			this.MenuRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuRun.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuRun.Image = global::Project.Properties.Resources.Run_Gray;
			this.MenuRun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuRun.Location = new System.Drawing.Point(505, 2);
			this.MenuRun.Margin = new System.Windows.Forms.Padding(2);
			this.MenuRun.Name = "MenuRun";
			this.MenuRun.Size = new System.Drawing.Size(75, 80);
			this.MenuRun.TabIndex = 23;
			this.MenuRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuRun.UseVisualStyleBackColor = false;
			this.MenuRun.Click += new System.EventHandler(this.MenuRun_Click);
			// 
			// MenuSRname
			// 
			this.MenuSRname.BackColor = System.Drawing.Color.Transparent;
			this.MenuSRname.FlatAppearance.BorderSize = 0;
			this.MenuSRname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuSRname.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.MenuSRname.Image = global::Project.Properties.Resources.bigbk_sel_;
			this.MenuSRname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuSRname.Location = new System.Drawing.Point(366, 10);
			this.MenuSRname.Margin = new System.Windows.Forms.Padding(2);
			this.MenuSRname.Name = "MenuSRname";
			this.MenuSRname.Size = new System.Drawing.Size(123, 64);
			this.MenuSRname.TabIndex = 23;
			this.MenuSRname.Text = "SR_SPA Ver1.0.0";
			this.MenuSRname.UseVisualStyleBackColor = false;
			// 
			// MenuAlarm
			// 
			this.MenuAlarm.BackColor = System.Drawing.Color.Transparent;
			this.MenuAlarm.FlatAppearance.BorderSize = 0;
			this.MenuAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuAlarm.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuAlarm.Image = global::Project.Properties.Resources.Alarm;
			this.MenuAlarm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuAlarm.Location = new System.Drawing.Point(184, 2);
			this.MenuAlarm.Margin = new System.Windows.Forms.Padding(2);
			this.MenuAlarm.Name = "MenuAlarm";
			this.MenuAlarm.Size = new System.Drawing.Size(75, 80);
			this.MenuAlarm.TabIndex = 23;
			this.MenuAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuAlarm.UseVisualStyleBackColor = false;
			this.MenuAlarm.Click += new System.EventHandler(this.MenuAlarm_Click);
			// 
			// MenuManual
			// 
			this.MenuManual.BackColor = System.Drawing.Color.Transparent;
			this.MenuManual.FlatAppearance.BorderSize = 0;
			this.MenuManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuManual.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.MenuManual.Image = global::Project.Properties.Resources.Set;
			this.MenuManual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuManual.Location = new System.Drawing.Point(93, 2);
			this.MenuManual.Margin = new System.Windows.Forms.Padding(2);
			this.MenuManual.Name = "MenuManual";
			this.MenuManual.Size = new System.Drawing.Size(75, 80);
			this.MenuManual.TabIndex = 23;
			this.MenuManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuManual.UseVisualStyleBackColor = false;
			this.MenuManual.Click += new System.EventHandler(this.MenuManual_Click);
			// 
			// MenuMain
			// 
			this.MenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(218)))), ((int)(((byte)(151)))));
			this.MenuMain.FlatAppearance.BorderSize = 0;
			this.MenuMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuMain.Image = global::Project.Properties.Resources.Home_sel;
			this.MenuMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuMain.Location = new System.Drawing.Point(2, 2);
			this.MenuMain.Margin = new System.Windows.Forms.Padding(2);
			this.MenuMain.Name = "MenuMain";
			this.MenuMain.Size = new System.Drawing.Size(75, 80);
			this.MenuMain.TabIndex = 23;
			this.MenuMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MenuMain.UseVisualStyleBackColor = false;
			this.MenuMain.Click += new System.EventHandler(this.MenuMain_Click);
			// 
			// PanelForm
			// 
			this.PanelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelForm.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PanelForm.Location = new System.Drawing.Point(3, 90);
			this.PanelForm.Name = "PanelForm";
			this.PanelForm.Size = new System.Drawing.Size(1253, 632);
			this.PanelForm.TabIndex = 4;
			// 
			// timer_Main
			// 
			this.timer_Main.Interval = 1000;
			this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
			// 
			// panel_MainInfo
			// 
			this.panel_MainInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_MainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.panel_MainInfo.Controls.Add(this.label_User);
			this.panel_MainInfo.Controls.Add(this.label_Version);
			this.panel_MainInfo.Controls.Add(this.label_Day);
			this.panel_MainInfo.Location = new System.Drawing.Point(3, 728);
			this.panel_MainInfo.Name = "panel_MainInfo";
			this.panel_MainInfo.Size = new System.Drawing.Size(1253, 29);
			this.panel_MainInfo.TabIndex = 3;
			// 
			// label_User
			// 
			this.label_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_User.AutoSize = true;
			this.label_User.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_User.Location = new System.Drawing.Point(3, 9);
			this.label_User.Name = "label_User";
			this.label_User.Size = new System.Drawing.Size(113, 12);
			this.label_User.TabIndex = 1;
			this.label_User.Text = "权限:Administrator";
			// 
			// label_Version
			// 
			this.label_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Version.AutoSize = true;
			this.label_Version.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Version.Location = new System.Drawing.Point(920, 9);
			this.label_Version.Name = "label_Version";
			this.label_Version.Size = new System.Drawing.Size(101, 12);
			this.label_Version.TabIndex = 0;
			this.label_Version.Text = "版本号:Ver_1.0.0";
			// 
			// label_Day
			// 
			this.label_Day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Day.AutoSize = true;
			this.label_Day.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Day.Location = new System.Drawing.Point(1060, 9);
			this.label_Day.Name = "label_Day";
			this.label_Day.Size = new System.Drawing.Size(185, 12);
			this.label_Day.TabIndex = 0;
			this.label_Day.Text = "当前时间:2018年11月5日09:17:06";
			// 
			// FrameUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 762);
			this.Controls.Add(this.panel_MainInfo);
			this.Controls.Add(this.PanelForm);
			this.Controls.Add(this.pnlTitle);
			this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrameUI";
			this.Text = "Strong-SPA-Ver1.0.0";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrameUI_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrameUI_FormClosed);
			this.Load += new System.EventHandler(this.FrameUI_Load);
			this.SizeChanged += new System.EventHandler(this.FrameUI_SizeChanged);
			this.pnlTitle.ResumeLayout(false);
			this.panel_MainInfo.ResumeLayout(false);
			this.panel_MainInfo.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Button MenuPathPictrue;
		public System.Windows.Forms.Button MenuLogin;
		private System.Windows.Forms.Button MenuCamera;
		private System.Windows.Forms.Button MenuPathCSV;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button MenuEmg;
		private System.Windows.Forms.Button MenuReset;
		private System.Windows.Forms.Button MenuPause;
		private System.Windows.Forms.Button MenuRun;
		private System.Windows.Forms.Button MenuSRname;
		private System.Windows.Forms.Button MenuAlarm;
		private System.Windows.Forms.Button MenuManual;
		private System.Windows.Forms.Button MenuMain;
		private System.Windows.Forms.Panel PanelForm;
		public System.Windows.Forms.Timer timer_Main;
		private System.Windows.Forms.Panel panel_MainInfo;
		private System.Windows.Forms.Label label_User;
		private System.Windows.Forms.Label label_Version;
		private System.Windows.Forms.Label label_Day;
	}
}

