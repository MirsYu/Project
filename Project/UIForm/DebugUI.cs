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
		private static readonly ILog log = LogManager.GetLogger("DebugUI.cs");
		public StationModule tag_StationModule;

		/// <summary>
		/// 父节点
		/// </summary>
		TreeNode node = new TreeNode();

		/// <summary>
		/// 子节点
		/// </summary>
		TreeNode chlid;

		public DebugUI()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
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
