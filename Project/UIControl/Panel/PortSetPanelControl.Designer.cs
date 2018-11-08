namespace Project
{
	partial class PortSetPanelControl
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
			this.groupBox_PortMain = new System.Windows.Forms.GroupBox();
			this.contextMenuStrip_PortMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_PortMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_PortMain
			// 
			this.groupBox_PortMain.ContextMenuStrip = this.contextMenuStrip_PortMain;
			this.groupBox_PortMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_PortMain.Location = new System.Drawing.Point(0, 0);
			this.groupBox_PortMain.Name = "groupBox_PortMain";
			this.groupBox_PortMain.Size = new System.Drawing.Size(678, 447);
			this.groupBox_PortMain.TabIndex = 0;
			this.groupBox_PortMain.TabStop = false;
			// 
			// contextMenuStrip_PortMain
			// 
			this.contextMenuStrip_PortMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Del,
            this.MenuItem_Add,
            this.MenuItem_Save});
			this.contextMenuStrip_PortMain.Name = "contextMenuStrip1";
			this.contextMenuStrip_PortMain.Size = new System.Drawing.Size(125, 70);
			// 
			// MenuItem_Del
			// 
			this.MenuItem_Del.Name = "MenuItem_Del";
			this.MenuItem_Del.Size = new System.Drawing.Size(124, 22);
			this.MenuItem_Del.Text = "删除一个";
			this.MenuItem_Del.Click += new System.EventHandler(this.MenuItem_Del_Click);
			// 
			// MenuItem_Add
			// 
			this.MenuItem_Add.Name = "MenuItem_Add";
			this.MenuItem_Add.Size = new System.Drawing.Size(124, 22);
			this.MenuItem_Add.Text = "添加一个";
			this.MenuItem_Add.Click += new System.EventHandler(this.MenuItem_Add_Click);
			// 
			// MenuItem_Save
			// 
			this.MenuItem_Save.Name = "MenuItem_Save";
			this.MenuItem_Save.Size = new System.Drawing.Size(124, 22);
			this.MenuItem_Save.Text = "保存";
			this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
			// 
			// PortSetPanelControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox_PortMain);
			this.Name = "PortSetPanelControl";
			this.Size = new System.Drawing.Size(678, 447);
			this.Load += new System.EventHandler(this.PortSetPanelControl_Load);
			this.SizeChanged += new System.EventHandler(this.PortSetPanelControl_SizeChanged);
			this.contextMenuStrip_PortMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_PortMain;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_PortMain;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Del;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
	}
}
