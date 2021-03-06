﻿namespace Project
{
	partial class DebugUI
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点6");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点7");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点8");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点9");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点10");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点11");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugUI));
			this.tabCtrlDebug = new System.Windows.Forms.TabControl();
			this.TabPagManual = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PointDistance = new System.Windows.Forms.NumericUpDown();
			this.CBSpeedLevel = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TB_RightStationLog = new System.Windows.Forms.TextBox();
			this.TB_LeftStationLog = new System.Windows.Forms.TextBox();
			this.checkBox_sup = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox3_safeLight = new System.Windows.Forms.CheckBox();
			this.checkBox3_statioOpen = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.AxisCfigBT = new System.Windows.Forms.Button();
			this.CBioMessage = new System.Windows.Forms.GroupBox();
			this.comboBox_IO = new System.Windows.Forms.ComboBox();
			this.plIOmessage = new System.Windows.Forms.Panel();
			this.CBStnChioce = new System.Windows.Forms.ComboBox();
			this.AXISgroupBox = new System.Windows.Forms.GroupBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox_Axis = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.button_home = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.CBChoiceAxis = new System.Windows.Forms.ComboBox();
			this.OpenSevroBT = new System.Windows.Forms.Button();
			this.tabPage_automatic = new System.Windows.Forms.TabPage();
			this.TabPagConnect = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage_config = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage_PortSetting = new System.Windows.Forms.TabPage();
			this.tabPage_Log = new System.Windows.Forms.TabPage();
			this.textBox_Log = new System.Windows.Forms.TextBox();
			this.tabPage_Flow = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox_FlowName = new System.Windows.Forms.ComboBox();
			this.treeView_FlowStruct = new System.Windows.Forms.TreeView();
			this.tabCtrlDebug.SuspendLayout();
			this.TabPagManual.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PointDistance)).BeginInit();
			this.CBioMessage.SuspendLayout();
			this.AXISgroupBox.SuspendLayout();
			this.tabPage_Log.SuspendLayout();
			this.tabPage_Flow.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCtrlDebug
			// 
			this.tabCtrlDebug.Controls.Add(this.TabPagManual);
			this.tabCtrlDebug.Controls.Add(this.tabPage_automatic);
			this.tabCtrlDebug.Controls.Add(this.TabPagConnect);
			this.tabCtrlDebug.Controls.Add(this.tabPage1);
			this.tabCtrlDebug.Controls.Add(this.tabPage_config);
			this.tabCtrlDebug.Controls.Add(this.tabPage2);
			this.tabCtrlDebug.Controls.Add(this.tabPage_PortSetting);
			this.tabCtrlDebug.Controls.Add(this.tabPage_Log);
			this.tabCtrlDebug.Controls.Add(this.tabPage_Flow);
			this.tabCtrlDebug.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlDebug.Location = new System.Drawing.Point(0, 0);
			this.tabCtrlDebug.Name = "tabCtrlDebug";
			this.tabCtrlDebug.SelectedIndex = 0;
			this.tabCtrlDebug.Size = new System.Drawing.Size(1250, 660);
			this.tabCtrlDebug.TabIndex = 1;
			// 
			// TabPagManual
			// 
			this.TabPagManual.BackColor = System.Drawing.SystemColors.Control;
			this.TabPagManual.Controls.Add(this.comboBox1);
			this.TabPagManual.Controls.Add(this.label3);
			this.TabPagManual.Controls.Add(this.PointDistance);
			this.TabPagManual.Controls.Add(this.CBSpeedLevel);
			this.TabPagManual.Controls.Add(this.label6);
			this.TabPagManual.Controls.Add(this.checkBox5);
			this.TabPagManual.Controls.Add(this.checkBox4);
			this.TabPagManual.Controls.Add(this.label2);
			this.TabPagManual.Controls.Add(this.label1);
			this.TabPagManual.Controls.Add(this.TB_RightStationLog);
			this.TabPagManual.Controls.Add(this.TB_LeftStationLog);
			this.TabPagManual.Controls.Add(this.checkBox_sup);
			this.TabPagManual.Controls.Add(this.checkBox3);
			this.TabPagManual.Controls.Add(this.checkBox3_safeLight);
			this.TabPagManual.Controls.Add(this.checkBox3_statioOpen);
			this.TabPagManual.Controls.Add(this.button3);
			this.TabPagManual.Controls.Add(this.checkBox1);
			this.TabPagManual.Controls.Add(this.button2);
			this.TabPagManual.Controls.Add(this.button1);
			this.TabPagManual.Controls.Add(this.AxisCfigBT);
			this.TabPagManual.Controls.Add(this.CBioMessage);
			this.TabPagManual.Controls.Add(this.CBStnChioce);
			this.TabPagManual.Controls.Add(this.AXISgroupBox);
			this.TabPagManual.Location = new System.Drawing.Point(4, 22);
			this.TabPagManual.Name = "TabPagManual";
			this.TabPagManual.Padding = new System.Windows.Forms.Padding(3);
			this.TabPagManual.Size = new System.Drawing.Size(1242, 634);
			this.TabPagManual.TabIndex = 0;
			this.TabPagManual.Text = "手动调试系统";
			this.TabPagManual.Click += new System.EventHandler(this.TabPagManual_Enter);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "连续",
            "寸动"});
			this.comboBox1.Location = new System.Drawing.Point(1079, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(77, 20);
			this.comboBox1.TabIndex = 64;
			this.comboBox1.Text = "连续";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(1077, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 63;
			this.label3.Text = "移动距离:";
			// 
			// PointDistance
			// 
			this.PointDistance.DecimalPlaces = 3;
			this.PointDistance.Location = new System.Drawing.Point(1145, 31);
			this.PointDistance.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.PointDistance.Name = "PointDistance";
			this.PointDistance.Size = new System.Drawing.Size(77, 21);
			this.PointDistance.TabIndex = 62;
			this.PointDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.PointDistance.ValueChanged += new System.EventHandler(this.PointDistance_ValueChanged);
			// 
			// CBSpeedLevel
			// 
			this.CBSpeedLevel.FormattingEnabled = true;
			this.CBSpeedLevel.Location = new System.Drawing.Point(1014, 4);
			this.CBSpeedLevel.Name = "CBSpeedLevel";
			this.CBSpeedLevel.Size = new System.Drawing.Size(54, 20);
			this.CBSpeedLevel.TabIndex = 60;
			this.CBSpeedLevel.SelectedIndexChanged += new System.EventHandler(this.CBSpeedLevel_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(946, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 61;
			this.label6.Text = "速度等级:";
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(828, 10);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(72, 16);
			this.checkBox5.TabIndex = 58;
			this.checkBox5.Text = "门限屏蔽";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(828, 35);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(72, 16);
			this.checkBox4.TabIndex = 57;
			this.checkBox4.Text = "防呆解除";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 12);
			this.label2.TabIndex = 56;
			this.label2.Text = "右工位LOG索引";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 12);
			this.label1.TabIndex = 55;
			this.label1.Text = "左工位LOG索引";
			this.label1.Visible = false;
			// 
			// TB_RightStationLog
			// 
			this.TB_RightStationLog.Location = new System.Drawing.Point(299, 134);
			this.TB_RightStationLog.Name = "TB_RightStationLog";
			this.TB_RightStationLog.Size = new System.Drawing.Size(25, 21);
			this.TB_RightStationLog.TabIndex = 54;
			this.TB_RightStationLog.Text = "0";
			this.TB_RightStationLog.Visible = false;
			this.TB_RightStationLog.TextChanged += new System.EventHandler(this.TB_RightStationLog_TextChanged);
			// 
			// TB_LeftStationLog
			// 
			this.TB_LeftStationLog.Location = new System.Drawing.Point(176, 134);
			this.TB_LeftStationLog.Name = "TB_LeftStationLog";
			this.TB_LeftStationLog.Size = new System.Drawing.Size(35, 21);
			this.TB_LeftStationLog.TabIndex = 53;
			this.TB_LeftStationLog.Text = "0";
			this.TB_LeftStationLog.Visible = false;
			this.TB_LeftStationLog.TextChanged += new System.EventHandler(this.TB_LeftStationLog_TextChanged);
			// 
			// checkBox_sup
			// 
			this.checkBox_sup.AutoSize = true;
			this.checkBox_sup.Checked = true;
			this.checkBox_sup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_sup.Location = new System.Drawing.Point(720, 35);
			this.checkBox_sup.Name = "checkBox_sup";
			this.checkBox_sup.Size = new System.Drawing.Size(96, 16);
			this.checkBox_sup.TabIndex = 52;
			this.checkBox_sup.Text = "暂停立即停止";
			this.checkBox_sup.UseVisualStyleBackColor = true;
			this.checkBox_sup.CheckedChanged += new System.EventHandler(this.checkBox_sup_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(950, 33);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(120, 16);
			this.checkBox3.TabIndex = 50;
			this.checkBox3.Text = "不需要复位可移动";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox3_safeLight
			// 
			this.checkBox3_safeLight.AutoSize = true;
			this.checkBox3_safeLight.Checked = true;
			this.checkBox3_safeLight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3_safeLight.Location = new System.Drawing.Point(720, 10);
			this.checkBox3_safeLight.Name = "checkBox3_safeLight";
			this.checkBox3_safeLight.Size = new System.Drawing.Size(96, 16);
			this.checkBox3_safeLight.TabIndex = 49;
			this.checkBox3_safeLight.Text = "安全光栅屏蔽";
			this.checkBox3_safeLight.UseVisualStyleBackColor = true;
			this.checkBox3_safeLight.CheckedChanged += new System.EventHandler(this.checkBox3_safeLight_CheckedChanged);
			// 
			// checkBox3_statioOpen
			// 
			this.checkBox3_statioOpen.AutoSize = true;
			this.checkBox3_statioOpen.Location = new System.Drawing.Point(636, 35);
			this.checkBox3_statioOpen.Name = "checkBox3_statioOpen";
			this.checkBox3_statioOpen.Size = new System.Drawing.Size(72, 16);
			this.checkBox3_statioOpen.TabIndex = 48;
			this.checkBox3_statioOpen.Text = "工位展开";
			this.checkBox3_statioOpen.UseVisualStyleBackColor = true;
			this.checkBox3_statioOpen.CheckedChanged += new System.EventHandler(this.checkBox3_statioOpen_CheckedChanged);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(221, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(67, 32);
			this.button3.TabIndex = 47;
			this.button3.Text = "工位管理";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(636, 10);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 16);
			this.checkBox1.TabIndex = 46;
			this.checkBox1.Text = "工位联动";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(375, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(67, 32);
			this.button2.TabIndex = 45;
			this.button2.Text = "下一步";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(298, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 32);
			this.button1.TabIndex = 44;
			this.button1.Text = "工位运动";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AxisCfigBT
			// 
			this.AxisCfigBT.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AxisCfigBT.Location = new System.Drawing.Point(144, 2);
			this.AxisCfigBT.Name = "AxisCfigBT";
			this.AxisCfigBT.Size = new System.Drawing.Size(67, 32);
			this.AxisCfigBT.TabIndex = 7;
			this.AxisCfigBT.Text = "工位配置";
			this.AxisCfigBT.UseVisualStyleBackColor = true;
			this.AxisCfigBT.Click += new System.EventHandler(this.AxisCfigBT_Click);
			// 
			// CBioMessage
			// 
			this.CBioMessage.AutoSize = true;
			this.CBioMessage.Controls.Add(this.comboBox_IO);
			this.CBioMessage.Controls.Add(this.plIOmessage);
			this.CBioMessage.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CBioMessage.Location = new System.Drawing.Point(633, 348);
			this.CBioMessage.Name = "CBioMessage";
			this.CBioMessage.Size = new System.Drawing.Size(600, 260);
			this.CBioMessage.TabIndex = 42;
			this.CBioMessage.TabStop = false;
			this.CBioMessage.Text = "I/O信息栏";
			// 
			// comboBox_IO
			// 
			this.comboBox_IO.FormattingEnabled = true;
			this.comboBox_IO.Location = new System.Drawing.Point(72, 0);
			this.comboBox_IO.Name = "comboBox_IO";
			this.comboBox_IO.Size = new System.Drawing.Size(111, 20);
			this.comboBox_IO.TabIndex = 41;
			this.comboBox_IO.Text = "请选择 ";
			// 
			// plIOmessage
			// 
			this.plIOmessage.AutoScroll = true;
			this.plIOmessage.BackColor = System.Drawing.Color.White;
			this.plIOmessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plIOmessage.Location = new System.Drawing.Point(3, 17);
			this.plIOmessage.Name = "plIOmessage";
			this.plIOmessage.Size = new System.Drawing.Size(594, 240);
			this.plIOmessage.TabIndex = 40;
			// 
			// CBStnChioce
			// 
			this.CBStnChioce.FormattingEnabled = true;
			this.CBStnChioce.Location = new System.Drawing.Point(7, 8);
			this.CBStnChioce.Name = "CBStnChioce";
			this.CBStnChioce.Size = new System.Drawing.Size(127, 20);
			this.CBStnChioce.TabIndex = 35;
			this.CBStnChioce.Text = "总复位";
			this.CBStnChioce.SelectedIndexChanged += new System.EventHandler(this.StnChioceCB_SelectedIndexChanged);
			// 
			// AXISgroupBox
			// 
			this.AXISgroupBox.Controls.Add(this.checkBox6);
			this.AXISgroupBox.Controls.Add(this.checkBox2);
			this.AXISgroupBox.Controls.Add(this.button4);
			this.AXISgroupBox.Controls.Add(this.groupBox_Axis);
			this.AXISgroupBox.Controls.Add(this.label15);
			this.AXISgroupBox.Controls.Add(this.label17);
			this.AXISgroupBox.Controls.Add(this.button_home);
			this.AXISgroupBox.Controls.Add(this.label8);
			this.AXISgroupBox.Controls.Add(this.label16);
			this.AXISgroupBox.Controls.Add(this.CBChoiceAxis);
			this.AXISgroupBox.Controls.Add(this.OpenSevroBT);
			this.AXISgroupBox.Location = new System.Drawing.Point(633, 50);
			this.AXISgroupBox.Name = "AXISgroupBox";
			this.AXISgroupBox.Size = new System.Drawing.Size(600, 295);
			this.AXISgroupBox.TabIndex = 3;
			this.AXISgroupBox.TabStop = false;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Enabled = false;
			this.checkBox6.Location = new System.Drawing.Point(8, 27);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(60, 16);
			this.checkBox6.TabIndex = 25;
			this.checkBox6.Text = "不带料";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(8, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(48, 16);
			this.checkBox2.TabIndex = 25;
			this.checkBox2.Text = "空跑";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button4.Location = new System.Drawing.Point(6, 253);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(65, 32);
			this.button4.TabIndex = 24;
			this.button4.Text = "防呆配置";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox_Axis
			// 
			this.groupBox_Axis.AutoScroll = true;
			this.groupBox_Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
			this.groupBox_Axis.Location = new System.Drawing.Point(77, 9);
			this.groupBox_Axis.Name = "groupBox_Axis";
			this.groupBox_Axis.Size = new System.Drawing.Size(517, 280);
			this.groupBox_Axis.TabIndex = 23;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(12, 50);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(53, 12);
			this.label15.TabIndex = 22;
			this.label15.Text = "使能信号";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label17.Location = new System.Drawing.Point(12, 135);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(53, 12);
			this.label17.TabIndex = 20;
			this.label17.Text = "实际位置";
			// 
			// button_home
			// 
			this.button_home.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_home.Location = new System.Drawing.Point(6, 221);
			this.button_home.Name = "button_home";
			this.button_home.Size = new System.Drawing.Size(65, 32);
			this.button_home.TabIndex = 13;
			this.button_home.Text = "回零";
			this.button_home.UseVisualStyleBackColor = true;
			this.button_home.Click += new System.EventHandler(this.button_home_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(12, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 12);
			this.label8.TabIndex = 21;
			this.label8.Text = "限位信号";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(12, 110);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(53, 12);
			this.label16.TabIndex = 21;
			this.label16.Text = "指令位置";
			// 
			// CBChoiceAxis
			// 
			this.CBChoiceAxis.FormattingEnabled = true;
			this.CBChoiceAxis.Location = new System.Drawing.Point(6, 167);
			this.CBChoiceAxis.Name = "CBChoiceAxis";
			this.CBChoiceAxis.Size = new System.Drawing.Size(65, 20);
			this.CBChoiceAxis.TabIndex = 18;
			// 
			// OpenSevroBT
			// 
			this.OpenSevroBT.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OpenSevroBT.Location = new System.Drawing.Point(6, 189);
			this.OpenSevroBT.Name = "OpenSevroBT";
			this.OpenSevroBT.Size = new System.Drawing.Size(65, 32);
			this.OpenSevroBT.TabIndex = 11;
			this.OpenSevroBT.Text = "打开使能";
			this.OpenSevroBT.UseVisualStyleBackColor = true;
			this.OpenSevroBT.Click += new System.EventHandler(this.OpenSevroBT_Click);
			// 
			// tabPage_automatic
			// 
			this.tabPage_automatic.Location = new System.Drawing.Point(4, 22);
			this.tabPage_automatic.Name = "tabPage_automatic";
			this.tabPage_automatic.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_automatic.Size = new System.Drawing.Size(1242, 634);
			this.tabPage_automatic.TabIndex = 2;
			this.tabPage_automatic.Text = "IO模块";
			this.tabPage_automatic.UseVisualStyleBackColor = true;
			// 
			// TabPagConnect
			// 
			this.TabPagConnect.BackColor = System.Drawing.SystemColors.Control;
			this.TabPagConnect.Location = new System.Drawing.Point(4, 22);
			this.TabPagConnect.Name = "TabPagConnect";
			this.TabPagConnect.Padding = new System.Windows.Forms.Padding(3);
			this.TabPagConnect.Size = new System.Drawing.Size(1242, 634);
			this.TabPagConnect.TabIndex = 1;
			this.TabPagConnect.Text = "通讯调试系统";
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1242, 634);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "模块启动";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage_config
			// 
			this.tabPage_config.Location = new System.Drawing.Point(4, 22);
			this.tabPage_config.Name = "tabPage_config";
			this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_config.Size = new System.Drawing.Size(1242, 634);
			this.tabPage_config.TabIndex = 4;
			this.tabPage_config.Text = "配置文件管理";
			this.tabPage_config.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1242, 634);
			this.tabPage2.TabIndex = 5;
			this.tabPage2.Text = "参数保存";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage_PortSetting
			// 
			this.tabPage_PortSetting.Location = new System.Drawing.Point(4, 22);
			this.tabPage_PortSetting.Name = "tabPage_PortSetting";
			this.tabPage_PortSetting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_PortSetting.Size = new System.Drawing.Size(1242, 634);
			this.tabPage_PortSetting.TabIndex = 6;
			this.tabPage_PortSetting.Text = "串口配置";
			this.tabPage_PortSetting.UseVisualStyleBackColor = true;
			// 
			// tabPage_Log
			// 
			this.tabPage_Log.Controls.Add(this.textBox_Log);
			this.tabPage_Log.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Log.Name = "tabPage_Log";
			this.tabPage_Log.Size = new System.Drawing.Size(1242, 634);
			this.tabPage_Log.TabIndex = 7;
			this.tabPage_Log.Text = "Log";
			this.tabPage_Log.UseVisualStyleBackColor = true;
			// 
			// textBox_Log
			// 
			this.textBox_Log.Location = new System.Drawing.Point(3, 21);
			this.textBox_Log.Multiline = true;
			this.textBox_Log.Name = "textBox_Log";
			this.textBox_Log.Size = new System.Drawing.Size(796, 419);
			this.textBox_Log.TabIndex = 0;
			// 
			// tabPage_Flow
			// 
			this.tabPage_Flow.Controls.Add(this.button5);
			this.tabPage_Flow.Controls.Add(this.groupBox2);
			this.tabPage_Flow.Controls.Add(this.groupBox1);
			this.tabPage_Flow.Controls.Add(this.comboBox_FlowName);
			this.tabPage_Flow.Controls.Add(this.treeView_FlowStruct);
			this.tabPage_Flow.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Flow.Name = "tabPage_Flow";
			this.tabPage_Flow.Size = new System.Drawing.Size(1242, 634);
			this.tabPage_Flow.TabIndex = 8;
			this.tabPage_Flow.Text = "流程配置系统_测试";
			this.tabPage_Flow.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(367, 418);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "保存";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(367, 219);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(581, 161);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "IO信息";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 17);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(575, 141);
			this.dataGridView2.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(367, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(581, 197);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "轴信息";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(575, 177);
			this.dataGridView1.TabIndex = 2;
			// 
			// comboBox_FlowName
			// 
			this.comboBox_FlowName.FormattingEnabled = true;
			this.comboBox_FlowName.Location = new System.Drawing.Point(42, 19);
			this.comboBox_FlowName.Name = "comboBox_FlowName";
			this.comboBox_FlowName.Size = new System.Drawing.Size(284, 20);
			this.comboBox_FlowName.TabIndex = 1;
			this.comboBox_FlowName.SelectedIndexChanged += new System.EventHandler(this.comboBox_FlowName_SelectedIndexChanged);
			// 
			// treeView_FlowStruct
			// 
			this.treeView_FlowStruct.Location = new System.Drawing.Point(42, 65);
			this.treeView_FlowStruct.Name = "treeView_FlowStruct";
			treeNode1.Name = "节点6";
			treeNode1.Text = "节点6";
			treeNode2.Name = "节点7";
			treeNode2.Text = "节点7";
			treeNode3.Name = "节点8";
			treeNode3.Text = "节点8";
			treeNode4.Name = "节点9";
			treeNode4.Text = "节点9";
			treeNode5.Name = "节点10";
			treeNode5.Text = "节点10";
			treeNode6.Name = "节点11";
			treeNode6.Text = "节点11";
			treeNode7.Name = "节点5";
			treeNode7.Text = "节点5";
			this.treeView_FlowStruct.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
			this.treeView_FlowStruct.Size = new System.Drawing.Size(284, 457);
			this.treeView_FlowStruct.TabIndex = 0;
			this.treeView_FlowStruct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_FlowStruct_MouseDown);
			// 
			// DebugUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 660);
			this.Controls.Add(this.tabCtrlDebug);
			this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DebugUI";
			this.Text = "DebugUI";
			this.Load += new System.EventHandler(this.FrmDebug_Load);
			this.tabCtrlDebug.ResumeLayout(false);
			this.TabPagManual.ResumeLayout(false);
			this.TabPagManual.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PointDistance)).EndInit();
			this.CBioMessage.ResumeLayout(false);
			this.AXISgroupBox.ResumeLayout(false);
			this.AXISgroupBox.PerformLayout();
			this.tabPage_Log.ResumeLayout(false);
			this.tabPage_Log.PerformLayout();
			this.tabPage_Flow.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlDebug;
		private System.Windows.Forms.TabPage TabPagManual;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown PointDistance;
		private System.Windows.Forms.ComboBox CBSpeedLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_RightStationLog;
		private System.Windows.Forms.TextBox TB_LeftStationLog;
		private System.Windows.Forms.CheckBox checkBox_sup;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox3_safeLight;
		private System.Windows.Forms.CheckBox checkBox3_statioOpen;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button AxisCfigBT;
		private System.Windows.Forms.GroupBox CBioMessage;
		private System.Windows.Forms.ComboBox comboBox_IO;
		private System.Windows.Forms.Panel plIOmessage;
		private System.Windows.Forms.ComboBox CBStnChioce;
		private System.Windows.Forms.GroupBox AXISgroupBox;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel groupBox_Axis;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button_home;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox CBChoiceAxis;
		private System.Windows.Forms.Button OpenSevroBT;
		private System.Windows.Forms.TabPage tabPage_automatic;
		private System.Windows.Forms.TabPage TabPagConnect;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage_config;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage_PortSetting;
		private System.Windows.Forms.TabPage tabPage_Log;
		private System.Windows.Forms.TextBox textBox_Log;
		private System.Windows.Forms.TabPage tabPage_Flow;
		private System.Windows.Forms.ComboBox comboBox_FlowName;
		private System.Windows.Forms.TreeView treeView_FlowStruct;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}