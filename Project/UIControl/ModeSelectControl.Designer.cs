﻿namespace Project
{
	partial class ModeSelectControl
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
			this.checkBox_SnEm = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox_PDCA = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// checkBox_SnEm
			// 
			this.checkBox_SnEm.AutoSize = true;
			this.checkBox_SnEm.Location = new System.Drawing.Point(58, 3);
			this.checkBox_SnEm.Name = "checkBox_SnEm";
			this.checkBox_SnEm.Size = new System.Drawing.Size(84, 16);
			this.checkBox_SnEm.TabIndex = 3;
			this.checkBox_SnEm.Text = "SN可以为空";
			this.checkBox_SnEm.UseVisualStyleBackColor = true;
			// 
			// checkBox_PDCA
			// 
			this.checkBox_PDCA.AutoSize = true;
			this.checkBox_PDCA.Location = new System.Drawing.Point(4, 3);
			this.checkBox_PDCA.Name = "checkBox_PDCA";
			this.checkBox_PDCA.Size = new System.Drawing.Size(48, 16);
			this.checkBox_PDCA.TabIndex = 2;
			this.checkBox_PDCA.Text = "PDCA";
			this.checkBox_PDCA.UseVisualStyleBackColor = true;
			// 
			// ModeSelectControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox_SnEm);
			this.Controls.Add(this.checkBox_PDCA);
			this.Name = "ModeSelectControl";
			this.Size = new System.Drawing.Size(142, 22);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckBox checkBox_SnEm;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.CheckBox checkBox_PDCA;
	}
}
