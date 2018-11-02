namespace Project
{
	partial class AxisSetUI
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
			this.button_Save = new System.Windows.Forms.Button();
			this.button_RemoveAxis = new System.Windows.Forms.Button();
			this.button_AddAxis = new System.Windows.Forms.Button();
			this.Panel_SetAxis = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(83, 390);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(82, 38);
			this.button_Save.TabIndex = 64;
			this.button_Save.Text = "保存";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// button_RemoveAxis
			// 
			this.button_RemoveAxis.Location = new System.Drawing.Point(307, 390);
			this.button_RemoveAxis.Name = "button_RemoveAxis";
			this.button_RemoveAxis.Size = new System.Drawing.Size(82, 38);
			this.button_RemoveAxis.TabIndex = 61;
			this.button_RemoveAxis.Text = "删除轴";
			this.button_RemoveAxis.UseVisualStyleBackColor = true;
			this.button_RemoveAxis.Click += new System.EventHandler(this.button_RemoveAxis_Click);
			// 
			// button_AddAxis
			// 
			this.button_AddAxis.Location = new System.Drawing.Point(195, 390);
			this.button_AddAxis.Name = "button_AddAxis";
			this.button_AddAxis.Size = new System.Drawing.Size(82, 38);
			this.button_AddAxis.TabIndex = 60;
			this.button_AddAxis.Text = "添加轴";
			this.button_AddAxis.UseVisualStyleBackColor = true;
			this.button_AddAxis.Click += new System.EventHandler(this.button_AddAxis_Click);
			// 
			// Panel_SetAxis
			// 
			this.Panel_SetAxis.AutoScroll = true;
			this.Panel_SetAxis.BackColor = System.Drawing.SystemColors.Control;
			this.Panel_SetAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel_SetAxis.Location = new System.Drawing.Point(3, 3);
			this.Panel_SetAxis.Name = "Panel_SetAxis";
			this.Panel_SetAxis.Size = new System.Drawing.Size(776, 368);
			this.Panel_SetAxis.TabIndex = 59;
			// 
			// AxisSetUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 436);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.button_RemoveAxis);
			this.Controls.Add(this.button_AddAxis);
			this.Controls.Add(this.Panel_SetAxis);
			this.Name = "AxisSetUI";
			this.Text = "SetAxisUI";
			this.Load += new System.EventHandler(this.SetAxisUI_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Button button_RemoveAxis;
		private System.Windows.Forms.Button button_AddAxis;
		private System.Windows.Forms.Panel Panel_SetAxis;
	}
}