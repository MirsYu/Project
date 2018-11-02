namespace Project
{
	partial class MessageBoxHintUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxHintUI));
			this.button_No = new System.Windows.Forms.Button();
			this.button_Confirm = new System.Windows.Forms.Button();
			this.button_Yes = new System.Windows.Forms.Button();
			this.label_Content = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_No
			// 
			this.button_No.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold);
			this.button_No.Location = new System.Drawing.Point(654, 215);
			this.button_No.Name = "button_No";
			this.button_No.Size = new System.Drawing.Size(128, 59);
			this.button_No.TabIndex = 6;
			this.button_No.Text = "否";
			this.button_No.UseVisualStyleBackColor = true;
			// 
			// button_Confirm
			// 
			this.button_Confirm.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold);
			this.button_Confirm.Location = new System.Drawing.Point(348, 215);
			this.button_Confirm.Name = "button_Confirm";
			this.button_Confirm.Size = new System.Drawing.Size(128, 59);
			this.button_Confirm.TabIndex = 5;
			this.button_Confirm.Text = "确定";
			this.button_Confirm.UseVisualStyleBackColor = true;
			this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
			// 
			// button_Yes
			// 
			this.button_Yes.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Yes.Location = new System.Drawing.Point(28, 215);
			this.button_Yes.Name = "button_Yes";
			this.button_Yes.Size = new System.Drawing.Size(128, 59);
			this.button_Yes.TabIndex = 4;
			this.button_Yes.Text = "是";
			this.button_Yes.UseVisualStyleBackColor = true;
			// 
			// label_Content
			// 
			this.label_Content.AutoSize = true;
			this.label_Content.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label_Content.Location = new System.Drawing.Point(193, 65);
			this.label_Content.Name = "label_Content";
			this.label_Content.Size = new System.Drawing.Size(413, 111);
			this.label_Content.TabIndex = 7;
			this.label_Content.Text = "此处为提示信息显示的位置\r\n此处为提示信息显示的位置\r\n此处为提示信息显示的位置\r\n";
			// 
			// MessageBoxHintUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(800, 303);
			this.Controls.Add(this.label_Content);
			this.Controls.Add(this.button_No);
			this.Controls.Add(this.button_Confirm);
			this.Controls.Add(this.button_Yes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MessageBoxHintUI";
			this.Text = "MessageBoxHintUI";
			this.Load += new System.EventHandler(this.MessageBoxHintUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_No;
		private System.Windows.Forms.Button button_Confirm;
		private System.Windows.Forms.Button button_Yes;
		private System.Windows.Forms.Label label_Content;
	}
}