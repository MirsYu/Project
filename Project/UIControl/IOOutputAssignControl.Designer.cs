namespace Project
{
	partial class IOOutputAssignControl
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
			this.comboBox_Station2 = new System.Windows.Forms.ComboBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox_Station = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox_Station2
			// 
			this.comboBox_Station2.FormattingEnabled = true;
			this.comboBox_Station2.Location = new System.Drawing.Point(375, 11);
			this.comboBox_Station2.Name = "comboBox_Station2";
			this.comboBox_Station2.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Station2.TabIndex = 25;
			this.comboBox_Station2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Station2_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 19;
			this.listBox2.Location = new System.Drawing.Point(375, 51);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(303, 289);
			this.listBox2.TabIndex = 24;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 19;
			this.listBox1.Location = new System.Drawing.Point(13, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(303, 289);
			this.listBox1.TabIndex = 23;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "移除";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button_Del_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(322, 141);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "->";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// comboBox_Station
			// 
			this.comboBox_Station.FormattingEnabled = true;
			this.comboBox_Station.Location = new System.Drawing.Point(13, 11);
			this.comboBox_Station.Name = "comboBox_Station";
			this.comboBox_Station.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Station.TabIndex = 20;
			this.comboBox_Station.SelectedIndexChanged += new System.EventHandler(this.comboBox_Station_SelectedIndexChanged);
			// 
			// IOOutputAssignControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboBox_Station2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox_Station);
			this.Name = "IOOutputAssignControl";
			this.Size = new System.Drawing.Size(694, 355);
			this.Load += new System.EventHandler(this.IOOutputAssignControl_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_Station2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox_Station;
	}
}
