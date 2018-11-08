namespace Project
{
	partial class MainUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
			this.label_Status = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_Clear = new System.Windows.Forms.Button();
			this.cbClearBktTrayFinish = new System.Windows.Forms.CheckBox();
			this.cbUpBktTrayFinish = new System.Windows.Forms.CheckBox();
			this.panel_Charts = new System.Windows.Forms.Panel();
			this.FormStatus = new System.Windows.Forms.Timer(this.components);
			this.btTossingCount = new System.Windows.Forms.Button();
			this.uphCount = new System.Windows.Forms.Button();
			this.alramTime = new System.Windows.Forms.Button();
			this.bterrorCODE = new System.Windows.Forms.Button();
			this.timer_MainUI = new System.Windows.Forms.Timer(this.components);
			this.panel_NG = new System.Windows.Forms.Panel();
			this.groupBox_RunData = new System.Windows.Forms.GroupBox();
			this.groupBox_RunInfo = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Status
			// 
			this.label_Status.BackColor = System.Drawing.Color.Transparent;
			this.label_Status.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Status.Location = new System.Drawing.Point(672, 4);
			this.label_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_Status.Name = "label_Status";
			this.label_Status.Size = new System.Drawing.Size(232, 71);
			this.label_Status.TabIndex = 355;
			this.label_Status.Text = "待复位";
			this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(218)))), ((int)(((byte)(151)))));
			this.panel1.Controls.Add(this.button_Clear);
			this.panel1.Controls.Add(this.cbClearBktTrayFinish);
			this.panel1.Controls.Add(this.cbUpBktTrayFinish);
			this.panel1.Location = new System.Drawing.Point(1031, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 72);
			this.panel1.TabIndex = 457;
			// 
			// button_Clear
			// 
			this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Clear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_Clear.Image = ((System.Drawing.Image)(resources.GetObject("button_Clear.Image")));
			this.button_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Clear.Location = new System.Drawing.Point(13, 15);
			this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.Size = new System.Drawing.Size(93, 45);
			this.button_Clear.TabIndex = 5;
			this.button_Clear.Text = "数量清零";
			this.button_Clear.UseVisualStyleBackColor = true;
			this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
			// 
			// cbClearBktTrayFinish
			// 
			this.cbClearBktTrayFinish.AutoSize = true;
			this.cbClearBktTrayFinish.Location = new System.Drawing.Point(123, 16);
			this.cbClearBktTrayFinish.Margin = new System.Windows.Forms.Padding(2);
			this.cbClearBktTrayFinish.Name = "cbClearBktTrayFinish";
			this.cbClearBktTrayFinish.Size = new System.Drawing.Size(72, 16);
			this.cbClearBktTrayFinish.TabIndex = 4;
			this.cbClearBktTrayFinish.Text = "清料完成";
			this.cbClearBktTrayFinish.UseVisualStyleBackColor = true;
			// 
			// cbUpBktTrayFinish
			// 
			this.cbUpBktTrayFinish.AutoSize = true;
			this.cbUpBktTrayFinish.Location = new System.Drawing.Point(123, 41);
			this.cbUpBktTrayFinish.Margin = new System.Windows.Forms.Padding(2);
			this.cbUpBktTrayFinish.Name = "cbUpBktTrayFinish";
			this.cbUpBktTrayFinish.Size = new System.Drawing.Size(72, 16);
			this.cbUpBktTrayFinish.TabIndex = 3;
			this.cbUpBktTrayFinish.Text = "上料完成";
			this.cbUpBktTrayFinish.UseVisualStyleBackColor = true;
			// 
			// panel_Charts
			// 
			this.panel_Charts.Location = new System.Drawing.Point(12, 80);
			this.panel_Charts.Name = "panel_Charts";
			this.panel_Charts.Size = new System.Drawing.Size(610, 373);
			this.panel_Charts.TabIndex = 458;
			// 
			// FormStatus
			// 
			this.FormStatus.Enabled = true;
			// 
			// btTossingCount
			// 
			this.btTossingCount.BackColor = System.Drawing.Color.Transparent;
			this.btTossingCount.FlatAppearance.BorderSize = 0;
			this.btTossingCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTossingCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btTossingCount.Image = ((System.Drawing.Image)(resources.GetObject("btTossingCount.Image")));
			this.btTossingCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btTossingCount.Location = new System.Drawing.Point(410, 11);
			this.btTossingCount.Margin = new System.Windows.Forms.Padding(2);
			this.btTossingCount.Name = "btTossingCount";
			this.btTossingCount.Size = new System.Drawing.Size(123, 64);
			this.btTossingCount.TabIndex = 456;
			this.btTossingCount.Text = "Tossing Count";
			this.btTossingCount.UseVisualStyleBackColor = false;
			// 
			// uphCount
			// 
			this.uphCount.BackColor = System.Drawing.Color.Transparent;
			this.uphCount.FlatAppearance.BorderSize = 0;
			this.uphCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.uphCount.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.uphCount.Image = ((System.Drawing.Image)(resources.GetObject("uphCount.Image")));
			this.uphCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.uphCount.Location = new System.Drawing.Point(276, 11);
			this.uphCount.Margin = new System.Windows.Forms.Padding(2);
			this.uphCount.Name = "uphCount";
			this.uphCount.Size = new System.Drawing.Size(123, 64);
			this.uphCount.TabIndex = 453;
			this.uphCount.Text = "CT";
			this.uphCount.UseVisualStyleBackColor = false;
			// 
			// alramTime
			// 
			this.alramTime.BackColor = System.Drawing.Color.Transparent;
			this.alramTime.FlatAppearance.BorderSize = 0;
			this.alramTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.alramTime.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.alramTime.Image = global::Project.Properties.Resources.bigbk_red;
			this.alramTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.alramTime.Location = new System.Drawing.Point(143, 11);
			this.alramTime.Margin = new System.Windows.Forms.Padding(2);
			this.alramTime.Name = "alramTime";
			this.alramTime.Size = new System.Drawing.Size(123, 64);
			this.alramTime.TabIndex = 455;
			this.alramTime.Text = "Alarm Time";
			this.alramTime.UseVisualStyleBackColor = false;
			// 
			// bterrorCODE
			// 
			this.bterrorCODE.BackColor = System.Drawing.Color.Transparent;
			this.bterrorCODE.FlatAppearance.BorderSize = 0;
			this.bterrorCODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bterrorCODE.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.bterrorCODE.Image = global::Project.Properties.Resources.bigbk_red;
			this.bterrorCODE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bterrorCODE.Location = new System.Drawing.Point(11, 11);
			this.bterrorCODE.Margin = new System.Windows.Forms.Padding(2);
			this.bterrorCODE.Name = "bterrorCODE";
			this.bterrorCODE.Size = new System.Drawing.Size(123, 64);
			this.bterrorCODE.TabIndex = 454;
			this.bterrorCODE.Text = "Error Code";
			this.bterrorCODE.UseVisualStyleBackColor = false;
			// 
			// timer_MainUI
			// 
			this.timer_MainUI.Tick += new System.EventHandler(this.timer_MainUI_Tick);
			// 
			// panel_NG
			// 
			this.panel_NG.BackColor = System.Drawing.SystemColors.Control;
			this.panel_NG.Location = new System.Drawing.Point(631, 80);
			this.panel_NG.Name = "panel_NG";
			this.panel_NG.Size = new System.Drawing.Size(610, 373);
			this.panel_NG.TabIndex = 461;
			// 
			// groupBox_RunData
			// 
			this.groupBox_RunData.Location = new System.Drawing.Point(11, 460);
			this.groupBox_RunData.Name = "groupBox_RunData";
			this.groupBox_RunData.Size = new System.Drawing.Size(611, 169);
			this.groupBox_RunData.TabIndex = 462;
			this.groupBox_RunData.TabStop = false;
			this.groupBox_RunData.Text = "生产数据";
			// 
			// groupBox_RunInfo
			// 
			this.groupBox_RunInfo.Location = new System.Drawing.Point(631, 460);
			this.groupBox_RunInfo.Name = "groupBox_RunInfo";
			this.groupBox_RunInfo.Size = new System.Drawing.Size(611, 169);
			this.groupBox_RunInfo.TabIndex = 463;
			this.groupBox_RunInfo.TabStop = false;
			this.groupBox_RunInfo.Text = "运行信息";
			// 
			// MainUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1253, 632);
			this.Controls.Add(this.groupBox_RunInfo);
			this.Controls.Add(this.groupBox_RunData);
			this.Controls.Add(this.panel_NG);
			this.Controls.Add(this.panel_Charts);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btTossingCount);
			this.Controls.Add(this.uphCount);
			this.Controls.Add(this.alramTime);
			this.Controls.Add(this.bterrorCODE);
			this.Controls.Add(this.label_Status);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainUI";
			this.Text = "MainUI";
			this.Load += new System.EventHandler(this.MainUI_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label_Status;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button bterrorCODE;
		private System.Windows.Forms.Button alramTime;
		private System.Windows.Forms.Button uphCount;
		private System.Windows.Forms.Button btTossingCount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_Clear;
		public System.Windows.Forms.CheckBox cbClearBktTrayFinish;
		public System.Windows.Forms.CheckBox cbUpBktTrayFinish;
		private System.Windows.Forms.Panel panel_Charts;
		private System.Windows.Forms.Timer FormStatus;
		private System.Windows.Forms.Timer timer_MainUI;
		private System.Windows.Forms.Panel panel_NG;
		private System.Windows.Forms.GroupBox groupBox_RunData;
		private System.Windows.Forms.GroupBox groupBox_RunInfo;
	}
}