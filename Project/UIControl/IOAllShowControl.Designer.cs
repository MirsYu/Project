namespace Project
{
	partial class IOAllShowControl
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel_IO = new System.Windows.Forms.Panel();
			this.panel_out = new System.Windows.Forms.Panel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.button_InputSelect = new System.Windows.Forms.Button();
			this.button_OutputSelect = new System.Windows.Forms.Button();
			this.button_IOSet = new System.Windows.Forms.Button();
			this.comboBox_Stat = new System.Windows.Forms.ComboBox();
			this.button_Save = new System.Windows.Forms.Button();
			this.comboBox_Motiontype = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(13, 34);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(977, 500);
			this.tabControl1.TabIndex = 23;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel_IO);
			this.tabPage1.Controls.Add(this.panel_out);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(969, 474);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "IO控制";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel_IO
			// 
			this.panel_IO.AutoScroll = true;
			this.panel_IO.Location = new System.Drawing.Point(7, 7);
			this.panel_IO.Name = "panel_IO";
			this.panel_IO.Size = new System.Drawing.Size(653, 450);
			this.panel_IO.TabIndex = 0;
			// 
			// panel_out
			// 
			this.panel_out.AutoScroll = true;
			this.panel_out.Location = new System.Drawing.Point(666, 7);
			this.panel_out.Name = "panel_out";
			this.panel_out.Size = new System.Drawing.Size(280, 450);
			this.panel_out.TabIndex = 5;
			this.panel_out.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_out_Paint);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(969, 474);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "IO设置";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(969, 474);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "输入io分配";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(969, 474);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "输出IO分配";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 21;
			this.label1.Text = "卡号";
			// 
			// button_InputSelect
			// 
			this.button_InputSelect.Location = new System.Drawing.Point(147, 7);
			this.button_InputSelect.Name = "button_InputSelect";
			this.button_InputSelect.Size = new System.Drawing.Size(75, 23);
			this.button_InputSelect.TabIndex = 20;
			this.button_InputSelect.Text = "IN查询";
			this.button_InputSelect.UseVisualStyleBackColor = true;
			this.button_InputSelect.Click += new System.EventHandler(this.button_InputSelect_Click);
			// 
			// button_OutputSelect
			// 
			this.button_OutputSelect.Location = new System.Drawing.Point(228, 7);
			this.button_OutputSelect.Name = "button_OutputSelect";
			this.button_OutputSelect.Size = new System.Drawing.Size(75, 23);
			this.button_OutputSelect.TabIndex = 22;
			this.button_OutputSelect.Text = "Out查询";
			this.button_OutputSelect.UseVisualStyleBackColor = true;
			this.button_OutputSelect.Click += new System.EventHandler(this.button_OutputSelect_Click);
			// 
			// button_IOSet
			// 
			this.button_IOSet.Location = new System.Drawing.Point(562, 6);
			this.button_IOSet.Name = "button_IOSet";
			this.button_IOSet.Size = new System.Drawing.Size(75, 23);
			this.button_IOSet.TabIndex = 27;
			this.button_IOSet.Text = "IOSet";
			this.button_IOSet.UseVisualStyleBackColor = true;
			this.button_IOSet.Click += new System.EventHandler(this.button_IOSet_Click);
			// 
			// comboBox_Stat
			// 
			this.comboBox_Stat.FormattingEnabled = true;
			this.comboBox_Stat.Location = new System.Drawing.Point(404, 7);
			this.comboBox_Stat.Name = "comboBox_Stat";
			this.comboBox_Stat.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Stat.TabIndex = 26;
			this.comboBox_Stat.SelectedIndexChanged += new System.EventHandler(this.comboBox_Stat_SelectedIndexChanged);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(309, 6);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 25;
			this.button_Save.Text = "保存";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// comboBox_Motiontype
			// 
			this.comboBox_Motiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Motiontype.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboBox_Motiontype.FormattingEnabled = true;
			this.comboBox_Motiontype.Items.AddRange(new object[] {
            "无",
            "1卡",
            "2卡",
            "3卡",
            "扩1",
            "扩2",
            "扩3",
            "扩4",
            "扩5",
            "扩6",
            "扩7",
            "扩8",
            "扩9",
            "扩10"});
			this.comboBox_Motiontype.Location = new System.Drawing.Point(95, 7);
			this.comboBox_Motiontype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBox_Motiontype.Name = "comboBox_Motiontype";
			this.comboBox_Motiontype.Size = new System.Drawing.Size(46, 20);
			this.comboBox_Motiontype.TabIndex = 24;
			// 
			// IOAllShowControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_InputSelect);
			this.Controls.Add(this.button_OutputSelect);
			this.Controls.Add(this.button_IOSet);
			this.Controls.Add(this.comboBox_Stat);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.comboBox_Motiontype);
			this.Name = "IOAllShowControl";
			this.Size = new System.Drawing.Size(1003, 543);
			this.Load += new System.EventHandler(this.IoAllShow_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel panel_IO;
		private System.Windows.Forms.Panel panel_out;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_InputSelect;
		private System.Windows.Forms.Button button_OutputSelect;
		private System.Windows.Forms.Button button_IOSet;
		private System.Windows.Forms.ComboBox comboBox_Stat;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.ComboBox comboBox_Motiontype;
	}
}
