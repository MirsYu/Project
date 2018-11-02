namespace Project
{
	partial class PointDebugSetUI
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
			this.button_Output_IO_ImportIn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button_OneKeySetting = new System.Windows.Forms.Button();
			this.comboBox_SetType = new System.Windows.Forms.ComboBox();
			this.button_PointStep_ImportIn = new System.Windows.Forms.Button();
			this.button_PointStep_ImportOut = new System.Windows.Forms.Button();
			this.button_SetSpeed = new System.Windows.Forms.Button();
			this.numSpeed = new System.Windows.Forms.NumericUpDown();
			this.cboAxisName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_RefreshPoint = new System.Windows.Forms.Button();
			this.button_AddPoint = new System.Windows.Forms.Button();
			this.panel_Point = new System.Windows.Forms.Panel();
			this.button_DelAllPoint = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button_Output_IONoCard_ImportIn = new System.Windows.Forms.Button();
			this.button_Save = new System.Windows.Forms.Button();
			this.button_OutputIO_ImportOut = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button_Axis_Refresh = new System.Windows.Forms.Button();
			this.button_Axis_Reference = new System.Windows.Forms.Button();
			this.button_Axis_ImportIn = new System.Windows.Forms.Button();
			this.button_Axis_ImportOut = new System.Windows.Forms.Button();
			this.button_RemoveAxis = new System.Windows.Forms.Button();
			this.panel_Axis = new System.Windows.Forms.Panel();
			this.button_AddAxis = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button_Input_IO_ImportIn = new System.Windows.Forms.Button();
			this.button_Input_IONoCard_ImportIn = new System.Windows.Forms.Button();
			this.button_InputIO_ImportOut = new System.Windows.Forms.Button();
			this.button_RemoveInputIo = new System.Windows.Forms.Button();
			this.button_AddInputIo = new System.Windows.Forms.Button();
			this.panel_InputIo = new System.Windows.Forms.Panel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button_RemoveOutputIo = new System.Windows.Forms.Button();
			this.button_AddOutputIo = new System.Windows.Forms.Button();
			this.panel_OutputIo = new System.Windows.Forms.Panel();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Output_IO_ImportIn
			// 
			this.button_Output_IO_ImportIn.Location = new System.Drawing.Point(569, 394);
			this.button_Output_IO_ImportIn.Name = "button_Output_IO_ImportIn";
			this.button_Output_IO_ImportIn.Size = new System.Drawing.Size(100, 32);
			this.button_Output_IO_ImportIn.TabIndex = 52;
			this.button_Output_IO_ImportIn.Text = "IO导入(卡号）";
			this.button_Output_IO_ImportIn.UseVisualStyleBackColor = true;
			this.button_Output_IO_ImportIn.Click += new System.EventHandler(this.button_Output_IO_ImportIn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage4.Controls.Add(this.button_OneKeySetting);
			this.tabPage4.Controls.Add(this.comboBox_SetType);
			this.tabPage4.Controls.Add(this.button_PointStep_ImportIn);
			this.tabPage4.Controls.Add(this.button_PointStep_ImportOut);
			this.tabPage4.Controls.Add(this.button_SetSpeed);
			this.tabPage4.Controls.Add(this.numSpeed);
			this.tabPage4.Controls.Add(this.cboAxisName);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.button_RefreshPoint);
			this.tabPage4.Controls.Add(this.button_AddPoint);
			this.tabPage4.Controls.Add(this.panel_Point);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(793, 442);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "点位";
			// 
			// button_OneKeySetting
			// 
			this.button_OneKeySetting.Location = new System.Drawing.Point(336, 414);
			this.button_OneKeySetting.Name = "button_OneKeySetting";
			this.button_OneKeySetting.Size = new System.Drawing.Size(82, 26);
			this.button_OneKeySetting.TabIndex = 50;
			this.button_OneKeySetting.Text = "一键按比例设置";
			this.button_OneKeySetting.UseVisualStyleBackColor = true;
			this.button_OneKeySetting.Click += new System.EventHandler(this.button_OneKeySetting_Click);
			// 
			// comboBox_SetType
			// 
			this.comboBox_SetType.FormattingEnabled = true;
			this.comboBox_SetType.Items.AddRange(new object[] {
            "启始速度",
            "加速度",
            "加速时间",
            "运行速度",
            "减速度",
            "减速时间"});
			this.comboBox_SetType.Location = new System.Drawing.Point(154, 405);
			this.comboBox_SetType.Name = "comboBox_SetType";
			this.comboBox_SetType.Size = new System.Drawing.Size(79, 20);
			this.comboBox_SetType.TabIndex = 49;
			// 
			// button_PointStep_ImportIn
			// 
			this.button_PointStep_ImportIn.Location = new System.Drawing.Point(694, 392);
			this.button_PointStep_ImportIn.Name = "button_PointStep_ImportIn";
			this.button_PointStep_ImportIn.Size = new System.Drawing.Size(89, 32);
			this.button_PointStep_ImportIn.TabIndex = 48;
			this.button_PointStep_ImportIn.Text = "工位步骤导入";
			this.button_PointStep_ImportIn.UseVisualStyleBackColor = true;
			this.button_PointStep_ImportIn.Click += new System.EventHandler(this.button_PointStep_ImportIn_Click);
			// 
			// button_PointStep_ImportOut
			// 
			this.button_PointStep_ImportOut.Location = new System.Drawing.Point(604, 392);
			this.button_PointStep_ImportOut.Name = "button_PointStep_ImportOut";
			this.button_PointStep_ImportOut.Size = new System.Drawing.Size(89, 32);
			this.button_PointStep_ImportOut.TabIndex = 47;
			this.button_PointStep_ImportOut.Text = "工位步骤导出";
			this.button_PointStep_ImportOut.UseVisualStyleBackColor = true;
			this.button_PointStep_ImportOut.Click += new System.EventHandler(this.button_PointStep_ImportOut_Click);
			// 
			// button_SetSpeed
			// 
			this.button_SetSpeed.Location = new System.Drawing.Point(336, 386);
			this.button_SetSpeed.Name = "button_SetSpeed";
			this.button_SetSpeed.Size = new System.Drawing.Size(82, 26);
			this.button_SetSpeed.TabIndex = 15;
			this.button_SetSpeed.Text = "一键设置";
			this.button_SetSpeed.UseVisualStyleBackColor = true;
			this.button_SetSpeed.Click += new System.EventHandler(this.button_SetSpeed_Click);
			// 
			// numSpeed
			// 
			this.numSpeed.DecimalPlaces = 3;
			this.numSpeed.Location = new System.Drawing.Point(250, 404);
			this.numSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numSpeed.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.numSpeed.Name = "numSpeed";
			this.numSpeed.Size = new System.Drawing.Size(79, 21);
			this.numSpeed.TabIndex = 14;
			this.numSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// cboAxisName
			// 
			this.cboAxisName.FormattingEnabled = true;
			this.cboAxisName.Location = new System.Drawing.Point(58, 405);
			this.cboAxisName.Name = "cboAxisName";
			this.cboAxisName.Size = new System.Drawing.Size(79, 20);
			this.cboAxisName.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 407);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "轴名称";
			// 
			// button_RefreshPoint
			// 
			this.button_RefreshPoint.Location = new System.Drawing.Point(514, 392);
			this.button_RefreshPoint.Name = "button_RefreshPoint";
			this.button_RefreshPoint.Size = new System.Drawing.Size(89, 32);
			this.button_RefreshPoint.TabIndex = 10;
			this.button_RefreshPoint.Text = "刷新";
			this.button_RefreshPoint.UseVisualStyleBackColor = true;
			this.button_RefreshPoint.Click += new System.EventHandler(this.button_RefreshPoint_Click);
			// 
			// button_AddPoint
			// 
			this.button_AddPoint.Location = new System.Drawing.Point(424, 392);
			this.button_AddPoint.Name = "button_AddPoint";
			this.button_AddPoint.Size = new System.Drawing.Size(89, 32);
			this.button_AddPoint.TabIndex = 9;
			this.button_AddPoint.Text = "添加点";
			this.button_AddPoint.UseVisualStyleBackColor = true;
			this.button_AddPoint.Click += new System.EventHandler(this.button_AddPoint_Click);
			// 
			// panel_Point
			// 
			this.panel_Point.AutoScroll = true;
			this.panel_Point.BackColor = System.Drawing.SystemColors.Control;
			this.panel_Point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Point.Location = new System.Drawing.Point(8, 10);
			this.panel_Point.Name = "panel_Point";
			this.panel_Point.Size = new System.Drawing.Size(776, 368);
			this.panel_Point.TabIndex = 2;
			// 
			// button_DelAllPoint
			// 
			this.button_DelAllPoint.Location = new System.Drawing.Point(824, 88);
			this.button_DelAllPoint.Name = "button_DelAllPoint";
			this.button_DelAllPoint.Size = new System.Drawing.Size(94, 38);
			this.button_DelAllPoint.TabIndex = 52;
			this.button_DelAllPoint.Text = "删除所有点位";
			this.button_DelAllPoint.UseVisualStyleBackColor = true;
			this.button_DelAllPoint.Click += new System.EventHandler(this.button_DelAllPoint_Click);
			// 
			// button_Output_IONoCard_ImportIn
			// 
			this.button_Output_IONoCard_ImportIn.Location = new System.Drawing.Point(454, 394);
			this.button_Output_IONoCard_ImportIn.Name = "button_Output_IONoCard_ImportIn";
			this.button_Output_IONoCard_ImportIn.Size = new System.Drawing.Size(100, 32);
			this.button_Output_IONoCard_ImportIn.TabIndex = 51;
			this.button_Output_IONoCard_ImportIn.Text = "IO导入";
			this.button_Output_IONoCard_ImportIn.UseVisualStyleBackColor = true;
			this.button_Output_IONoCard_ImportIn.Click += new System.EventHandler(this.button_Output_IONoCard_ImportIn_Click);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(824, 25);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(94, 38);
			this.button_Save.TabIndex = 51;
			this.button_Save.Text = "保存工位配置";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// button_OutputIO_ImportOut
			// 
			this.button_OutputIO_ImportOut.Location = new System.Drawing.Point(339, 394);
			this.button_OutputIO_ImportOut.Name = "button_OutputIO_ImportOut";
			this.button_OutputIO_ImportOut.Size = new System.Drawing.Size(100, 32);
			this.button_OutputIO_ImportOut.TabIndex = 50;
			this.button_OutputIO_ImportOut.Text = "IO导出";
			this.button_OutputIO_ImportOut.UseVisualStyleBackColor = true;
			this.button_OutputIO_ImportOut.Click += new System.EventHandler(this.button_OutputIO_ImportOut_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(801, 468);
			this.tabControl1.TabIndex = 50;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.button_Axis_Refresh);
			this.tabPage1.Controls.Add(this.button_Axis_Reference);
			this.tabPage1.Controls.Add(this.button_Axis_ImportIn);
			this.tabPage1.Controls.Add(this.button_Axis_ImportOut);
			this.tabPage1.Controls.Add(this.button_RemoveAxis);
			this.tabPage1.Controls.Add(this.panel_Axis);
			this.tabPage1.Controls.Add(this.button_AddAxis);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(793, 442);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "轴";
			// 
			// button_Axis_Refresh
			// 
			this.button_Axis_Refresh.Location = new System.Drawing.Point(62, 396);
			this.button_Axis_Refresh.Name = "button_Axis_Refresh";
			this.button_Axis_Refresh.Size = new System.Drawing.Size(100, 32);
			this.button_Axis_Refresh.TabIndex = 53;
			this.button_Axis_Refresh.Text = "刷新";
			this.button_Axis_Refresh.UseVisualStyleBackColor = true;
			this.button_Axis_Refresh.Click += new System.EventHandler(this.button_Axis_Refresh_Click);
			// 
			// button_Axis_Reference
			// 
			this.button_Axis_Reference.Location = new System.Drawing.Point(176, 396);
			this.button_Axis_Reference.Name = "button_Axis_Reference";
			this.button_Axis_Reference.Size = new System.Drawing.Size(100, 32);
			this.button_Axis_Reference.TabIndex = 52;
			this.button_Axis_Reference.Text = "引用轴";
			this.button_Axis_Reference.UseVisualStyleBackColor = true;
			this.button_Axis_Reference.Click += new System.EventHandler(this.button_Axis_Reference_Click);
			// 
			// button_Axis_ImportIn
			// 
			this.button_Axis_ImportIn.Location = new System.Drawing.Point(632, 396);
			this.button_Axis_ImportIn.Name = "button_Axis_ImportIn";
			this.button_Axis_ImportIn.Size = new System.Drawing.Size(100, 32);
			this.button_Axis_ImportIn.TabIndex = 51;
			this.button_Axis_ImportIn.Text = "轴导入";
			this.button_Axis_ImportIn.UseVisualStyleBackColor = true;
			this.button_Axis_ImportIn.Click += new System.EventHandler(this.button_Axis_ImportIn_Click);
			// 
			// button_Axis_ImportOut
			// 
			this.button_Axis_ImportOut.Location = new System.Drawing.Point(518, 396);
			this.button_Axis_ImportOut.Name = "button_Axis_ImportOut";
			this.button_Axis_ImportOut.Size = new System.Drawing.Size(100, 32);
			this.button_Axis_ImportOut.TabIndex = 50;
			this.button_Axis_ImportOut.Text = "轴导出";
			this.button_Axis_ImportOut.UseVisualStyleBackColor = true;
			this.button_Axis_ImportOut.Click += new System.EventHandler(this.button_Axis_ImportOut_Click);
			// 
			// button_RemoveAxis
			// 
			this.button_RemoveAxis.Location = new System.Drawing.Point(404, 396);
			this.button_RemoveAxis.Name = "button_RemoveAxis";
			this.button_RemoveAxis.Size = new System.Drawing.Size(100, 32);
			this.button_RemoveAxis.TabIndex = 4;
			this.button_RemoveAxis.Text = "删除轴";
			this.button_RemoveAxis.UseVisualStyleBackColor = true;
			this.button_RemoveAxis.Click += new System.EventHandler(this.button_RemoveAxis_Click);
			// 
			// panel_Axis
			// 
			this.panel_Axis.AutoScroll = true;
			this.panel_Axis.BackColor = System.Drawing.SystemColors.Control;
			this.panel_Axis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Axis.Location = new System.Drawing.Point(8, 10);
			this.panel_Axis.Name = "panel_Axis";
			this.panel_Axis.Size = new System.Drawing.Size(776, 368);
			this.panel_Axis.TabIndex = 2;
			// 
			// button_AddAxis
			// 
			this.button_AddAxis.Location = new System.Drawing.Point(290, 396);
			this.button_AddAxis.Name = "button_AddAxis";
			this.button_AddAxis.Size = new System.Drawing.Size(100, 32);
			this.button_AddAxis.TabIndex = 3;
			this.button_AddAxis.Text = "添加轴";
			this.button_AddAxis.UseVisualStyleBackColor = true;
			this.button_AddAxis.Click += new System.EventHandler(this.button_AddAxis_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.button_Input_IO_ImportIn);
			this.tabPage2.Controls.Add(this.button_Input_IONoCard_ImportIn);
			this.tabPage2.Controls.Add(this.button_InputIO_ImportOut);
			this.tabPage2.Controls.Add(this.button_RemoveInputIo);
			this.tabPage2.Controls.Add(this.button_AddInputIo);
			this.tabPage2.Controls.Add(this.panel_InputIo);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(793, 442);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "输入IO";
			// 
			// button_Input_IO_ImportIn
			// 
			this.button_Input_IO_ImportIn.Location = new System.Drawing.Point(549, 393);
			this.button_Input_IO_ImportIn.Name = "button_Input_IO_ImportIn";
			this.button_Input_IO_ImportIn.Size = new System.Drawing.Size(100, 32);
			this.button_Input_IO_ImportIn.TabIndex = 50;
			this.button_Input_IO_ImportIn.Text = "IO导入(卡号）";
			this.button_Input_IO_ImportIn.UseVisualStyleBackColor = true;
			this.button_Input_IO_ImportIn.Click += new System.EventHandler(this.button_Input_IO_ImportIn_Click);
			// 
			// button_Input_IONoCard_ImportIn
			// 
			this.button_Input_IONoCard_ImportIn.Location = new System.Drawing.Point(438, 393);
			this.button_Input_IONoCard_ImportIn.Name = "button_Input_IONoCard_ImportIn";
			this.button_Input_IONoCard_ImportIn.Size = new System.Drawing.Size(100, 32);
			this.button_Input_IONoCard_ImportIn.TabIndex = 49;
			this.button_Input_IONoCard_ImportIn.Text = "IO导入(不导入卡号）";
			this.button_Input_IONoCard_ImportIn.UseVisualStyleBackColor = true;
			this.button_Input_IONoCard_ImportIn.Click += new System.EventHandler(this.button_Input_IONoCard_ImportIn_Click);
			// 
			// button_InputIO_ImportOut
			// 
			this.button_InputIO_ImportOut.Location = new System.Drawing.Point(327, 393);
			this.button_InputIO_ImportOut.Name = "button_InputIO_ImportOut";
			this.button_InputIO_ImportOut.Size = new System.Drawing.Size(100, 32);
			this.button_InputIO_ImportOut.TabIndex = 48;
			this.button_InputIO_ImportOut.Text = "IO导出";
			this.button_InputIO_ImportOut.UseVisualStyleBackColor = true;
			this.button_InputIO_ImportOut.Click += new System.EventHandler(this.button_InputIO_ImportOut_Click);
			// 
			// button_RemoveInputIo
			// 
			this.button_RemoveInputIo.Location = new System.Drawing.Point(216, 393);
			this.button_RemoveInputIo.Name = "button_RemoveInputIo";
			this.button_RemoveInputIo.Size = new System.Drawing.Size(100, 32);
			this.button_RemoveInputIo.TabIndex = 6;
			this.button_RemoveInputIo.Text = "删除";
			this.button_RemoveInputIo.UseVisualStyleBackColor = true;
			this.button_RemoveInputIo.Click += new System.EventHandler(this.button_RemoveInputIo_Click);
			// 
			// button_AddInputIo
			// 
			this.button_AddInputIo.Location = new System.Drawing.Point(105, 393);
			this.button_AddInputIo.Name = "button_AddInputIo";
			this.button_AddInputIo.Size = new System.Drawing.Size(100, 32);
			this.button_AddInputIo.TabIndex = 5;
			this.button_AddInputIo.Text = "添加";
			this.button_AddInputIo.UseVisualStyleBackColor = true;
			this.button_AddInputIo.Click += new System.EventHandler(this.button_AddInputIo_Click);
			// 
			// panel_InputIo
			// 
			this.panel_InputIo.AutoScroll = true;
			this.panel_InputIo.BackColor = System.Drawing.SystemColors.Control;
			this.panel_InputIo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_InputIo.Location = new System.Drawing.Point(8, 10);
			this.panel_InputIo.Name = "panel_InputIo";
			this.panel_InputIo.Size = new System.Drawing.Size(779, 368);
			this.panel_InputIo.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.button_Output_IO_ImportIn);
			this.tabPage3.Controls.Add(this.button_Output_IONoCard_ImportIn);
			this.tabPage3.Controls.Add(this.button_OutputIO_ImportOut);
			this.tabPage3.Controls.Add(this.button_RemoveOutputIo);
			this.tabPage3.Controls.Add(this.button_AddOutputIo);
			this.tabPage3.Controls.Add(this.panel_OutputIo);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(793, 442);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "输出IO";
			// 
			// button_RemoveOutputIo
			// 
			this.button_RemoveOutputIo.Location = new System.Drawing.Point(224, 394);
			this.button_RemoveOutputIo.Name = "button_RemoveOutputIo";
			this.button_RemoveOutputIo.Size = new System.Drawing.Size(100, 32);
			this.button_RemoveOutputIo.TabIndex = 8;
			this.button_RemoveOutputIo.Text = "删除";
			this.button_RemoveOutputIo.UseVisualStyleBackColor = true;
			this.button_RemoveOutputIo.Click += new System.EventHandler(this.button_RemoveOutputIo_Click);
			// 
			// button_AddOutputIo
			// 
			this.button_AddOutputIo.Location = new System.Drawing.Point(109, 394);
			this.button_AddOutputIo.Name = "button_AddOutputIo";
			this.button_AddOutputIo.Size = new System.Drawing.Size(100, 32);
			this.button_AddOutputIo.TabIndex = 7;
			this.button_AddOutputIo.Text = "添加";
			this.button_AddOutputIo.UseVisualStyleBackColor = true;
			this.button_AddOutputIo.Click += new System.EventHandler(this.button_AddOutputIo_Click);
			// 
			// panel_OutputIo
			// 
			this.panel_OutputIo.AutoScroll = true;
			this.panel_OutputIo.BackColor = System.Drawing.SystemColors.Control;
			this.panel_OutputIo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_OutputIo.Location = new System.Drawing.Point(8, 10);
			this.panel_OutputIo.Name = "panel_OutputIo";
			this.panel_OutputIo.Size = new System.Drawing.Size(776, 368);
			this.panel_OutputIo.TabIndex = 0;
			// 
			// PointDebugSetUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 479);
			this.Controls.Add(this.button_DelAllPoint);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.tabControl1);
			this.Name = "PointDebugSetUI";
			this.Text = "PointDebugSetUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PointDebugSetUI_FormClosing);
			this.Load += new System.EventHandler(this.PointDebugSetUI_Load);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Output_IO_ImportIn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button_OneKeySetting;
		private System.Windows.Forms.ComboBox comboBox_SetType;
		private System.Windows.Forms.Button button_PointStep_ImportIn;
		private System.Windows.Forms.Button button_PointStep_ImportOut;
		private System.Windows.Forms.Button button_SetSpeed;
		private System.Windows.Forms.NumericUpDown numSpeed;
		private System.Windows.Forms.ComboBox cboAxisName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_RefreshPoint;
		private System.Windows.Forms.Button button_AddPoint;
		private System.Windows.Forms.Panel panel_Point;
		private System.Windows.Forms.Button button_DelAllPoint;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button_Output_IONoCard_ImportIn;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Button button_OutputIO_ImportOut;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button_Axis_Refresh;
		private System.Windows.Forms.Button button_Axis_Reference;
		private System.Windows.Forms.Button button_Axis_ImportIn;
		private System.Windows.Forms.Button button_Axis_ImportOut;
		private System.Windows.Forms.Button button_RemoveAxis;
		private System.Windows.Forms.Panel panel_Axis;
		private System.Windows.Forms.Button button_AddAxis;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button_Input_IO_ImportIn;
		private System.Windows.Forms.Button button_Input_IONoCard_ImportIn;
		private System.Windows.Forms.Button button_InputIO_ImportOut;
		private System.Windows.Forms.Button button_RemoveInputIo;
		private System.Windows.Forms.Button button_AddInputIo;
		private System.Windows.Forms.Panel panel_InputIo;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button_RemoveOutputIo;
		private System.Windows.Forms.Button button_AddOutputIo;
		private System.Windows.Forms.Panel panel_OutputIo;
	}
}