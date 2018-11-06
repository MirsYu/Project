namespace Project
{
	partial class PointAllShowControl
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
			this.CBpointMessage = new System.Windows.Forms.GroupBox();
			this.plpointMessage = new System.Windows.Forms.Panel();
			this.contextMenuStrip_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.CBpointMessage.SuspendLayout();
			this.contextMenuStrip_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// CBpointMessage
			// 
			this.CBpointMessage.Controls.Add(this.plpointMessage);
			this.CBpointMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CBpointMessage.Location = new System.Drawing.Point(3, 3);
			this.CBpointMessage.Name = "CBpointMessage";
			this.CBpointMessage.Size = new System.Drawing.Size(565, 376);
			this.CBpointMessage.TabIndex = 45;
			this.CBpointMessage.TabStop = false;
			this.CBpointMessage.Text = "点位信息栏";
			// 
			// plpointMessage
			// 
			this.plpointMessage.AutoScroll = true;
			this.plpointMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.plpointMessage.ContextMenuStrip = this.contextMenuStrip_Main;
			this.plpointMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plpointMessage.Location = new System.Drawing.Point(3, 17);
			this.plpointMessage.Name = "plpointMessage";
			this.plpointMessage.Size = new System.Drawing.Size(559, 356);
			this.plpointMessage.TabIndex = 38;
			// 
			// contextMenuStrip_Main
			// 
			this.contextMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Save});
			this.contextMenuStrip_Main.Name = "contextMenuStrip1";
			this.contextMenuStrip_Main.Size = new System.Drawing.Size(181, 48);
			// 
			// MenuItem_Save
			// 
			this.MenuItem_Save.Name = "MenuItem_Save";
			this.MenuItem_Save.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_Save.Text = "保存所有";
			this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
			// 
			// PointAllShowControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CBpointMessage);
			this.Name = "PointAllShowControl";
			this.Size = new System.Drawing.Size(571, 383);
			this.Load += new System.EventHandler(this.PointAllShowControl_Load);
			this.SizeChanged += new System.EventHandler(this.PointAllShowControl_SizeChanged);
			this.CBpointMessage.ResumeLayout(false);
			this.contextMenuStrip_Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox CBpointMessage;
		private System.Windows.Forms.Panel plpointMessage;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Main;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
	}
}
