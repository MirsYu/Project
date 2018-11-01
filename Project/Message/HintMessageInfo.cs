using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project
{
	public static class HintMessageInfo
	{
		public static FrameUI framUI = null;
		public static bool HasShowForm = false;
		public static bool bConfirmNo = false;  //点击返回否
		public static bool bConfirmYes = false;  //点击返回是
		public static bool bInitialized = false;//窗体初始化加载完成

		public static void Init(FrameUI form)
		{
			framUI = form;
		}

		public static void MessageTopMost(string mes, bool showYesNO = false, string title = "提示(hint)")
		{

			while (HasShowForm)
			{
				Thread.Sleep(500);
			}
			HasShowForm = true;
			ShowMesg(mes, showYesNO, title);

		}
		private static void ShowMesg(string mes, bool showYesNO, string title)
		{
			if (bInitialized)
			{
				framUI.ShowFormMesg(mes, showYesNO, title);
			}
			else
			{
				MessageBoxHintUI ShowMesg = new MessageBoxHintUI(mes, showYesNO, title);
				ShowMesg.ShowDialog();
			}

		}
	}
}
