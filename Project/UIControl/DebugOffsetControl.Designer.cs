namespace Project
{
	partial class DebugOffsetControl
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
			this.textBox_OffsetTest = new System.Windows.Forms.TextBox();
			this.button_Save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_OffsetTest
			// 
			this.textBox_OffsetTest.Location = new System.Drawing.Point(610, 387);
			this.textBox_OffsetTest.Name = "textBox_OffsetTest";
			this.textBox_OffsetTest.Size = new System.Drawing.Size(100, 21);
			this.textBox_OffsetTest.TabIndex = 1;
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(625, 425);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 2;
			this.button_Save.Text = "保存";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button1_Save_Click);
			// 
			// DebugOffsetControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.textBox_OffsetTest);
			this.Name = "DebugOffsetControl";
			this.Size = new System.Drawing.Size(713, 451);
			this.Load += new System.EventHandler(this.DebugOffsetControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_OffsetTest;
		private System.Windows.Forms.Button button_Save;
	}
}
