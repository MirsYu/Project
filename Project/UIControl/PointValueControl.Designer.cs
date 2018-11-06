namespace Project
{
	partial class PointValueControl
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox_Line = new System.Windows.Forms.ComboBox();
			this.textBox_Sleep = new System.Windows.Forms.TextBox();
			this.label_Step = new System.Windows.Forms.Label();
			this.button_axisSafe = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox_delectAdd = new System.Windows.Forms.ComboBox();
			this.checkBox_AxisStop = new System.Windows.Forms.CheckBox();
			this.checkBox_Enable = new System.Windows.Forms.CheckBox();
			this.checkBox_AxisRest = new System.Windows.Forms.CheckBox();
			this.checkBox_wait = new System.Windows.Forms.CheckBox();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.butIoSet = new System.Windows.Forms.Button();
			this.button_save = new System.Windows.Forms.Button();
			this.button_Exe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox_Line
			// 
			this.comboBox_Line.FormattingEnabled = true;
			this.comboBox_Line.Items.AddRange(new object[] {
            "单轴运动",
            "直线插补"});
			this.comboBox_Line.Location = new System.Drawing.Point(877, 4);
			this.comboBox_Line.Name = "comboBox_Line";
			this.comboBox_Line.Size = new System.Drawing.Size(70, 20);
			this.comboBox_Line.TabIndex = 30;
			this.comboBox_Line.Text = "轴运动";
			// 
			// textBox_Sleep
			// 
			this.textBox_Sleep.Location = new System.Drawing.Point(1052, 4);
			this.textBox_Sleep.Name = "textBox_Sleep";
			this.textBox_Sleep.Size = new System.Drawing.Size(53, 21);
			this.textBox_Sleep.TabIndex = 29;
			this.textBox_Sleep.Text = "0";
			// 
			// label_Step
			// 
			this.label_Step.AutoSize = true;
			this.label_Step.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Step.Location = new System.Drawing.Point(3, 8);
			this.label_Step.Name = "label_Step";
			this.label_Step.Size = new System.Drawing.Size(12, 12);
			this.label_Step.TabIndex = 28;
			this.label_Step.Text = "0";
			// 
			// button_axisSafe
			// 
			this.button_axisSafe.Location = new System.Drawing.Point(962, 3);
			this.button_axisSafe.Name = "button_axisSafe";
			this.button_axisSafe.Size = new System.Drawing.Size(75, 23);
			this.button_axisSafe.TabIndex = 27;
			this.button_axisSafe.Text = "轴防呆";
			this.button_axisSafe.UseVisualStyleBackColor = true;
			this.button_axisSafe.Click += new System.EventHandler(this.button_axisSafe_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "绝对运动",
            "相对运动"});
			this.comboBox2.Location = new System.Drawing.Point(792, 4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(70, 20);
			this.comboBox2.TabIndex = 26;
			this.comboBox2.Text = "绝对运动";
			// 
			// comboBox_delectAdd
			// 
			this.comboBox_delectAdd.FormattingEnabled = true;
			this.comboBox_delectAdd.Items.AddRange(new object[] {
            "插入",
            "删除"});
			this.comboBox_delectAdd.Location = new System.Drawing.Point(729, 4);
			this.comboBox_delectAdd.Name = "comboBox_delectAdd";
			this.comboBox_delectAdd.Size = new System.Drawing.Size(48, 20);
			this.comboBox_delectAdd.TabIndex = 25;
			this.comboBox_delectAdd.Text = "插入";
			this.comboBox_delectAdd.SelectedIndexChanged += new System.EventHandler(this.comboBox_delectAdd_SelectedIndexChanged);
			// 
			// checkBox_AxisStop
			// 
			this.checkBox_AxisStop.AutoSize = true;
			this.checkBox_AxisStop.Location = new System.Drawing.Point(654, 6);
			this.checkBox_AxisStop.Name = "checkBox_AxisStop";
			this.checkBox_AxisStop.Size = new System.Drawing.Size(60, 16);
			this.checkBox_AxisStop.TabIndex = 24;
			this.checkBox_AxisStop.Text = "轴停止";
			this.checkBox_AxisStop.UseVisualStyleBackColor = true;
			// 
			// checkBox_Enable
			// 
			this.checkBox_Enable.AutoSize = true;
			this.checkBox_Enable.Location = new System.Drawing.Point(567, 6);
			this.checkBox_Enable.Name = "checkBox_Enable";
			this.checkBox_Enable.Size = new System.Drawing.Size(72, 16);
			this.checkBox_Enable.TabIndex = 23;
			this.checkBox_Enable.Text = "屏蔽本点";
			this.checkBox_Enable.UseVisualStyleBackColor = true;
			// 
			// checkBox_AxisRest
			// 
			this.checkBox_AxisRest.AutoSize = true;
			this.checkBox_AxisRest.Location = new System.Drawing.Point(492, 6);
			this.checkBox_AxisRest.Name = "checkBox_AxisRest";
			this.checkBox_AxisRest.Size = new System.Drawing.Size(60, 16);
			this.checkBox_AxisRest.TabIndex = 22;
			this.checkBox_AxisRest.Text = "轴回原";
			this.checkBox_AxisRest.UseVisualStyleBackColor = true;
			// 
			// checkBox_wait
			// 
			this.checkBox_wait.AutoSize = true;
			this.checkBox_wait.Location = new System.Drawing.Point(381, 6);
			this.checkBox_wait.Name = "checkBox_wait";
			this.checkBox_wait.Size = new System.Drawing.Size(96, 16);
			this.checkBox_wait.TabIndex = 21;
			this.checkBox_wait.Text = "轴运动不等待";
			this.checkBox_wait.UseVisualStyleBackColor = true;
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(30, 4);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(152, 21);
			this.textBox_name.TabIndex = 20;
			this.textBox_name.Enter += new System.EventHandler(this.textBox_name_Enter);
			this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
			// 
			// butIoSet
			// 
			this.butIoSet.Location = new System.Drawing.Point(251, 3);
			this.butIoSet.Margin = new System.Windows.Forms.Padding(2);
			this.butIoSet.Name = "butIoSet";
			this.butIoSet.Size = new System.Drawing.Size(54, 23);
			this.butIoSet.TabIndex = 19;
			this.butIoSet.Text = "配置IO";
			this.butIoSet.UseVisualStyleBackColor = true;
			this.butIoSet.Click += new System.EventHandler(this.butIoSet_Click);
			// 
			// button_save
			// 
			this.button_save.Location = new System.Drawing.Point(320, 3);
			this.button_save.Margin = new System.Windows.Forms.Padding(2);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(46, 23);
			this.button_save.TabIndex = 18;
			this.button_save.Text = "保存";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_Exe
			// 
			this.button_Exe.Location = new System.Drawing.Point(197, 3);
			this.button_Exe.Margin = new System.Windows.Forms.Padding(2);
			this.button_Exe.Name = "button_Exe";
			this.button_Exe.Size = new System.Drawing.Size(39, 23);
			this.button_Exe.TabIndex = 17;
			this.button_Exe.Text = "运动";
			this.button_Exe.UseVisualStyleBackColor = true;
			this.button_Exe.Click += new System.EventHandler(this.button_Exe_Click);
			this.button_Exe.Enter += new System.EventHandler(this.button_Exe_Enter);
			this.button_Exe.Leave += new System.EventHandler(this.button_Exe_Leave);
			// 
			// PointValueControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.comboBox_Line);
			this.Controls.Add(this.textBox_Sleep);
			this.Controls.Add(this.label_Step);
			this.Controls.Add(this.button_axisSafe);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox_delectAdd);
			this.Controls.Add(this.checkBox_AxisStop);
			this.Controls.Add(this.checkBox_Enable);
			this.Controls.Add(this.checkBox_AxisRest);
			this.Controls.Add(this.checkBox_wait);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.butIoSet);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.button_Exe);
			this.Name = "PointValueControl";
			this.Size = new System.Drawing.Size(1513, 27);
			this.Load += new System.EventHandler(this.PointValueControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_Line;
		private System.Windows.Forms.TextBox textBox_Sleep;
		private System.Windows.Forms.Label label_Step;
		private System.Windows.Forms.Button button_axisSafe;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox_delectAdd;
		private System.Windows.Forms.CheckBox checkBox_AxisStop;
		private System.Windows.Forms.CheckBox checkBox_Enable;
		private System.Windows.Forms.CheckBox checkBox_AxisRest;
		private System.Windows.Forms.CheckBox checkBox_wait;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Button butIoSet;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_Exe;
	}
}
