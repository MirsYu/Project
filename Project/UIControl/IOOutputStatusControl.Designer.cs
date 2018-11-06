namespace Project
{
	partial class IOOutputStatusControl
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
			this.button_Safety = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.OutputBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_Safety
			// 
			this.button_Safety.Location = new System.Drawing.Point(55, 3);
			this.button_Safety.Name = "button_Safety";
			this.button_Safety.Size = new System.Drawing.Size(64, 28);
			this.button_Safety.TabIndex = 5;
			this.button_Safety.Text = "防呆配置";
			this.button_Safety.UseVisualStyleBackColor = true;
			this.button_Safety.Click += new System.EventHandler(this.button_Safety_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(125, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "outname";
			// 
			// OutputBT
			// 
			this.OutputBT.Location = new System.Drawing.Point(7, 2);
			this.OutputBT.Name = "OutputBT";
			this.OutputBT.Size = new System.Drawing.Size(42, 30);
			this.OutputBT.TabIndex = 3;
			this.OutputBT.Text = "OFF";
			this.OutputBT.UseVisualStyleBackColor = true;
			this.OutputBT.Click += new System.EventHandler(this.OutputBT_Click);
			// 
			// IOOutputStatusControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button_Safety);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OutputBT);
			this.Name = "IOOutputStatusControl";
			this.Size = new System.Drawing.Size(218, 35);
			this.Load += new System.EventHandler(this.IOOutputStatusControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Safety;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OutputBT;
	}
}
