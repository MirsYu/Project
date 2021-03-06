﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace Project
{
	public partial class DebugUI : Form
	{
		#region 全局
		public string tag_stationName;
		public StationModule tag_StationModule;
		public static Work worker;
		public PointAllShowControl tag_UserControl_ShowAllPoint;
		public string tag_copyStationName = "";

		public List<PointValueControl> tag_PointVlaueList = new List<PointValueControl>();
		public List<AxisMoveDebugControl> tag_AxisConfigList = new List<AxisMoveDebugControl>();
		public List<MoveDisControl> tag_SetP_DistanceList = new List<MoveDisControl>();
		public List<IOInputStatusControl> tag_IOinputStatusList = new List<IOInputStatusControl>();
		public List<IOOutputStatusControl> tag_IOIOoutputStatus = new List<IOOutputStatusControl>();

		#endregion

		#region 私有
		private FrameUI frameUI = null;
		private DebugOffsetControl debugOffsetControl = new DebugOffsetControl();
		private PointAllShowControl pointAllShowControl = new PointAllShowControl();
		private PortSetPanelControl portSetPanelControl = new PortSetPanelControl();
		private SocketListPanelControl socketListPanel = new SocketListPanelControl();
		private StationModelPanelControl sationModelPanelControl = new StationModelPanelControl();
		private IOAllShowControl iOAllShowControl = new IOAllShowControl();

		private AxisConfig axisConfig;
		private IOParameter arrInputIo;
		private IOParameter arrOutputIo;
		private PointAggregate tag_PointAggregate;

		const string CONSTANT_SPEED = "常速";
		const string LOW_SPEED = "低速";
		const string HIGHT_SPEED = "高速";

		/// <summary>
		/// 父节点
		/// </summary>
		TreeNode node = new TreeNode();

		/// <summary>
		/// 子节点
		/// </summary>
		TreeNode chlid;

		private static readonly ILog log = LogManager.GetLogger("DebugUI.cs");
		#endregion

		public void UiInit()
		{
			pointAllShowControl.tag_Work = worker;
			portSetPanelControl.tag_Work = worker;
			socketListPanel.tag_Work = worker;
			sationModelPanelControl.tag_Work = worker;

			TabPagManual.Controls.Add(pointAllShowControl);
			tabPage_automatic.Controls.Add(iOAllShowControl);
			tabPage1.Controls.Add(sationModelPanelControl);
			//userControl1_offset1.tag_work = worker;
			tabPage_config.Controls.Add(debugOffsetControl);
			tabPage_PortSetting.Controls.Add(portSetPanelControl);
			TabPagConnect.Controls.Add(socketListPanel);

			portSetPanelControl.Location = new Point(0, 0);
			socketListPanel.Location = new Point(0, 0);
			portSetPanelControl.Size = new Size(TabPagConnect.Size.Width, TabPagConnect.Size.Height);
			socketListPanel.Size = new Size(TabPagConnect.Size.Width, TabPagConnect.Size.Height);

			iOAllShowControl.Location = new Point(0, 0);
			iOAllShowControl.Size = new Size(tabPage_automatic.Size.Width, tabPage_automatic.Size.Height - 10);
			pointAllShowControl.tag_Work = worker;
			pointAllShowControl.Location = new Point(CBStnChioce.Location.X, checkBox1.Location.Y + 20);
			pointAllShowControl.Size = new Size(checkBox1.Location.X - CBStnChioce.Location.X - 10, this.Size.Height - CBStnChioce.Location.Y - CBStnChioce.Size.Height);

		}

		public DebugUI(FrameUI frm, Work _work)
		{
			frameUI = frm;
			worker = _work;
			InitializeComponent();
			this.Dock = DockStyle.Fill;
			UiInit();
			sationModelPanelControl.tag_Work = worker;
			debugOffsetControl.tag_work = worker;

			// Input IO点加入
			for (int i = 0; i < 100; i++)
			{
				IOInputStatusControl pvale = new IOInputStatusControl(null);
				pvale.Location = new Point(5, 24 + 28 * i);
				tag_IOinputStatusList.Add(pvale);
				pvale.Visible = false;
				plIOmessage.Controls.Add(pvale);
			}

			// Outpu IO点加入
			for (int i = 0; i < 100; i++)
			{
				IOOutputStatusControl pvale = new IOOutputStatusControl(null, OutIOStationSelect);
				pvale.Location = new Point(200, 24 + 28 * i);
				tag_IOIOoutputStatus.Add(pvale);
				pvale.Visible = false;
				plIOmessage.Controls.Add(pvale);
			}
		}

		void OutIOStationSelect(object var)
		{
			if (var != null)
			{
				tag_StationModule = (StationModule)var;
				tag_PointAggregate = null;
				SetIndexPointAggregate();
				RefreshStation();
				tag_UserControl_ShowAllPoint.UserControl_ShowAllPoint_HeightLight(null, null);
			}
		}

		//点击手动TabPage界面
		private void TabPagManual_Enter(object sender, EventArgs e)
		{
			CBSpeedLevel.Items.Add(CONSTANT_SPEED);
			CBSpeedLevel.Items.Add(LOW_SPEED);
			CBSpeedLevel.Items.Add(HIGHT_SPEED);
		}

		//手动调试界面加载
		private void FrmDebug_Load(object sender, EventArgs e)
		{
			TabPagManual_Enter(sender, e);
			CBSpeedLevel.Text = "常速";
			StnChioceCB_Show(sender, e);

			if (StationManage.OpenSevroAllAxis() != 0)
			{
				MessageBoxLog.Show("使能失败");
				return;
			}
			if (worker != null && worker._Config != null)
			{
				checkBox3_safeLight.Checked = worker._Config.tag_PrivateSave.tag_safeLightOffOn;
				checkBox5.Checked = worker._Config.tag_PrivateSave.tag_safeGateOffOn;
				if (worker._Config.tag_PrivateSave.tag_SuspendType == 0)
				{
					checkBox_sup.Checked = true;
				}
				else
				{
					checkBox_sup.Checked = false;
				}
			}
			TB_LeftStationLog.Text = worker._Config.tag_LeftStationLogIndex.ToString();
			TB_RightStationLog.Text = worker._Config.tag_RightStationLogIndex.ToString();
		}

		//轴位配置
		private void AxisCfigBT_Click(object sender, EventArgs e)
		{
			//Debug frac = new Debug(worker);
			//frac.Show();
			if (tag_StationModule == null)
			{
				MessageBoxLog.Show("请选择工站名");
				return;
			}
			try
			{
				PointDebugSetUI debugS = new PointDebugSetUI(worker, tag_StationModule);
				debugS.Text = "工位配置界面" + " 当前工站：" + tag_StationModule.strStationName;
				debugS.ShowDialog();
			}
			catch (Exception mes)
			{
				LogOutControl.OutLog(mes.Message, 0);
			}
		}

		//Combox刷新工位参数
		private void StnChioceCB_Show(object sender, EventArgs e)
		{
			if (worker == null || worker.Config == null || worker.Config.intUseStationCount < 1)
				return;
			comboBox_IO.Items.Clear();
			CBStnChioce.Items.Clear();
			comboBox_FlowName.Items.Clear();
			foreach (StationModule sm in worker.Config.arrWorkStation)
			{
				if (sm.strStationName != "" && sm.strStationName != null)
				{
					CBStnChioce.Items.Add(sm.strStationName);
					comboBox_FlowName.Items.Add(sm.strStationName);
					comboBox_IO.Items.Add(sm.strStationName);
				}
			}
		}

		//Combox选中工位后自动刷新工位参数
		private void StnChioceCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			tag_StationModule = StationManage.FindStation(CBStnChioce.Text);
			tag_PointAggregate = null;
			SetIndexPointAggregate();
			RefreshStation();
			tag_UserControl_ShowAllPoint.UserControl_ShowAllPoint_HeightLight(null, null);
			comboBox_IO.Focus();
			comboBox_IO.Text = CBStnChioce.Text;
			comboBox1_SelectedIndexChanged(sender, e);
			NewCtrlCardIO.tag_IO_refresh = 10;

		}

		//刷新手动界面工位信息
		public void RefreshStation()
		{
			if (tag_UserControl_ShowAllPoint == null)
			{

				tag_UserControl_ShowAllPoint = pointAllShowControl;
				tag_UserControl_ShowAllPoint.tag_StationModule = tag_StationModule;
				tag_UserControl_ShowAllPoint.tag_Work = worker;
				tag_UserControl_ShowAllPoint.Show();
			}
			else
			{
				tag_UserControl_ShowAllPoint.tag_statioOpen = checkBox3_statioOpen.Checked;
				tag_UserControl_ShowAllPoint.tag_StationModule = tag_StationModule;
				tag_UserControl_ShowAllPoint.Show();
			}
			axisRefreshStation();
			IORefreshStation();
			axisDisRefreshStation();
			NewCtrlCardIO.tag_IO_refresh = 1;
		}

		private void IORefreshStation()
		{

			int m = 0;
			//  plIOmessage.Controls.Clear();
			if (tag_StationModule == null)
				return;
			for (int i = 0; i < tag_StationModule.intUseInputIoCount && i < tag_StationModule.arrInputIo.Count; i++)
			{
				IOInputStatusControl ioinput = tag_IOinputStatusList[i];
				ioinput.IOinputStatus_Load(tag_StationModule.arrInputIo[i]);
				ioinput.Visible = true;

				m = i;
			}
			for (int i = m; i < tag_IOinputStatusList.Count; i++)
			{
				tag_IOinputStatusList[i].Visible = false;


			}

			//IOoutput组件加载到界面
			for (int i = 0; i < tag_StationModule.intUseOutputIoCount && i < tag_StationModule.arrOutputIo.Count; i++)
			{
				IOOutputStatusControl iooutput = tag_IOIOoutputStatus[i];
				iooutput.IOoutputStatus_Load(tag_StationModule.arrOutputIo[i]);
				iooutput.Visible = true;
				m = i;
			}
			for (int i = m; i < tag_IOinputStatusList.Count; i++)
			{
				tag_IOIOoutputStatus[i].Visible = false;
			}

		}

		private void axisRefreshStation()
		{
			//  
			// groupBox_Axis.Controls.Clear();
			CBChoiceAxis.Items.Clear();
			int i = 0;
			int m = 0;
			for (int j = 0; j < tag_AxisConfigList.Count; j++)
			{
				tag_AxisConfigList[j].Visible = false;

			}
			if (tag_StationModule == null)
			{
				return;
			}
			foreach (AxisConfig ac in tag_StationModule.arrAxis)
			{
				m = -1;
				for (int j = 0; j < tag_AxisConfigList.Count; j++)
				{
					if (tag_AxisConfigList[j].arrAxis == ac)
					{
						m = j;
						break;
					}

				}
				AxisMoveDebugControl adc = null;
				if (m != -1)
				{
					adc = tag_AxisConfigList[m];
					adc.Location = new Point(i * adc.Size.Width, 5);
					CBChoiceAxis.Items.Add(ac.AxisName);
				}
				else
				{
					adc = new AxisMoveDebugControl(ac, worker);
					tag_AxisConfigList.Add(adc);
					adc.Location = new Point(i * adc.Size.Width, 5);
					groupBox_Axis.Controls.Add(adc);
					CBChoiceAxis.Items.Add(ac.AxisName);
				}
				adc.Visible = true;
				i++;
			}
		}

		private void axisDisRefreshStation()
		{
			if (tag_StationModule == null)
				return;
			//   panel_CBPointDisSet.Controls.Clear();

			int m = 0;
			for (int j = 0; j < tag_SetP_DistanceList.Count; j++)
			{
				tag_SetP_DistanceList[j].Visible = false;

			}
			for (int i = 0; i < tag_StationModule.arrAxis.Count; i++)
			{

				for (int j = 0; j < tag_SetP_DistanceList.Count; j++)
				{
					if (tag_SetP_DistanceList[j].arrAxis == tag_StationModule.arrAxis[i])
					{
						m = j;
						break;
					}
				}

				MoveDisControl spd = null;
				if (m != -1)
				{
					spd = new MoveDisControl(tag_StationModule.arrAxis[i]);
					spd.Location = new Point(5, 18 + 20 * i);

					//  panel_CBPointDisSet.Controls.Add(spd);
					spd.num = i + 1;
				}
				else
				{
					spd = tag_SetP_DistanceList[m];
					spd.Location = new Point(5, 18 + 20 * i);

					// panel_CBPointDisSet.Controls.Add(spd);
					spd.num = i + 1;
				}
				break;
			}
			StationManage.Shortdistanceset = 1;
			StationManage.Longdistanceset = 10;

		}

		//选择回零轴
		private void button_home_Click(object sender, EventArgs e)
		{
			Global.WorkVar.tag_isFangDaiJieChu = false;
			if (!Work.IsMove(1))
			{
				return;
			}
			if (CBChoiceAxis.Text == "")
			{
				MessageBoxLog.Show("选择轴位不能为空");
				return;
			}
			AxisConfig acg;
			acg = StationManage.FindAxis(CBStnChioce.Text, CBChoiceAxis.Text);
			if (acg == null)
			{
				MessageBoxLog.Show("查找轴失败");
				return;
			}

			GoHomeParameterUI gohome = new GoHomeParameterUI(acg);
			gohome.ShowDialog();
		}

		//打开使能
		private void OpenSevroBT_Click(object sender, EventArgs e)
		{
			if (CBChoiceAxis.Text == "")
			{
				MessageBoxLog.Show("选择轴位不能为空");
				return;
			}
		}

		//选择速度等级
		private void CBSpeedLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CBSpeedLevel.Text != null)
			{
				switch (CBSpeedLevel.Text)
				{
					case "常速":
						StationManage.Speedlevel = "1"; break; //“1”代表常速
					case "高速":
						StationManage.Speedlevel = "2"; break; //“2”代表常速
					case "低速":
						StationManage.Speedlevel = "3"; break; //“3”代表常速
				}
			}
		}

		private short StationRunThread(object o)
		{
			string tet = (string)o;
			return pointMotion.StationRun(tet);
		}

		private short StationRunThreadStep(object o)
		{
			WorkBase wb = (WorkBase)o;
			wb.tag_Manual.tag_StepName = 0;
			return pointMotion.StationRun(wb.tag_stationName, wb.tag_Manual);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Global.WorkVar.tag_IsExit = 0;
			Global.WorkVar.tag_isFangDaiJieChu = false;
			if (Global.WorkVar.tag_ResetState != 2)
			{
				MessageBoxLog.Show("请先复位!");
				return;
			}
			if (string.IsNullOrEmpty(CBStnChioce.Text))
			{
				MessageBoxLog.Show("请选择工站名");
				return;
			}
			if (tag_StationModule == worker._Config.tag_safeStationModule)
			{
				MessageBoxLog.Show("此工位为安全配置工位，不能运行");
				return;
			}
			if (Global.WorkVar.tag_workState == 1)
			{
				MessageBoxLog.Show("工作中，不能运行");
				return;
			}
			object station = (object)worker.GetStation(tag_StationModule.strStationName);
			if (station == null)
			{
				WaitUI wait = new WaitUI(StationRunThread, tag_StationModule.strStationName);
				wait.ShowDialog();
			}
			else
			{
				WaitUI wait = new WaitUI(StationRunThreadStep, station);
				wait.ShowDialog();
			}

		}

		private short pointRun(object o)
		{
			PointAggregate a = (PointAggregate)o;
			short ret = pointMotion.pointRunStep(a, a.strStationName);

			return ret;
		}

		private short pointRun2(object o)
		{
			PointAggregate a = (PointAggregate)o;
			short ret = pointMotion.pointRunStep(a);

			return ret;
		}

		private short pointRunEnd(object o)
		{

			tag_UserControl_ShowAllPoint.UserControl_ShowAllPoint_HeightLight(null, null);
			return 0;
		}

		public PointAggregate GetIndexPointAggregate()
		{

			int index = tag_UserControl_ShowAllPoint.tag_page_Count * tag_UserControl_ShowAllPoint.tag_page_index;

			int i = 0;
			if (checkBox3_statioOpen.Checked)
			{
				for (int n = 0; n < tag_StationModule.arrPoint.Count; n++)
				{
					PointAggregate pa = tag_StationModule.arrPoint[n];
					if (pa.tag_BeginPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_BeginPointAggregateList)
						{
							if (i == tag_StationModule.tag_stepId)
							{
								return pb;
							}
							i++;
						}
					}
					if (i == tag_StationModule.tag_stepId)
					{
						return pa;
					}
					i++;
					if (pa.tag_EndPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_EndPointAggregateList)
						{
							if (i == tag_StationModule.tag_stepId)
							{
								return pb;
							}
							i++;
						}
					}

				}

			}
			else
			{
				if (tag_StationModule.tag_stepId >= tag_StationModule.arrPoint.Count)
				{
					tag_StationModule.tag_stepId = 0;
				}
				return tag_StationModule.arrPoint[tag_StationModule.tag_stepId];
			}
			tag_StationModule.tag_stepId = 0;
			return tag_StationModule.arrPoint[tag_StationModule.tag_stepId];

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Global.WorkVar.tag_IsExit = 0;
			Global.WorkVar.tag_isFangDaiJieChu = false;
			if (Global.WorkVar.tag_ResetState != 2)
			{
				MessageBoxLog.Show("请先复位!");
				return;
			}
			if (tag_StationModule == worker._Config.tag_safeStationModule)
			{
				MessageBoxLog.Show("此工位为安全配置工位，不能运行");
				return;
			}
			if (tag_StationModule == null)
			{
				MessageBoxLog.Show("请选择工位");
				return;
			}
			tag_stationName = tag_StationModule.strStationName;

			tag_PointAggregate = GetIndexPointAggregate();

			if (!checkBox3_statioOpen.Checked)
			{

				WaitUI wait = new WaitUI(pointRun, pointRunEnd, tag_PointAggregate);
				wait.ShowDialog();
			}
			else
			{
				WaitUI wait = new WaitUI(pointRun2, pointRunEnd, tag_PointAggregate);
				wait.ShowDialog();
			}




		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Global.WorkVar.tag_GuanLian = checkBox1.Checked;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//IOinput组件加载到界面
			int m = 0;
			plIOmessage.Controls.Clear();
			StationModule sm = StationManage.FindStation(comboBox_IO.Text);
			for (int i = 0; i < sm.intUseInputIoCount && i < sm.arrInputIo.Count; i++)
			{
				IOInputStatusControl ioinput = new IOInputStatusControl(sm.arrInputIo[i]);
				{
					ioinput.Location = new Point(5, 24 + 28 * i);
					plIOmessage.Controls.Add(ioinput);
				}
				arrInputIo = sm.arrInputIo[i];
				m = i + 1;
			}
			int n = 0;
			//IOoutput组件加载到界面
			for (int i = 0; i < sm.intUseOutputIoCount && i < sm.arrOutputIo.Count; i++)
			{
				IOOutputStatusControl iooutput = new IOOutputStatusControl(sm.arrOutputIo[i], OutIOStationSelect);
				iooutput.Location = new Point(200, 24 + 40 * i);
				plIOmessage.Controls.Add(iooutput);
				arrOutputIo = sm.arrOutputIo[i];
				n = i + 1;

			}
			NewCtrlCardIO.tag_IO_refresh = 10;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FlowManageUI frmSm = new FlowManageUI(worker);
			frmSm.ShowDialog();
			StnChioceCB_Show(null, null);
			RefreshStation();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			CBStnChioce.Text = worker._Config.tag_safeStationModule.strStationName;
			tag_StationModule = worker._Config.tag_safeStationModule;
			if (tag_StationModule.intUsePointCount == 0)
				tag_StationModule.intUsePointCount = 1;
			RefreshStation();
		}

		// 空跑
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			Global.WorkVar.bEmptyRun = checkBox2.Checked;
			checkBox6.Enabled = checkBox2.Checked;
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			Global.WorkVar.bEmptyRunWithBattery = !checkBox6.Checked;
		}

		public void SetIndexPointAggregate()
		{
			int i = 0;
			// 工位展开
			if (checkBox3_statioOpen.Checked)
			{
				for (int n = 0; n < tag_StationModule.arrPoint.Count; n++)
				{
					PointAggregate pa = tag_StationModule.arrPoint[n];

					if (n == tag_StationModule.tag_stepId)
					{
						tag_StationModule.tag_stepId = i;
						return;
					}

					if (pa.tag_BeginPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_BeginPointAggregateList)
						{

							i++;
						}
					}
					i++;
					if (pa.tag_EndPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_EndPointAggregateList)
						{
							i++;
						}
					}
				}
			}
			else
			{
				for (int n = 0; n < tag_StationModule.arrPoint.Count; n++)
				{
					PointAggregate pa = tag_StationModule.arrPoint[n];

					if (i == tag_StationModule.tag_stepId)
					{
						tag_StationModule.tag_stepId = n;
						return;
					}

					if (pa.tag_BeginPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_BeginPointAggregateList)
						{
							if (i == tag_StationModule.tag_stepId)
							{
								tag_StationModule.tag_stepId = n;
								return;
							}
							i++;
						}
					}
					i++;
					if (pa.tag_EndPointAggregateList != null)
					{
						foreach (PointAggregate pb in pa.tag_EndPointAggregateList)
						{
							if (i == tag_StationModule.tag_stepId)
							{
								tag_StationModule.tag_stepId = n;
								return;
							}
							i++;
						}
					}
				}
			}
			tag_StationModule.tag_stepId = 0;
		}

		// 工位展开
		private void checkBox3_statioOpen_CheckedChanged(object sender, EventArgs e)
		{

			tag_PointAggregate = null;
			SetIndexPointAggregate();
			tag_UserControl_ShowAllPoint.UserControl_ShowAllPoint_HeightLight(null, null);
			RefreshStation();
			comboBox_IO.Focus();
		}

		private void checkBox3_safeLight_CheckedChanged(object sender, EventArgs e)
		{
			worker._Config.tag_PrivateSave.tag_safeLightOffOn = checkBox3_safeLight.Checked;
			worker._Config.Save();
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			Global.WorkVar.tag_isAxisMove = checkBox3.Checked;
		}

		private void checkBox_sup_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_sup.Checked)
			{
				worker._Config.tag_PrivateSave.tag_SuspendType = 0;
			}
			else
			{
				worker._Config.tag_PrivateSave.tag_SuspendType = 1;
			}
		}

		private void TB_LeftStationLog_TextChanged(object sender, EventArgs e)
		{
			try
			{
				worker._Config.tag_LeftStationLogIndex = Int32.Parse(TB_LeftStationLog.Text);
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
			}
		}

		private void TB_RightStationLog_TextChanged(object sender, EventArgs e)
		{
			try
			{
				worker._Config.tag_RightStationLogIndex = Int32.Parse(TB_RightStationLog.Text);
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
			}
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			Global.WorkVar.tag_isFangDaiJieChu = checkBox4.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			worker._Config.tag_PrivateSave.tag_safeGateOffOn = checkBox5.Checked;
			worker._Config.Save();
		}

		private void PointDistance_ValueChanged(object sender, EventArgs e)
		{
			StationManage.Longdistanceset = Decimal.ToDouble(PointDistance.Value);
			StationManage.Shortdistanceset = Decimal.ToDouble(PointDistance.Value);

		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			StationManage.Distancemode = "长距";
		}


		#region tets


		private void comboBox_FlowName_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 获取节点信息 
			// push 到 terrview上
			// Tree view 可拖拽
			// 节点选中 获得参数

			tag_StationModule = StationManage.FindStation(comboBox_FlowName.Text);
			if (tag_StationModule != null)
			{
				node.Nodes.Clear();
				node.Remove();
				treeView_FlowStruct.Nodes.Clear();
				node.Text = comboBox_FlowName.Text;
			}
			for (int i = 0; i < tag_StationModule.arrPoint.Count; i++)
			{
				// 工位名称
				chlid = new TreeNode();
				chlid.Text = tag_StationModule.arrPoint[i].strName;
				// 绑定选中事件
				node.Nodes.Add(chlid);
			}
			treeView_FlowStruct.Nodes.Add(node);
		}

		private void treeView_FlowStruct_MouseDown(object sender, MouseEventArgs e)
		{
			if ((sender as TreeView) != null)
			{
				treeView_FlowStruct.SelectedNode = treeView_FlowStruct.GetNodeAt(e.X, e.Y);
				// 找到对应的StationModule 

				// 先获取到轴的信息
				for (int a = 0; a < tag_StationModule.arrAxis.Count; a++)
				{
					dataGridView1.Rows.Clear();
				}

				for (int i = 0; i < tag_StationModule.arrPoint.Count; i++)
				{
					// 这里是一个点位信息
					if (tag_StationModule.arrPoint[i].strName == treeView_FlowStruct.SelectedNode.Text)
					{

					}
				}
			}
		}
		#endregion





	}
}
