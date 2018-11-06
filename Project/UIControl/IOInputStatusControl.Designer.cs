namespace Project
{
	partial class IOInputStatusControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOInputStatusControl));
			this.lblinputLight = new System.Windows.Forms.Label();
			this.lblInputname = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblinputLight
			// 
			this.lblinputLight.Image = ((System.Drawing.Image)(resources.GetObject("lblinputLight.Image")));
			this.lblinputLight.Location = new System.Drawing.Point(0, 1);
			this.lblinputLight.Name = "lblinputLight";
			this.lblinputLight.Size = new System.Drawing.Size(20, 20);
			this.lblinputLight.TabIndex = 5;
			// 
			// lblInputname
			// 
			this.lblInputname.AutoSize = true;
			this.lblInputname.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblInputname.Location = new System.Drawing.Point(26, 5);
			this.lblInputname.Name = "lblInputname";
			this.lblInputname.Size = new System.Drawing.Size(59, 12);
			this.lblInputname.TabIndex = 4;
			this.lblInputname.Text = "Inputname";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 12);
			this.label1.TabIndex = 3;
			// 
			// IOInputStatusControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblinputLight);
			this.Controls.Add(this.lblInputname);
			this.Controls.Add(this.label1);
			this.Name = "IOInputStatusControl";
			this.Size = new System.Drawing.Size(88, 23);
			this.Load += new System.EventHandler(this.IOInputStatusControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblinputLight;
		private System.Windows.Forms.Label lblInputname;
		private System.Windows.Forms.Label label1;
	}
}
