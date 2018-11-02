namespace Project
{
	partial class AxisManageUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisManageUI));
			this.listBox_Axis = new System.Windows.Forms.ListBox();
			this.listBox_AllAxisConfig = new System.Windows.Forms.ListBox();
			this.button_Del = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox_Axis
			// 
			this.listBox_Axis.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox_Axis.FormattingEnabled = true;
			this.listBox_Axis.ItemHeight = 19;
			this.listBox_Axis.Location = new System.Drawing.Point(371, 12);
			this.listBox_Axis.Name = "listBox_Axis";
			this.listBox_Axis.Size = new System.Drawing.Size(300, 384);
			this.listBox_Axis.TabIndex = 11;
			// 
			// listBox_AllAxisConfig
			// 
			this.listBox_AllAxisConfig.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox_AllAxisConfig.FormattingEnabled = true;
			this.listBox_AllAxisConfig.ItemHeight = 19;
			this.listBox_AllAxisConfig.Location = new System.Drawing.Point(12, 12);
			this.listBox_AllAxisConfig.Name = "listBox_AllAxisConfig";
			this.listBox_AllAxisConfig.Size = new System.Drawing.Size(300, 384);
			this.listBox_AllAxisConfig.TabIndex = 10;
			// 
			// button_Del
			// 
			this.button_Del.Location = new System.Drawing.Point(318, 210);
			this.button_Del.Name = "button_Del";
			this.button_Del.Size = new System.Drawing.Size(47, 23);
			this.button_Del.TabIndex = 9;
			this.button_Del.Text = "移除";
			this.button_Del.UseVisualStyleBackColor = true;
			this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(318, 156);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(47, 23);
			this.button_Add.TabIndex = 8;
			this.button_Add.Text = "->";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// AxisManageUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 406);
			this.Controls.Add(this.listBox_Axis);
			this.Controls.Add(this.listBox_AllAxisConfig);
			this.Controls.Add(this.button_Del);
			this.Controls.Add(this.button_Add);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AxisManageUI";
			this.Text = "AxisManageUI";
			this.Load += new System.EventHandler(this.AxisManageUI_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox_Axis;
		private System.Windows.Forms.ListBox listBox_AllAxisConfig;
		private System.Windows.Forms.Button button_Del;
		private System.Windows.Forms.Button button_Add;
	}
}