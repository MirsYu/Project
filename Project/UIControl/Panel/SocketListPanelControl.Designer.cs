namespace Project
{
	partial class SocketListPanelControl
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip_SockPanelMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_SockPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip_SockPanelMain
			// 
			this.contextMenuStrip_SockPanelMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Del,
            this.MenuItem_Add,
            this.MenuItem_Save});
			this.contextMenuStrip_SockPanelMain.Name = "contextMenuStrip1";
			this.contextMenuStrip_SockPanelMain.Size = new System.Drawing.Size(181, 92);
			// 
			// MenuItem_Del
			// 
			this.MenuItem_Del.Name = "MenuItem_Del";
			this.MenuItem_Del.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_Del.Text = "删除";
			// 
			// MenuItem_Add
			// 
			this.MenuItem_Add.Name = "MenuItem_Add";
			this.MenuItem_Add.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_Add.Text = "添加";
			// 
			// MenuItem_Save
			// 
			this.MenuItem_Save.Name = "MenuItem_Save";
			this.MenuItem_Save.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_Save.Text = "保存";
			// 
			// SocketListPanelControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "SocketListPanelControl";
			this.contextMenuStrip_SockPanelMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_SockPanelMain;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Del;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
	}
}
