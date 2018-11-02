namespace Project
{
	partial class AxisSafetyManageUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisSafetyManageUI));
			this.button_Refresh = new System.Windows.Forms.Button();
			this.listBox_Axis = new System.Windows.Forms.ListBox();
			this.listBox_AllAxisConfig = new System.Windows.Forms.ListBox();
			this.button_Del = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.button_Save = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// button_Refresh
			// 
			this.button_Refresh.Location = new System.Drawing.Point(97, 6);
			this.button_Refresh.Name = "button_Refresh";
			this.button_Refresh.Size = new System.Drawing.Size(75, 23);
			this.button_Refresh.TabIndex = 20;
			this.button_Refresh.Text = "刷新";
			this.button_Refresh.UseVisualStyleBackColor = true;
			this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
			// 
			// listBox_Axis
			// 
			this.listBox_Axis.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox_Axis.FormattingEnabled = true;
			this.listBox_Axis.ItemHeight = 19;
			this.listBox_Axis.Location = new System.Drawing.Point(303, 38);
			this.listBox_Axis.Name = "listBox_Axis";
			this.listBox_Axis.Size = new System.Drawing.Size(244, 346);
			this.listBox_Axis.TabIndex = 19;
			// 
			// listBox_AllAxisConfig
			// 
			this.listBox_AllAxisConfig.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox_AllAxisConfig.FormattingEnabled = true;
			this.listBox_AllAxisConfig.ItemHeight = 19;
			this.listBox_AllAxisConfig.Location = new System.Drawing.Point(4, 38);
			this.listBox_AllAxisConfig.Name = "listBox_AllAxisConfig";
			this.listBox_AllAxisConfig.Size = new System.Drawing.Size(244, 346);
			this.listBox_AllAxisConfig.TabIndex = 18;
			// 
			// button_Del
			// 
			this.button_Del.Location = new System.Drawing.Point(254, 122);
			this.button_Del.Name = "button_Del";
			this.button_Del.Size = new System.Drawing.Size(43, 23);
			this.button_Del.TabIndex = 17;
			this.button_Del.Text = "移除";
			this.button_Del.UseVisualStyleBackColor = true;
			this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(254, 93);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(43, 23);
			this.button_Add.TabIndex = 16;
			this.button_Add.Text = "->";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(4, 6);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 15;
			this.button_Save.Text = "全部保存";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(553, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(517, 348);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "配置";
			// 
			// AxisSafetyManageUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 389);
			this.Controls.Add(this.button_Refresh);
			this.Controls.Add(this.listBox_Axis);
			this.Controls.Add(this.listBox_AllAxisConfig);
			this.Controls.Add(this.button_Del);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AxisSafetyManageUI";
			this.Text = "AxisSafetyManageUI";
			this.Load += new System.EventHandler(this.AxisSafetyManageUI_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Refresh;
		private System.Windows.Forms.ListBox listBox_Axis;
		private System.Windows.Forms.ListBox listBox_AllAxisConfig;
		private System.Windows.Forms.Button button_Del;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}