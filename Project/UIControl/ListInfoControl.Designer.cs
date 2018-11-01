namespace Project
{
	partial class ListInfoControl
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
			this.listBoxInfon = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBoxInfon
			// 
			this.listBoxInfon.AllowDrop = true;
			this.listBoxInfon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBoxInfon.FormattingEnabled = true;
			this.listBoxInfon.HorizontalScrollbar = true;
			this.listBoxInfon.ItemHeight = 20;
			this.listBoxInfon.Location = new System.Drawing.Point(3, 3);
			this.listBoxInfon.Name = "listBoxInfon";
			this.listBoxInfon.Size = new System.Drawing.Size(391, 244);
			this.listBoxInfon.TabIndex = 1;
			// 
			// ListInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listBoxInfon);
			this.Name = "ListInfoControl";
			this.Size = new System.Drawing.Size(397, 250);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxInfon;
	}
}
