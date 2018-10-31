namespace Project
{
	partial class MessageBoxShowUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxShowUI));
			this.button_NO = new System.Windows.Forms.Button();
			this.button_Yes = new System.Windows.Forms.Button();
			this.label_Content = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_NO
			// 
			this.button_NO.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold);
			this.button_NO.Location = new System.Drawing.Point(442, 238);
			this.button_NO.Name = "button_NO";
			this.button_NO.Size = new System.Drawing.Size(128, 59);
			this.button_NO.TabIndex = 5;
			this.button_NO.Text = "否";
			this.button_NO.UseVisualStyleBackColor = true;
			this.button_NO.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// button_Yes
			// 
			this.button_Yes.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Yes.Location = new System.Drawing.Point(196, 238);
			this.button_Yes.Name = "button_Yes";
			this.button_Yes.Size = new System.Drawing.Size(128, 59);
			this.button_Yes.TabIndex = 4;
			this.button_Yes.Text = "是";
			this.button_Yes.UseVisualStyleBackColor = true;
			this.button_Yes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// label_Content
			// 
			this.label_Content.AutoSize = true;
			this.label_Content.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label_Content.Location = new System.Drawing.Point(206, 76);
			this.label_Content.Name = "label_Content";
			this.label_Content.Size = new System.Drawing.Size(347, 111);
			this.label_Content.TabIndex = 6;
			this.label_Content.Text = "此处为信息显示的位置\r\n此处为信息显示的位置\r\n此处为信息显示的位置\r\n";
			// 
			// MessageBoxShowUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(756, 335);
			this.Controls.Add(this.label_Content);
			this.Controls.Add(this.button_NO);
			this.Controls.Add(this.button_Yes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MessageBoxShowUI";
			this.Text = "MessageBoxShowUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageBoxShowUI_FormClosing);
			this.Load += new System.EventHandler(this.MessageBoxShowUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_NO;
		private System.Windows.Forms.Button button_Yes;
		private System.Windows.Forms.Label label_Content;
	}
}