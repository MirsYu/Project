using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public static class FormMessage
	{
		#region MessageOnce
		//can define msg identifier as const
		const int msgMaxIndex = 20;
		static bool[] msgIndex = new bool[msgMaxIndex];
		public enum MSG
		{
			IOmsg = 0,//card io error hint
			ScrewIndex = 1,
			CSV = 2, //csv error hint
			PRO_SCREW = 3,
			CARD_CMD = 4,
			RESET = 5,
			EMG = 6,
			TCP = 7
		}
		//确认弹框前只出现一次弹框
		public static bool MesssageShowOnce(string strShow, MSG Index, int nStyle = 0)
		{
			return true;
		}
		#endregion
	}
}
