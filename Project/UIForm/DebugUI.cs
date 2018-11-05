using System;
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
		public List<AxisMoveDebugControl> tag_AxisConfigList = new List<AxisMoveDebugControl>();

		public static Work worker;
		#endregion

		#region 私有
		private FrameUI frameUI = null;
		private DebugOffsetControl debugOffsetControl = new DebugOffsetControl();
		private PointAllShowControl pointAllShowControl = new PointAllShowControl();
		private PortSetPanelControl portSetPanelControl = new PortSetPanelControl();
		private SocketListPanelControl socketListPanelControl = new SocketListPanelControl();
		private StationModelPanelControl stationModelPanelControl = new StationModelPanelControl();


		private AxisConfig arrAxis;
		private IOParameter arrInputIo;
		private IOParameter arrOutputIo;
		private PointAggregate tag_PointAggregate;

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


		public DebugUI()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		public DebugUI(FrameUI frameUI, Work _work)
		{
			this.frameUI = frameUI;
			worker = _work;
			InitializeComponent();
			UiInit();
			ucL_StationMotion1.tag_Work = worker;
			userControl1_offset1.tag_work = worker;

			// Input IO点加入
			for (int i = 0; i < 100; i++)
			{
				IOinputStatus pvale = new IOinputStatus(null);
				pvale.Location = new Point(5, 24 + 28 * i);
				tag_IOinputStatusList.Add(pvale);
				pvale.Visible = false;
				plIOmessage.Controls.Add(pvale);
			}

			// Outpu IO点加入
			for (int i = 0; i < 100; i++)
			{
				IOoutputStatus pvale = new IOoutputStatus(null, OutIOStationSelect);
				pvale.Location = new Point(200, 24 + 28 * i);
				tag_IOIOoutputStatus.Add(pvale);
				pvale.Visible = false;
				plIOmessage.Controls.Add(pvale);
			}
		}

		public void UiInit()
		{
			pointAllShowControl = new IOAllShowControl();
			userControl_portPerameter1 = new UserCtrl.UserControl_portPerameter();
			ucL_StationMotion1 = new StrongProject.UCL_StationMotion();
			userControl_socketList1 = new UserControl_socketList();
			userControl_configIni1 = new StrongProject.UserControl_configIni();
			userControl1_offset1 = new StrongProject.UserControl1_offset();
			ioAllShow1 = new IoAllShow();

			pointAllShowControl.tag_Work = worker;
			userControl_portPerameter1.tag_Work = worker;
			userControl_socketList1.tag_Work = worker;
			ucL_StationMotion1.tag_Work = worker;

			TabPagManual.Controls.Add(userControl_ShowAllPoint1);
			tabPage_automatic.Controls.Add(ioAllShow1);
			tabPage1.Controls.Add(ucL_StationMotion1);
			//userControl1_offset1.tag_work = worker;
			tabPage_config.Controls.Add(userControl1_offset1);
			tabPage_PortSetting.Controls.Add(userControl_portPerameter1);
			TabPagConnect.Controls.Add(userControl_socketList1);

			userControl_portPerameter1.Location = new Point(0, 0);
			userControl_socketList1.Location = new Point(0, 0);
			userControl_portPerameter1.Size = new Size(TabPagConnect.Size.Width, TabPagConnect.Size.Height);
			userControl_socketList1.Size = new Size(TabPagConnect.Size.Width, TabPagConnect.Size.Height);

			ioAllShow1.Location = new Point(0, 0);
			ioAllShow1.Size = new Size(tabPage_automatic.Size.Width, tabPage_automatic.Size.Height - 10);
			userControl_ShowAllPoint1.tag_Work = worker;
			userControl_ShowAllPoint1.Location = new Point(0, CBStnChioce.Location.Y + CBStnChioce.Size.Height + 10);
			userControl_ShowAllPoint1.Size = new Size(userControl_ShowAllPoint1.Size.Width - 100, tabCtrlDebug.Size.Height + 30);
			Console.SetOut(new ConsoleOut(textBox_Log));
		}

		private void comboBox_FlowName_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 获取节点信息 
			// push 到 terrview上
			// Tree view 可拖拽
			// 节点选中 获得参数

			tag_StationModule = StationManage.FindStation(comboBox_FlowName.Text);
			if (tag_StationModule != null)
			{
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

			}
		}

		private void treeView_FlowStruct_MouseDown(object sender, MouseEventArgs e)
		{
			if ((sender as TreeView) != null)
			{
				treeView_FlowStruct.SelectedNode = treeView_FlowStruct.GetNodeAt(e.X, e.Y);
				// 找到对应的StationModule 

				for (int i = 0; i < tag_StationModule.arrPoint.Count; i++)
				{
					if (tag_StationModule.arrPoint[i].strName == treeView_FlowStruct.SelectedNode.Text)
					{

					}
				}
			}
		}
	}
}
