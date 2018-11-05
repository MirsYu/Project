namespace Project
{
	partial class LoginUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_SwitchOP = new System.Windows.Forms.Button();
			this.button_ChangePSW = new System.Windows.Forms.Button();
			this.button_Login = new System.Windows.Forms.Button();
			this.textBox_Password = new System.Windows.Forms.TextBox();
			this.comboBox_ID = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(43, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(104, 109);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(128, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 24);
			this.label3.TabIndex = 25;
			this.label3.Text = "用户登录系统";
			// 
			// button_SwitchOP
			// 
			this.button_SwitchOP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_SwitchOP.Font = new System.Drawing.Font("幼圆", 9F);
			this.button_SwitchOP.Location = new System.Drawing.Point(288, 162);
			this.button_SwitchOP.Name = "button_SwitchOP";
			this.button_SwitchOP.Size = new System.Drawing.Size(89, 33);
			this.button_SwitchOP.TabIndex = 22;
			this.button_SwitchOP.Text = "切换到操作员";
			this.button_SwitchOP.UseVisualStyleBackColor = true;
			this.button_SwitchOP.Click += new System.EventHandler(this.button_SwitchOP_Click);
			// 
			// button_ChangePSW
			// 
			this.button_ChangePSW.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_ChangePSW.Font = new System.Drawing.Font("幼圆", 9F);
			this.button_ChangePSW.Location = new System.Drawing.Point(179, 207);
			this.button_ChangePSW.Name = "button_ChangePSW";
			this.button_ChangePSW.Size = new System.Drawing.Size(198, 33);
			this.button_ChangePSW.TabIndex = 23;
			this.button_ChangePSW.Text = "修改密码";
			this.button_ChangePSW.UseVisualStyleBackColor = true;
			this.button_ChangePSW.Click += new System.EventHandler(this.button_ChangePSW_Click);
			// 
			// button_Login
			// 
			this.button_Login.Font = new System.Drawing.Font("幼圆", 9F);
			this.button_Login.Location = new System.Drawing.Point(179, 162);
			this.button_Login.Name = "button_Login";
			this.button_Login.Size = new System.Drawing.Size(103, 33);
			this.button_Login.TabIndex = 24;
			this.button_Login.Text = "登陆";
			this.button_Login.UseVisualStyleBackColor = true;
			this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
			// 
			// textBox_Password
			// 
			this.textBox_Password.Location = new System.Drawing.Point(242, 116);
			this.textBox_Password.Name = "textBox_Password";
			this.textBox_Password.PasswordChar = '*';
			this.textBox_Password.Size = new System.Drawing.Size(135, 21);
			this.textBox_Password.TabIndex = 21;
			this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
			// 
			// comboBox_ID
			// 
			this.comboBox_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ID.FormattingEnabled = true;
			this.comboBox_ID.Location = new System.Drawing.Point(242, 83);
			this.comboBox_ID.Name = "comboBox_ID";
			this.comboBox_ID.Size = new System.Drawing.Size(135, 20);
			this.comboBox_ID.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(176, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "用户密码:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(176, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 19;
			this.label1.Text = "用户类型:";
			// 
			// LoginUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 282);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button_SwitchOP);
			this.Controls.Add(this.button_ChangePSW);
			this.Controls.Add(this.button_Login);
			this.Controls.Add(this.textBox_Password);
			this.Controls.Add(this.comboBox_ID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginUI";
			this.Text = "LoginUI";
			this.Load += new System.EventHandler(this.LoginUI_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginUI_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_SwitchOP;
		private System.Windows.Forms.Button button_ChangePSW;
		private System.Windows.Forms.Button button_Login;
		private System.Windows.Forms.TextBox textBox_Password;
		private System.Windows.Forms.ComboBox comboBox_ID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}