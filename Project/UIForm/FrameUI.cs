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

		#region 全局
		public Work tag_Work = new Work();
		public MainUI mainUI;
		public DebugUI debugUI;
		public AlarmUI alarmUI;
		public PortShowControl portShowControl = new PortShowControl();
		public ModeSelectControl modeSelectControl = new ModeSelectControl();
		#endregion

		#region 私有
		private FormAdaptive formAdaptive = new FormAdaptive();
		#endregion


		public FrameUI()
		{
			InitializeComponent();
		}

		private void FrameUI_Load(object sender, EventArgs e)
		{
			//////////////////////////////////////////////////////////////////////////
			mainUI = new MainUI(this, tag_Work);
			mainUI.TopLevel = false;
			mainUI.Parent = this.PanelForm;

			debugUI = new DebugUI(this, tag_Work);
			debugUI.TopLevel = false;
			debugUI.Parent = this.PanelForm;
			alarmUI = new AlarmUI();
			alarmUI.TopLevel = false;
			alarmUI.Parent = this.PanelForm;
			formAdaptive.RecordOldSizeScale(this.PanelForm);
			timer_Main.Start();
			label_Version.Text = "版本号:" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

			portShowControl.tag_Work = tag_Work;
			portShowControl.Location = new Point(label_User.Location.X + label_User.Size.Width - 20 , label_User.Location.Y -8);
			portShowControl.Size = new Size((label_Version.Location.X - portShowControl.Location.X - 10) / 5, panel_MainInfo.Size.Height - 5);
			panel_MainInfo.Controls.Add(portShowControl);

			modeSelectControl.tag_Work = tag_Work;
			modeSelectControl.Location = new Point(portShowControl.Location.X + portShowControl.Size.Width -40, portShowControl.Location.Y);
			modeSelectControl.Size = new Size((label_Version.Location.X - modeSelectControl.Location.X - 10) / 4, panel_MainInfo.Size.Height-5);
			panel_MainInfo.Controls.Add(modeSelectControl);

			ShowSubWindow(Global.CConst.FRM_MAIN);

			//////////////////////////////////////////////////////////////////////////
			if (Global.WorkVar.tag_StopState == 1)
			{
				IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
				IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
				IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");
				NewCtrlCardV0.SetOutputIoBit(redlight, 1);
				NewCtrlCardV0.SetOutputIoBit(yellowlight, 0);
				NewCtrlCardV0.SetOutputIoBit(greenlight, 0);
			}
			IOParameter servoOnSwith = StationManage.FindOutputIo("总复位", "使能");
			if (servoOnSwith != null)
			{
				NewCtrlCardV0.SetOutputIoBit(servoOnSwith, 1);
			}
		}

		#region 子窗体
		/// <summary>
		/// 子窗体显示
		/// </summary>
		/// <param name="wndIndex"></param>
		/// <param name="isNeedPermit"></param>
		private void ShowSubWindow(int wndIndex, bool isNeedPermit = false)
		{
			if (isNeedPermit)//权限限制
			{
				if (Global.CConst.UserLevel < Global.CConst.USER_ADMINISTOR)
				{
					Global.Forms.Msg.MessageTopMost("你没有权限进行此操作，请先登录", false, false, false);
					return;
				}
			}
			if (Global.CConst.Form_Var == wndIndex)
				return;

			this.mainUI.Hide();
			this.debugUI.Hide();
			this.alarmUI.Hide();
			this.MenuMain.Image = Properties.Resources.Home1;
			this.MenuManual.Image = Properties.Resources.Set;
			this.MenuAlarm.Image = Properties.Resources.Alarm;
			switch (wndIndex)
			{
				case Global.CConst.FRM_MAIN:
					this.mainUI.Location = new Point(3, 0);
					this.mainUI.Show();
					Global.CConst.Form_Var = Global.CConst.FRM_MAIN;
					this.MenuMain.Image = Properties.Resources.Home_sel;
					MenuMain.BackColor = Color.FromArgb(174, 218, 151);
					MenuManual.BackColor = Color.Transparent;
					MenuAlarm.BackColor = Color.Transparent;
					break;
				case Global.CConst.FRM_DEBUG:
					this.debugUI.Location = new Point(3, 0);
					this.debugUI.Show();
					Global.CConst.Form_Var = Global.CConst.FRM_DEBUG;
					this.MenuManual.Image = Properties.Resources.Set__sel;
					MenuManual.BackColor = Color.FromArgb(174, 218, 151);
					MenuMain.BackColor = Color.Transparent;
					MenuAlarm.BackColor = Color.Transparent;
					break;
				case Global.CConst.FORM_ALARM:
					this.alarmUI.Location = new Point(3, 0);
					this.alarmUI.Show();
					Global.CConst.Form_Var = Global.CConst.FORM_ALARM;
					this.MenuAlarm.Image = Properties.Resources.Alarm_sel;
					MenuAlarm.BackColor = Color.FromArgb(174, 218, 151);
					MenuMain.BackColor = Color.Transparent;
					MenuManual.BackColor = Color.Transparent;
					break;
				default:
					break;
			}
		}

		private delegate void delShowSubWindow(int wndIndex, bool isNeedPermit);
		public void ShowSubWindowDel(int wndIndex, bool isNeedPermit = false)
		{
			if (this.IsHandleCreated)
			{
				this.Invoke(new delShowSubWindow(ShowSubWindow), wndIndex, isNeedPermit);
			}
		}
		#endregion

		#region 信息弹窗
		/// <summary>
		/// 信息弹窗
		/// </summary>
		/// <param name="str"></param>
		/// <param name="showYesNO"></param>
		/// <param name="title"></param>
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
		#endregion

		#region 三色灯
		public void LightandBuzzer(string lightColor, bool bBuzzer = false)
		{
			IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
			IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
			IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");
			IOParameter buzzer = StationManage.FindOutputIo("主控系统", "蜂鸣器");
			NewCtrlCardV0.SetOutputIoBit(redlight, 0);
			NewCtrlCardV0.SetOutputIoBit(yellowlight, 0);
			NewCtrlCardV0.SetOutputIoBit(greenlight, 0);
			if (bBuzzer)
			{
				NewCtrlCardV0.SetOutputIoBit(buzzer, 1);
			}
			if (lightColor == "红灯")
			{
				NewCtrlCardV0.SetOutputIoBit(redlight, 1);
			}
			else if (lightColor == "黄灯")
			{
				NewCtrlCardV0.SetOutputIoBit(yellowlight, 1);
			}
			else if (lightColor == "绿灯")
			{
				NewCtrlCardV0.SetOutputIoBit(greenlight, 1);
			}
		}
		#endregion


		private void timer_Main_Tick(object sender, EventArgs e)
		{
			label_Day.Text = "当前时间:" + DateTime.Now.ToString();

			if (Global.CConst.UserLevel == Global.CConst.USER_OPERATOR)
			{
				this.MenuLogin.Image = Properties.Resources.User;
				label_User.Text = "权限：操作员";
			}
			else
			{
				this.MenuLogin.Image = Properties.Resources.User_sel;
				if (Global.CConst.UserLevel == Global.CConst.USER_ADMINISTOR)
				{
					label_User.Text = "权限：管理员";
				}
				if (Global.CConst.UserLevel == Global.CConst.USER_SUPERADMIN)
				{
					label_User.Text = "权限：超级管理员";
				}
			}
		}

		private void FrameUI_SizeChanged(object sender, EventArgs e)
		{
			if (formAdaptive != null)
			{
				formAdaptive.AutoScaleControl(this.PanelForm);
			}
		}

		private void FrameUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBoxLog.Show("确定要退出程序吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
				IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
				IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");
				NewCtrlCardV0.SetOutputIoBit(redlight, 0);
				NewCtrlCardV0.SetOutputIoBit(yellowlight, 0);
				NewCtrlCardV0.SetOutputIoBit(greenlight, 0);
				Global.WorkVar.tag_ButtonStopState = 1;
				tag_Work.Stop();
				NewCtrlCardV0.CloseCard(tag_Work.tag_CardHave);
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void FrameUI_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}


		private void MenuMain_Click(object sender, EventArgs e)
		{
			ShowSubWindowDel(Global.CConst.FRM_MAIN);
		}

		private void MenuManual_Click(object sender, EventArgs e)
		{
			ShowSubWindowDel(Global.CConst.FRM_DEBUG);
		}

		private void MenuAlarm_Click(object sender, EventArgs e)
		{
			ShowSubWindowDel(Global.CConst.FORM_ALARM, true);
		}

		private void MenuLogin_Click(object sender, EventArgs e)
		{
			LoginUI loginUI = new LoginUI(this);
			loginUI.ShowDialog();
		}

		private void MenuRun_Click(object sender, EventArgs e)
		{
			if (Global.WorkVar.tag_workState == 0)
			{
				if (Global.WorkVar.tag_ResetState != 2)
				{
					MessageBoxLog.Show("请复位");
				}
				else
				{
					Global.WorkVar.tag_IsExit = 0;
					Global.WorkVar.bcanRunFalg = true;
				}
			}
			else
			{
				Global.WorkVar.bcanRunFalg = false;
				Global.WorkVar.tag_IsExit = 1;
				Global.WorkVar.tag_ResetState = 0;
				Global.WorkVar.tag_workState = 0;
			}
		}

		private void MenuPause_Click(object sender, EventArgs e)
		{
			if (Global.WorkVar.tag_SuspendState == 1)
			{
				if (Global.WorkVar.tag_ResetState != 1)
				{
					IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
					IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
					IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");
					NewCtrlCardV0.SetOutputIoBit(redlight, 0);
					NewCtrlCardV0.SetOutputIoBit(yellowlight, 0);
					NewCtrlCardV0.SetOutputIoBit(greenlight, 1);
				}
				tag_Work.Continue(null);
			}
			else
			{
				if (Global.WorkVar.tag_ResetState != 1)
				{
					IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
					IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
					IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");
					NewCtrlCardV0.SetOutputIoBit(redlight, 0);
					NewCtrlCardV0.SetOutputIoBit(yellowlight, 1);
					NewCtrlCardV0.SetOutputIoBit(greenlight, 0);
				}
				tag_Work.Suspend(null);
			}
		}

		private void MenuReset_Click(object sender, EventArgs e)
		{
			tag_Work.Rest();
		}

		private void MenuEmg_Click(object sender, EventArgs e)
		{
			IOParameter redlight = StationManage.FindOutputIo("主控系统", "三色灯_红");
			IOParameter yellowlight = StationManage.FindOutputIo("主控系统", "三色灯_黄");
			IOParameter greenlight = StationManage.FindOutputIo("主控系统", "三色灯_绿");

			NewCtrlCardV0.SetOutputIoBit(redlight, 1);
			NewCtrlCardV0.SetOutputIoBit(yellowlight, 0);
			NewCtrlCardV0.SetOutputIoBit(greenlight, 0);
			Global.WorkVar.tag_ButtonStopState = 1;

			tag_Work.Stop();
		}


	}
}
