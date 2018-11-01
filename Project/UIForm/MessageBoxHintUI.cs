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
	public partial class MessageBoxHintUI : Form
	{
		private string Mesg = "hello";
		private string Title = "提示(hint)";
		private bool ShowYesNoBtn = false;
		public MessageBoxHintUI(string mes, bool showYesNO, string title)
		{
			InitializeComponent();
			Mesg = mes;
			ShowYesNoBtn = showYesNO;
			Title = title;

		}

		private void MessageBoxHintUI_Load(object sender, EventArgs e)
		{
			this.Text = Title;
			this.CenterToParent();
			HintMessageInfo.HasShowForm = true;
			HintMessageInfo.bConfirmNo = false;  //点击返回否
			HintMessageInfo.bConfirmYes = false;  //点击返回是
			if (ShowYesNoBtn)
			{
				button_Yes.Visible = true;
				button_No.Visible = true;
				button_Confirm.Visible = false;
			}
			else
			{
				button_Yes.Visible = false;
				button_No.Visible = false;
				button_Confirm.Visible = true;

			}
			label_Content.Text = Mesg;

		}

		private void btnConfim_Click(object sender, EventArgs e)
		{
			if (sender == button_Yes)
			{
				HintMessageInfo.bConfirmYes = true;  //点击返回是
			}
			else if (sender == button_No)
			{
				HintMessageInfo.bConfirmNo = true;  //点击返回否
			}
			this.Close();
			HintMessageInfo.HasShowForm = false;
		}
	}
}
