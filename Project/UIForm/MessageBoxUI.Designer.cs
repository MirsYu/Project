namespace Project
{
	partial class MessageBoxUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxUI));
			this.label_Content = new System.Windows.Forms.Label();
			this.button_Abort = new System.Windows.Forms.Button();
			this.button_Retry = new System.Windows.Forms.Button();
			this.button_Ignore = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Content
			// 
			this.label_Content.AutoSize = true;
			this.label_Content.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label_Content.Location = new System.Drawing.Point(278, 116);
			this.label_Content.Name = "label_Content";
			this.label_Content.Size = new System.Drawing.Size(413, 111);
			this.label_Content.TabIndex = 0;
			this.label_Content.Text = "此处为错误信息显示的位置\r\n此处为错误信息显示的位置\r\n此处为错误信息显示的位置\r\n";
			// 
			// button_Abort
			// 
			this.button_Abort.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Abort.Location = new System.Drawing.Point(98, 327);
			this.button_Abort.Name = "button_Abort";
			this.button_Abort.Size = new System.Drawing.Size(128, 59);
			this.button_Abort.TabIndex = 1;
			this.button_Abort.Text = "中止";
			this.button_Abort.UseVisualStyleBackColor = true;
			this.button_Abort.Click += new System.EventHandler(this.AbortEventHandler);
			// 
			// button_Retry
			// 
			this.button_Retry.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold);
			this.button_Retry.Location = new System.Drawing.Point(418, 327);
			this.button_Retry.Name = "button_Retry";
			this.button_Retry.Size = new System.Drawing.Size(128, 59);
			this.button_Retry.TabIndex = 2;
			this.button_Retry.Text = "重试";
			this.button_Retry.UseVisualStyleBackColor = true;
			this.button_Retry.Click += new System.EventHandler(this.AbortEventHandler);
			// 
			// button_Ignore
			// 
			this.button_Ignore.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold);
			this.button_Ignore.Location = new System.Drawing.Point(724, 327);
			this.button_Ignore.Name = "button_Ignore";
			this.button_Ignore.Size = new System.Drawing.Size(128, 59);
			this.button_Ignore.TabIndex = 3;
			this.button_Ignore.Text = "忽略";
			this.button_Ignore.UseVisualStyleBackColor = true;
			this.button_Ignore.Click += new System.EventHandler(this.AbortEventHandler);
			// 
			// MessageBoxUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(976, 422);
			this.Controls.Add(this.button_Ignore);
			this.Controls.Add(this.button_Retry);
			this.Controls.Add(this.button_Abort);
			this.Controls.Add(this.label_Content);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MessageBoxUI";
			this.Text = "MessageBoxUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_Content;
		private System.Windows.Forms.Button button_Abort;
		private System.Windows.Forms.Button button_Retry;
		private System.Windows.Forms.Button button_Ignore;
	}
}