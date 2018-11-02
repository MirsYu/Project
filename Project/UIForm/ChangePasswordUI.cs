using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
	public partial class ChangePasswordUI : Form
	{
		public ChangePasswordUI()
		{
			InitializeComponent();
		}

		private void ChangePassword(TextBox txtpw1, TextBox txtpw2, int nUser)
		{
			if (nUser > Global.CConst.UserLevel)
			{
				Global.Forms.Msg.MessageTopMost("当前权限比要修改密码的权限低，不能执行此操作!", false, false, false);
				return;
			}
			if (txtpw1.Text.Trim() != txtpw2.Text.Trim())
			{
				Global.Forms.Msg.MessageTopMost("两次输入密码不一致!", false, false, false);
				return;
			}
			switch (nUser)
			{
				case Global.CConst.USER_OPERATOR:
					Global.WorkVar._config.UserPassword = txtpw1.Text.Trim();
					break;
				case Global.CConst.USER_ADMINISTOR:
					Global.WorkVar._config.AdminPassword = txtpw1.Text.Trim();
					break;
				case Global.CConst.USER_SUPERADMIN:
					Global.WorkVar._config.SuperPassword = txtpw1.Text.Trim();
					break;
				default:
					break;
			}
			Global.WorkVar._config.Save();
			Global.Forms.Msg.MessageTopMost("修改密码成功!", false, false, false);
		}
		private void button_SuperPassword_Click(object sender, EventArgs e)
		{
			ChangePassword(textBox_SuperPassword, textBox_SuperPassword_, Global.CConst.USER_SUPERADMIN);
		}

		private void button_AdminPassword_Click(object sender, EventArgs e)
		{
			ChangePassword(textBox_AdminPassword, textBox_AdminPassword_, Global.CConst.USER_ADMINISTOR);
		}

		private void button_UserPassword_Click(object sender, EventArgs e)
		{
			ChangePassword(textBox_UserPassword, textBox_UserPassword_, Global.CConst.USER_OPERATOR);
		}
	}
}
