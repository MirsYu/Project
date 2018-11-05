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
	public partial class LoginUI : Form
	{
		FrameUI frameUI = new FrameUI();
		public LoginUI(FrameUI fmp)
		{
			frameUI = fmp;
			InitializeComponent();
		}
		const string OP_OPERATOR = "操作员";
		const string OP_ADMISTRATOR = "管理员";
		const string OP_SUPERAD = "超级管理员";
		private void LoginUI_Load(object sender, EventArgs e)
		{
			comboBox_ID.Items.Clear();
			comboBox_ID.Items.Add(OP_OPERATOR);
			comboBox_ID.Items.Add(OP_ADMISTRATOR);
			comboBox_ID.Items.Add(OP_SUPERAD);
			comboBox_ID.SelectedIndex = 1;
			this.CenterToParent();
		}

		private bool VerifyUser(string strPW, int nUser)
		{
			switch (nUser)
			{
				case Global.CConst.USER_OPERATOR:
					if (Global.WorkVar._config.UserPassword == null || strPW.Equals(Global.WorkVar._config.UserPassword))
					{
						Global.CConst.UserLevel = Global.CConst.USER_OPERATOR;
						return true;
					}
					break;
				case Global.CConst.USER_ADMINISTOR:
					if (Global.WorkVar._config.AdminPassword == null || strPW.Equals(Global.WorkVar._config.AdminPassword))
					{
						Global.CConst.UserLevel = Global.CConst.USER_ADMINISTOR;
						return true;
					}
					break;
				case Global.CConst.USER_SUPERADMIN:
					if (Global.WorkVar._config.SuperPassword == null || strPW.Equals(Global.WorkVar._config.SuperPassword) || strPW.Equals(Global.CConst.DTS))
					{
						Global.CConst.UserLevel = Global.CConst.USER_SUPERADMIN;
						return true;
					}
					break;
				default:
					break;
			}
			return false;
		}
		private void button_Login_Click(object sender, EventArgs e)
		{

			//Global.CConst.UserLevel = Global.CConst.USER_SUPERADMIN;
			//return ;//方便登录


			int nCboLimit = comboBox_ID.SelectedIndex;
			string strUserType = "";
			if (nCboLimit < 0)
			{
				Global.Forms.Msg.MessageTopMost("用户不能为空", false, false, false);
				return;
			}
			else
			{
				strUserType = comboBox_ID.Text;
			}
			if (Global.CConst.UserLevel > Global.CConst.USER_OPERATOR && OP_OPERATOR == strUserType)
			{

				frameUI.ShowSubWindowDel(Global.CConst.FRM_MAIN);
				//fmPro.LimitSwitchToOp();
				Global.CConst.UserLevel = Global.CConst.USER_OPERATOR;
				return;
			}
			string strGetPW = textBox_Password.Text;
			if (strGetPW.Equals(""))
			{
				Global.Forms.Msg.MessageTopMost("密码不能为空", false, false, false);
				return;
			}
			bool bLogResult = false;
			if (OP_OPERATOR == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_OPERATOR);
			}
			else if (OP_ADMISTRATOR == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_ADMINISTOR);
			}
			else if (OP_SUPERAD == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_SUPERADMIN);
			}

			if (bLogResult && (Global.CConst.UserLevel > Global.CConst.USER_OPERATOR))
			{
				frameUI.timer_Main.Enabled = true;
			}
			if (bLogResult)
			{

			}
			else
			{
				Global.Forms.Msg.MessageTopMost("登陆失败，密码与用户不匹配", false, false, false);
				return;
			}

			this.Close();
		}

		private void button_ChangePSW_Click(object sender, EventArgs e)
		{
			int nCboLimit = comboBox_ID.SelectedIndex;
			string strUserType = "";
			if (nCboLimit < 0)
			{
				Global.Forms.Msg.MessageTopMost("用户不能为空", false, false, false);
				return;
			}
			else
			{
				strUserType = comboBox_ID.Text;
			}
			string strGetPW = textBox_Password.Text;
			if (strGetPW.Equals(""))
			{
				Global.Forms.Msg.MessageTopMost("修改密码前请输入原密码", false, false, false);
				return;
			}
			bool bLogResult = false;
			if (OP_OPERATOR == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_OPERATOR);
			}
			else if (OP_ADMISTRATOR == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_ADMINISTOR);
			}
			else if (OP_SUPERAD == strUserType)
			{
				bLogResult = VerifyUser(strGetPW, Global.CConst.USER_SUPERADMIN);
			}
			if (bLogResult)
			{
				ChangePasswordUI changePassword = new ChangePasswordUI();
				changePassword.ShowDialog();
			}
			else
			{
				Global.Forms.Msg.MessageTopMost("账号、密码有误", false, false, false);
				return;
			}
			//this.Close();

		}

		private void button_SwitchOP_Click(object sender, EventArgs e)//切换到操作员
		{
			if (Global.CConst.UserLevel == Global.CConst.USER_OPERATOR)
			{
				return;
			}

			frameUI.ShowSubWindowDel(Global.CConst.FRM_MAIN);
			Global.CConst.UserLevel = Global.CConst.USER_OPERATOR;
		}

		private void LoginUI_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button_Login.PerformClick();
			}
		}

		private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button_Login.PerformClick();
			}
		}
	}
}
