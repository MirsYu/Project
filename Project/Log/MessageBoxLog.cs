using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
	public class MessageBoxLog
	{
		public static MessageBoxUI log;
		// 摘要:
		//     显示具有指定文本的消息框。
		//
		// 参数:
		//   text:
		//     要在消息框中显示的文本。
		//
		// 返回结果:
		//     System.Windows.Forms.DialogResult 值之一。
		public static DialogResult Show(string text)
		{
			LogOutControl.OutLog(text, 0);
			log = new MessageBoxUI(text, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
			DialogResult tag_buttons = log.ShowDialog();
			log = null;
			return tag_buttons;
		}

		//
		// 摘要:
		//     显示具有指定文本和标题的消息框。
		//
		// 参数:
		//   text:
		//     要在消息框中显示的文本。
		//
		//   caption:
		//     要在消息框的标题栏中显示的文本。
		//
		// 返回结果:
		//     System.Windows.Forms.DialogResult 值之一。

		public static DialogResult Show(string text, string caption)
		{
			LogOutControl.OutLog(text, 0);
			MessageBoxUI box = new MessageBoxUI(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
			DialogResult tag_buttons = box.ShowDialog();
			return tag_buttons;
		}


		//
		// 摘要:
		//     显示具有指定文本、标题、按钮和图标的消息框。
		//
		// 参数:
		//   text:
		//     要在消息框中显示的文本。
		//
		//   caption:
		//     要在消息框的标题栏中显示的文本。
		//
		//   buttons:
		//     System.Windows.Forms.MessageBoxButtons 值之一，可指定在消息框中显示哪些按钮。
		//
		//   icon:
		//     System.Windows.Forms.MessageBoxLog 值之一，它指定在消息框中显示哪个图标。
		//
		// 返回结果:
		//     System.Windows.Forms.DialogResult 值之一。
		//
		// 异常:
		//   System.ComponentModel.InvalidEnumArgumentException:
		//     指定的 buttons 参数不是 System.Windows.Forms.MessageBoxButtons 的成员。- 或 -指定的 icon
		//     参数不是 System.Windows.Forms.MessageBoxIcon 的成员。
		//
		//   System.InvalidOperationException:
		//     尝试在运行模式不是用户交互模式的进程中显示 System.Windows.Forms.MessageBoxLog。这是由 System.Windows.Forms.SystemInformation.UserInteractive
		//     属性指定的。
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			LogOutControl.OutLog(text, 0);
			MessageBoxUI box = new MessageBoxUI(text, caption, buttons, icon);
			DialogResult tag_buttons = box.ShowDialog();
			return tag_buttons;
		}
	}
}
