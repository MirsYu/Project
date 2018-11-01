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
	public partial class FrameUI : Form
	{
		public FrameUI()
		{
			InitializeComponent();
		}

		private void FrameUI_Load(object sender, EventArgs e)
		{

		}

		//信息弹窗
		private delegate void del(string str, bool showYesNO, string title);

		private void ShowMesg(string str, bool showYesNO, string title)
		{
			MessageBoxHintUI ShowMesg = new MessageBoxHintUI(str, showYesNO, title);
			ShowMesg.ShowDialog();
		}

		public void ShowFormMesg(string mesg, bool showYesNO, string title)
		{
			this.Invoke(new del(ShowMesg), mesg, showYesNO, title);
		}
	}
}
