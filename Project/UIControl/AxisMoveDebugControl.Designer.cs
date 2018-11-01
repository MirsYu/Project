namespace Project
{
	partial class AxisMoveDebugControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisMoveDebugControl));
			this.panel1 = new System.Windows.Forms.Panel();
			this.point2 = new System.Windows.Forms.Label();
			this.point1 = new System.Windows.Forms.Label();
			this.LB_AxisName = new System.Windows.Forms.Label();
			this.BTServoSigle = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.JogSTOPBT = new System.Windows.Forms.Button();
			this.Jog_minusBT = new System.Windows.Forms.Button();
			this.Jog_plusBT = new System.Windows.Forms.Button();
			this.lblMEL = new System.Windows.Forms.Label();
			this.lblPEL = new System.Windows.Forms.Label();
			this.lblORG = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.point2);
			this.panel1.Controls.Add(this.point1);
			this.panel1.Location = new System.Drawing.Point(3, 90);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(59, 47);
			this.panel1.TabIndex = 129;
			// 
			// point2
			// 
			this.point2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.point2.ForeColor = System.Drawing.Color.Gold;
			this.point2.Location = new System.Drawing.Point(-6, 23);
			this.point2.Name = "point2";
			this.point2.Size = new System.Drawing.Size(70, 20);
			this.point2.TabIndex = 108;
			this.point2.Text = "0.000";
			this.point2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// point1
			// 
			this.point1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.point1.ForeColor = System.Drawing.Color.Gold;
			this.point1.Location = new System.Drawing.Point(-6, 0);
			this.point1.Name = "point1";
			this.point1.Size = new System.Drawing.Size(70, 20);
			this.point1.TabIndex = 108;
			this.point1.Text = "0.000";
			this.point1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LB_AxisName
			// 
			this.LB_AxisName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_AxisName.Location = new System.Drawing.Point(0, 1);
			this.LB_AxisName.Name = "LB_AxisName";
			this.LB_AxisName.Size = new System.Drawing.Size(67, 16);
			this.LB_AxisName.TabIndex = 127;
			this.LB_AxisName.Text = "AxisName";
			this.LB_AxisName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BTServoSigle
			// 
			this.BTServoSigle.BackColor = System.Drawing.Color.DarkGreen;
			this.BTServoSigle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTServoSigle.Location = new System.Drawing.Point(0, 20);
			this.BTServoSigle.Name = "BTServoSigle";
			this.BTServoSigle.Size = new System.Drawing.Size(66, 25);
			this.BTServoSigle.TabIndex = 126;
			this.BTServoSigle.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 12);
			this.label4.TabIndex = 133;
			this.label4.Text = "0";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(44, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 12);
			this.label5.TabIndex = 134;
			this.label5.Text = "+";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(2, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 12);
			this.label3.TabIndex = 135;
			this.label3.Text = "﹣";
			// 
			// JogSTOPBT
			// 
			this.JogSTOPBT.Image = ((System.Drawing.Image)(resources.GetObject("JogSTOPBT.Image")));
			this.JogSTOPBT.Location = new System.Drawing.Point(3, 176);
			this.JogSTOPBT.Name = "JogSTOPBT";
			this.JogSTOPBT.Size = new System.Drawing.Size(60, 28);
			this.JogSTOPBT.TabIndex = 128;
			this.JogSTOPBT.UseVisualStyleBackColor = true;
			// 
			// Jog_minusBT
			// 
			this.Jog_minusBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Jog_minusBT.Image = ((System.Drawing.Image)(resources.GetObject("Jog_minusBT.Image")));
			this.Jog_minusBT.Location = new System.Drawing.Point(3, 207);
			this.Jog_minusBT.Name = "Jog_minusBT";
			this.Jog_minusBT.Size = new System.Drawing.Size(60, 28);
			this.Jog_minusBT.TabIndex = 125;
			this.Jog_minusBT.UseVisualStyleBackColor = true;
			// 
			// Jog_plusBT
			// 
			this.Jog_plusBT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Jog_plusBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Jog_plusBT.Image = ((System.Drawing.Image)(resources.GetObject("Jog_plusBT.Image")));
			this.Jog_plusBT.Location = new System.Drawing.Point(3, 143);
			this.Jog_plusBT.Name = "Jog_plusBT";
			this.Jog_plusBT.Size = new System.Drawing.Size(60, 28);
			this.Jog_plusBT.TabIndex = 124;
			this.Jog_plusBT.UseVisualStyleBackColor = false;
			// 
			// lblMEL
			// 
			this.lblMEL.Image = ((System.Drawing.Image)(resources.GetObject("lblMEL.Image")));
			this.lblMEL.Location = new System.Drawing.Point(3, 65);
			this.lblMEL.Name = "lblMEL";
			this.lblMEL.Size = new System.Drawing.Size(20, 20);
			this.lblMEL.TabIndex = 132;
			// 
			// lblPEL
			// 
			this.lblPEL.Image = ((System.Drawing.Image)(resources.GetObject("lblPEL.Image")));
			this.lblPEL.Location = new System.Drawing.Point(41, 65);
			this.lblPEL.Name = "lblPEL";
			this.lblPEL.Size = new System.Drawing.Size(20, 20);
			this.lblPEL.TabIndex = 131;
			// 
			// lblORG
			// 
			this.lblORG.Image = ((System.Drawing.Image)(resources.GetObject("lblORG.Image")));
			this.lblORG.Location = new System.Drawing.Point(22, 65);
			this.lblORG.Name = "lblORG";
			this.lblORG.Size = new System.Drawing.Size(20, 20);
			this.lblORG.TabIndex = 130;
			// 
			// AxisMoveDebugControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.JogSTOPBT);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LB_AxisName);
			this.Controls.Add(this.BTServoSigle);
			this.Controls.Add(this.Jog_minusBT);
			this.Controls.Add(this.Jog_plusBT);
			this.Controls.Add(this.lblMEL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblPEL);
			this.Controls.Add(this.lblORG);
			this.Name = "AxisMoveDebugControl";
			this.Size = new System.Drawing.Size(66, 237);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button JogSTOPBT;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label point2;
		private System.Windows.Forms.Label point1;
		private System.Windows.Forms.Label LB_AxisName;
		private System.Windows.Forms.Button BTServoSigle;
		private System.Windows.Forms.Button Jog_minusBT;
		private System.Windows.Forms.Button Jog_plusBT;
		private System.Windows.Forms.Label lblMEL;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblPEL;
		private System.Windows.Forms.Label lblORG;
	}
}
