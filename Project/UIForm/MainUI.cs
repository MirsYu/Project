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
	public partial class MainUI : Form
	{
		#region 全局
		public Work tag_Work;
		public WebControl webControl_NG = new WebControl();
		public WebControl webControl_Charts = new WebControl();
		public LogOutControl logOutControl = new LogOutControl();

		public static MessageBoxUI messageBoxUI;
		#endregion

		#region 私有
		private FrameUI frameUI = null;
		#endregion

		public MainUI(FrameUI frameUI, Work work)
		{
			//////////////////////////////////////////////////////////////////////////
			NewCtrlCardV0.tag_initResult = NewCtrlCardV0.initCard(work.tag_CardHave);
			if (NewCtrlCardV0.tag_initResult == 0)
				NewCtrlCardIO.StartListenSignal(work.tag_CardHave);
			work.AllAxismodeInit();

			//////////////////////////////////////////////////////////////////////////
			InitializeComponent();
			tag_Work = work;
			this.frameUI = frameUI;
			if (frameUI != null)
				this.Size = new Size(frameUI.Size.Width, frameUI.Size.Height - 50);

			webControl_NG.RefreshURL("http://www.mirsyu.xyz/HTML/NG.html");
			panel_NG.Controls.Add(webControl_NG);
			webControl_NG.Location = new Point(0, 0);
			webControl_NG.Size = webControl_NG.Parent.Size;

			webControl_Charts.RefreshURL("http://www.mirsyu.xyz/HTML/Charts.html");
			panel_Charts.Controls.Add(webControl_Charts);
			webControl_Charts.Location = new Point(0, 0);
			webControl_Charts.Size = webControl_Charts.Parent.Size;


			groupBox_RunInfo.Controls.Add(logOutControl);
			logOutControl.Location = new Point(5, 20);
			logOutControl.Size = new Size(groupBox_RunInfo.Size.Width-10, groupBox_RunInfo.Size.Height - 25);
		}

		private void MainUI_Load(object sender, EventArgs e)
		{

		}

		private void timer_MainUI_Tick(object sender, EventArgs e)
		{
			#region 信息显示
			if (Global.WorkVar.tag_MessageoxStr != null && messageBoxUI == null)
			{
				string messbox = Global.WorkVar.tag_MessageoxStr;
				messageBoxUI = new MessageBoxUI(Global.WorkVar.tag_MessageoxStr, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
				messageBoxUI.Show();
			}
			else if (Global.WorkVar.tag_MessageoxStr == null && messageBoxUI != null)
			{
				messageBoxUI.Close();
				messageBoxUI = null;
			}
			#endregion

			#region 三色灯
			if (Global.WorkVar.tag_StopState != 0)
			{
				label_Status.Text = "急停中";
				label_Status.Image = Properties.Resources.bigbk_red;
				frameUI.LightandBuzzer("红灯");
			}
			else
			{
				if (Global.WorkVar.tag_ResetState == 1)
				{
					label_Status.Text = "复位中";
					label_Status.Image = Properties.Resources.bigbk;
					frameUI.LightandBuzzer("红灯");
				}
				else
				{
					if (Global.WorkVar.tag_ResetState == 0)
					{
						label_Status.Text = "请复位";
						label_Status.Image = Properties.Resources.bigbk;
						frameUI.LightandBuzzer("红灯");
					}
					else
					{
						if (Global.WorkVar.tag_workState == 1)
						{
							if (Global.WorkVar.tag_SuspendState == 1)
							{
								label_Status.Text = "暂停中";
								label_Status.Image = Properties.Resources.bigbk_sel_;
								frameUI.LightandBuzzer("黄灯");
							}
							else
							{
								if (Global.WorkVar.bEmptyRun)
								{
									label_Status.Text = "空跑中";
									frameUI.LightandBuzzer("绿灯");
								}
								else
								{
									label_Status.Text = "工作中";
									frameUI.LightandBuzzer("绿灯");
								}
								label_Status.Image = Properties.Resources.bigbk_sel_;
							}
						}
						else
						{
							label_Status.Text = "待机中";
							label_Status.Image = Properties.Resources.bigbk_sel_;
							frameUI.LightandBuzzer("黄灯");
						}
					}
				}
			}
			#endregion
		}

		private void button_Clear_Click(object sender, EventArgs e)
		{
			if (MessageBoxLog.Show("确定要清空所有计数吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Global.WorkVar._config.tag_leftShenChanNGTotal = 0;
				Global.WorkVar._config.tag_leftShenChanOKTotal = 0;
				Global.WorkVar._config.tag_leftShenChanCT = 0;
				Global.WorkVar._config.tag_RightShenChanNGTotal = 0;
				Global.WorkVar._config.tag_RightShenChanOKTotal = 0;
				Global.WorkVar._config.tag_RightShenChanCT = 0;
				Global.WorkVar._config.Save();
			}
		}
	}
}
