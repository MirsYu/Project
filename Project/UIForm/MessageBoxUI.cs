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
	public partial class MessageBoxUI : Form
	{
		/// <summary>
		/// 标题
		/// </summary>
		public static string tag_formTitle;
		/// <summary>
		/// 内容
		/// </summary>
		public static string tag_formContent;

		public MessageBoxButtons tag_buttons;

		public DialogResult tag_DialogResult;

		public MessageBoxUI()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <param name="caption"></param>
		/// <param name="buttons"></param>
		/// <param name="icon"></param>
		public MessageBoxUI(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			tag_buttons = buttons;
			tag_formTitle = caption;
			tag_formContent = text;
			InitializeComponent();
			button_Abort.Visible = false;
			button_Ignore.Visible = false;
			button_Retry.Visible = false;

		}
		public void AbortEventHandler(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		///  
		// 摘要:
		//     消息框包含“中止”、“重试”和“忽略”按钮。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MessageBoxUI_AbortRetryIgnoreShow(object sender, EventArgs e)
		{
			label_Content.Text = tag_formContent;
			label_Content.Location = new Point((this.Size.Width - label_Content.Size.Width) / 2, (this.Size.Height - label_Content.Size.Height) / 2 - 50);

			this.Text = tag_formTitle;
			switch (tag_buttons)

			{
				case MessageBoxButtons.AbortRetryIgnore:
					{
						button_Abort.Text = "中止";
						button_Abort.DialogResult = DialogResult.Abort;
						button_Retry.Text = "重试";
						button_Retry.DialogResult = DialogResult.Retry;
						button_Ignore.Text = "忽略";
						button_Ignore.DialogResult = DialogResult.Ignore;
						button_Abort.Visible = true;
						button_Ignore.Visible = true;
						button_Retry.Visible = true;
					}
					break;
				case MessageBoxButtons.OK:
					{
						button_Retry.Text = "确定";
						button_Retry.DialogResult = DialogResult.OK;
						button_Retry.Visible = true;
						button_Abort.Visible = false;
						button_Ignore.Visible = false;
					}
					break;

				case MessageBoxButtons.OKCancel:
					{
						button_Abort.Text = "确定";
						button_Abort.DialogResult = DialogResult.OK;
						button_Ignore.Text = "取消";
						button_Ignore.DialogResult = DialogResult.Cancel;
						button_Abort.Visible = true;
						button_Ignore.Visible = true;
						button_Retry.Visible = false;
					}
					break;

				case MessageBoxButtons.YesNo:
					{
						button_Abort.Text = "是";
						button_Abort.DialogResult = DialogResult.Yes;
						button_Ignore.Text = "否";
						button_Ignore.DialogResult = DialogResult.No;
						button_Abort.Visible = true;
						button_Ignore.Visible = true;
						button_Retry.Visible = false;
					}
					break;
				case MessageBoxButtons.YesNoCancel:
					{
						button_Abort.Text = "是";
						button_Abort.DialogResult = DialogResult.Yes;
						button_Retry.Text = "否";
						button_Retry.DialogResult = DialogResult.No;
						button_Ignore.Text = "取消";
						button_Ignore.DialogResult = DialogResult.Cancel;
						button_Abort.Visible = true;
						button_Ignore.Visible = true;
						button_Retry.Visible = true;
					}
					break;
			}
		}
		private void MessageBoxUI_Load(object sender, EventArgs e)
		{
			MessageBoxUI_AbortRetryIgnoreShow(null, null);
		}

	}
}
