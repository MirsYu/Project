namespace Project
{
	partial class PointSetControl
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
			this.button_PointDetailed = new System.Windows.Forms.Button();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button_PointDetailed
			// 
			this.button_PointDetailed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_PointDetailed.Location = new System.Drawing.Point(3, 2);
			this.button_PointDetailed.Name = "button_PointDetailed";
			this.button_PointDetailed.Size = new System.Drawing.Size(61, 23);
			this.button_PointDetailed.TabIndex = 127;
			this.button_PointDetailed.Text = "详细配置";
			this.button_PointDetailed.UseVisualStyleBackColor = true;
			this.button_PointDetailed.Click += new System.EventHandler(this.button_PointDetailed_Click);
			// 
			// textBox_Name
			// 
			this.textBox_Name.Location = new System.Drawing.Point(71, 3);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(117, 21);
			this.textBox_Name.TabIndex = 126;
			// 
			// PointSetControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button_PointDetailed);
			this.Controls.Add(this.textBox_Name);
			this.Name = "PointSetControl";
			this.Size = new System.Drawing.Size(1487, 26);
			this.Load += new System.EventHandler(this.PointSetControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_PointDetailed;
		private System.Windows.Forms.TextBox textBox_Name;
	}
}
