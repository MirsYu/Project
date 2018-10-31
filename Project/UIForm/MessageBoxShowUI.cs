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
	public partial class MessageBoxShowUI : Form
	{
		//showNoButton 有没有否按钮
		//str提示的内容
		//strTitle标题
		int Index = 0;
		int ErrCode = 0;
		public MessageBoxShowUI(string str, string strTitle, bool showNoButton, int ShowIndex, bool activeAlarm, int errorCode)
		{
			InitializeComponent();
			label_Content.Text = str;
			Global.WorkVar.NowPopUpMsg = str;
			Text = strTitle;
			Index = ShowIndex;
			ErrCode = errorCode;
			if (showNoButton == false)
			{
				button_NO.Visible = false;
				button_Yes.Text = "确定";
				button_Yes.Left = this.Width / 2 - button_Yes.Width / 2;
			}
			if (activeAlarm)
			{
				Global.WorkVar.BuzzerActiveByMsgForms = true;
			}
			if (ErrCode != 0)
			{
			}
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			Global.WorkVar.TopMostFormChooseYes = true;
			this.Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Global.WorkVar.TopMostFormChooseYes = false;
			this.Close();
		}

		private void MessageBoxShowUI_Load(object sender, EventArgs e)
		{
			Global.WorkVar.TopMostFormShowing = true;
		}

		private void MessageBoxShowUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Global.WorkVar.TopMostFormShowing)
			{
				//Global.CVar.TopMostFormChooseYes = false;
				Global.WorkVar.TopMostFormShowing = false;
				if (Index == Global.FormFlash.CONFIRM_YES_ON)
				{
					Global.FormFlash.bConfirmYesNo = false;
				}
				else if (Index == Global.FormFlash.CONFIRM_YES)
				{
					Global.FormFlash.bConfirmYes = false;
				}
			}
			Global.WorkVar.BuzzerActiveByMsgForms = false;
			Global.WorkVar.NowPopUpMsg = "";
		}
	}
}
