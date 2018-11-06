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
	public partial class PointIODelaySetUI : Form
	{
		private IOInputSetControl ucl_InIoName1 = new IOInputSetControl();
		private IOInputSetControl ucl_InIoName2 = new IOInputSetControl();

		private IOWaitSingleSetControl ucl_InIo1 = new IOWaitSingleSetControl();
		private IOWaitSingleSetControl ucl_InIo2 = new IOWaitSingleSetControl();
		/// <summary>
		/// 
		/// </summary>
		public PointAggregate tag_PointModule;
		/// <summary>
		/// 
		/// </summary>
		public OutIOParameterPoint tag_OutIo;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_PoitModule"></param>
		public PointIODelaySetUI(PointAggregate _PoitModule)
		{
			tag_PointModule = _PoitModule;
			if (tag_PointModule.tag_AxisSafeManage == null)
			{
				tag_PointModule.tag_AxisSafeManage = new AxisSafeManage(_PoitModule);
			}
			if (tag_PointModule.tag_AxisSafeManage.tag_InIoList == null)
			{
				tag_PointModule.tag_AxisSafeManage.tag_InIoList = new List<OutIOParameterPoint>();
				tag_PointModule.tag_OutIo = new OutIOParameterPoint();
				tag_PointModule.tag_AxisSafeManage.tag_InIoList.Add(tag_PointModule.tag_OutIo);
			}
			if (tag_PointModule.tag_AxisSafeManage.tag_InIoList.Count == 0)
			{
				tag_PointModule.tag_OutIo = new OutIOParameterPoint();
				tag_PointModule.tag_AxisSafeManage.tag_InIoList.Add(tag_PointModule.tag_OutIo);
			}
			if (tag_PointModule.tag_AxisSafeManage.tag_InIoList.Count > 0)
			{
				tag_OutIo = tag_PointModule.tag_AxisSafeManage.tag_InIoList[0];

			}
			#region UI
			// 
			// ucl_InIo2
			// 
			this.ucl_InIo2.Location = new System.Drawing.Point(806, 59);
			this.ucl_InIo2.Margin = new System.Windows.Forms.Padding(4);
			this.ucl_InIo2.Name = "ucl_InIo2";
			this.ucl_InIo2.Size = new System.Drawing.Size(366, 33);
			this.ucl_InIo2.TabIndex = 21;
			// 
			// ucl_InIo1
			// 
			this.ucl_InIo1.Location = new System.Drawing.Point(806, 24);
			this.ucl_InIo1.Margin = new System.Windows.Forms.Padding(4);
			this.ucl_InIo1.Name = "ucl_InIo1";
			this.ucl_InIo1.Size = new System.Drawing.Size(366, 33);
			this.ucl_InIo1.TabIndex = 13;
			// 
			// ucl_InIoName2
			// 
			this.ucl_InIoName2.Location = new System.Drawing.Point(315, 60);
			this.ucl_InIoName2.Margin = new System.Windows.Forms.Padding(4);
			this.ucl_InIoName2.Name = "ucl_InIoName2";
			this.ucl_InIoName2.Size = new System.Drawing.Size(322, 33);
			this.ucl_InIoName2.TabIndex = 10;
			// 
			// ucl_InIoName1
			// 
			this.ucl_InIoName1.Location = new System.Drawing.Point(313, 24);
			this.ucl_InIoName1.Margin = new System.Windows.Forms.Padding(4);
			this.ucl_InIoName1.Name = "ucl_InIoName1";
			this.ucl_InIoName1.Size = new System.Drawing.Size(347, 33);
			this.ucl_InIoName1.TabIndex = 9;
			#endregion
			InitializeComponent();
		}
		private void Tree_Load(object sender, EventArgs e)
		{
			treeView_IO.TopNode.Nodes.Clear();
			foreach (OutIOParameterPoint io in tag_PointModule.tag_AxisSafeManage.tag_InIoList)
			{
				if (io.tag_name == null)
				{
					io.tag_name = "io输入输出控制";
				}
				if (io.tag_name != null)
				{
					treeView_IO.TopNode.Nodes.Add(io.tag_name);
					continue;
				}
			}
			treeView_IO.TopNode.Text = tag_PointModule.strName + "->" + tag_OutIo.tag_name;
		}
		private void FrmInIoList_Load(object sender, EventArgs e)
		{
			if (sender != null)
				Tree_Load(sender, e);
			comboBox_Stat.Items.Clear();
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				comboBox_Stat.Items.Add(sm.strStationName);
			}
			comboBox_Stat.Items.Add("ALL");
			string strStationName = null;
			if (tag_OutIo != null)
			{
				strStationName = tag_OutIo.tag_IniO1.tag_name;
				if (strStationName == null)
				{
					strStationName = tag_OutIo.tag_InOut1.tag_name;
				}
				if (strStationName == null)
				{
					strStationName = tag_OutIo.tag_InOut2.tag_name;
				}
				if (strStationName == null)
				{
					strStationName = tag_PointModule.strStationName;
				}
			}
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				if (sm.strStationName == strStationName)
				{
					foreach (IOParameter ioP in sm.arrOutputIo)
					{
						listBox1.Items.Add(ioP.StrIoName);
					}
					foreach (IOParameter ioP in sm.arrInputIo)
					{
						listBox2.Items.Add(ioP.StrIoName);
					}
				}
			}


			if (tag_OutIo != null && tag_OutIo.tag_InOut1 != null)
			{

				ucl_InIoName1.show(tag_OutIo.tag_InOut1, 1);

			}
			else
			{
				ucl_InIoName1.show(null, 1);
			}
			if (tag_OutIo != null && tag_OutIo.tag_InOut2 != null)
			{
				ucl_InIoName2.show(tag_OutIo.tag_InOut2, 1);
			}
			if (tag_OutIo != null && tag_OutIo.tag_IniO1 != null)
			{
				ucl_InIo1.show(tag_OutIo.tag_IniO1);
			}
			else
			{
				ucl_InIo1.show(null);
			}
			if (tag_OutIo != null && tag_OutIo.tag_IniO2 != null)
			{
				ucl_InIo2.show(tag_OutIo.tag_IniO2);
			}
			else
			{
				ucl_InIo2.show(null);
			}
			if (tag_PointModule.tag_AxisSafeManage == null)
			{
				checkBox_andCheck.Checked = true;
			}
			else
			{
				checkBox_andCheck.Checked = tag_PointModule.tag_AxisSafeManage.tag_isAndCheck;
			}
			this.Text = tag_PointModule.strName;
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			try
			{
				if (tag_OutIo.tag_InOut1 == null)
				{
					tag_OutIo.tag_InOut1 = new InIOParameterPoint();
				}
				tag_OutIo.tag_InOut1.tag_IOName = listBox1.SelectedItem.ToString(); ;
				if (comboBox_Stat.SelectedItem != null)
					tag_OutIo.tag_InOut1.tag_name = comboBox_Stat.SelectedItem.ToString();
				ucl_InIoName1.show(tag_OutIo.tag_InOut1, 1);
			}
			catch
			{ }
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (tag_OutIo.tag_InOut2 == null)
			{

				tag_OutIo.tag_InOut2 = new InIOParameterPoint();
			}
			if (listBox1.SelectedItem != null)
				tag_OutIo.tag_InOut2.tag_IOName = listBox1.SelectedItem.ToString(); ;
			if (comboBox_Stat.SelectedItem != null)
				tag_OutIo.tag_InOut2.tag_name = comboBox_Stat.SelectedItem.ToString();
			ucl_InIoName2.show(tag_OutIo.tag_InOut2, 2);
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{


		}

		private void comboBox_Stat_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{

				if (sm.strStationName == comboBox_Stat.SelectedItem.ToString() || comboBox_Stat.SelectedItem.ToString() == "ALL")
				{
					foreach (IOParameter ioP in sm.arrOutputIo)
					{
						listBox1.Items.Add(ioP.StrIoName);
					}
					foreach (IOParameter ioP in sm.arrInputIo)
					{
						listBox2.Items.Add(ioP.StrIoName);
					}
					if (comboBox_Stat.SelectedItem.ToString() != "ALL")
					{
						break;
					}
				}
			}

		}
		private void button4_AddIn_Click(object sender, EventArgs e)
		{


			tag_OutIo.tag_InOut1.tag_IOName = listBox1.SelectedItem.ToString(); ;
			tag_OutIo.tag_InOut1.tag_name = comboBox_Stat.SelectedItem.ToString();
			ucl_InIoName1.show(tag_OutIo.tag_InOut1, 1);
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			try
			{

				if (tag_OutIo.tag_IniO2 == null)
				{
					tag_OutIo.tag_IniO2 = new InIOParameterPoint();
				}
				tag_OutIo.tag_IniO2.tag_IOName = listBox2.SelectedItem.ToString();
				if (comboBox_Stat.SelectedItem != null)
					tag_OutIo.tag_IniO2.tag_name = comboBox_Stat.SelectedItem.ToString();
				ucl_InIo2.show(tag_OutIo.tag_IniO2);
			}
			catch
			{ }
		}

		private void button2_ADD_Out_Click(object sender, EventArgs e)
		{

		}

		private void MenuItem_Add_Click(object sender, EventArgs e)
		{

			tag_PointModule.tag_OutIo = new OutIOParameterPoint();
			tag_PointModule.tag_OutIo.tag_name = "io输入输出控制" + tag_PointModule.tag_AxisSafeManage.tag_InIoList.Count;
			tag_PointModule.tag_AxisSafeManage.tag_InIoList.Add(tag_PointModule.tag_OutIo);
			tag_OutIo = tag_PointModule.tag_OutIo;
			Tree_Load(null, null);
		}

		private void MenuItem_Rename_Click(object sender, EventArgs e)
		{
			treeView_IO.LabelEdit = true;
			treeView_IO.SelectedNode.BeginEdit();
		}

		private void treeView_IO_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			string oldStr = e.Node.Text;
			if (e.Label == null)
			{
				treeView_IO.SelectedNode.Text = oldStr;
				return;
			}
			string newStr = e.Label.Trim();
			TreeView node = (TreeView)sender;

			if (newStr == null || newStr == "")
			{
				treeView_IO.SelectedNode.Text = oldStr;
				return;
			}
			tag_OutIo.tag_name = newStr;

			e.CancelEdit = false;


			treeView_IO.SelectedNode.EndEdit(false);

		}

		private void MenuItem_Del_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < tag_PointModule.tag_AxisSafeManage.tag_InIoList.Count; i++)
				{
					if (tag_PointModule.tag_AxisSafeManage.tag_InIoList[i].tag_name == treeView_IO.SelectedNode.Text)
					{
						tag_PointModule.tag_AxisSafeManage.tag_InIoList.RemoveAt(i);
					}
				}

				Tree_Load(null, null);
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
			}
		}

		private void treeView_IO_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TreeView tv = (TreeView)sender;

			for (int i = 0; i < tag_PointModule.tag_AxisSafeManage.tag_InIoList.Count; i++)
			{
				if (treeView_IO.SelectedNode != null && tag_PointModule.tag_AxisSafeManage.tag_InIoList[i].tag_name == treeView_IO.SelectedNode.Text)
				{
					// tag_PointModule.tag_AxisSafeManage.tag_InIoList.RemoveAt(i);
					tag_OutIo = tag_PointModule.tag_AxisSafeManage.tag_InIoList[i];
					break;
				}
			}
			FrmInIoList_Load(null, null);
		}

		private void checkBox_andCheck_CheckedChanged(object sender, EventArgs e)
		{
			tag_PointModule.tag_AxisSafeManage.tag_isAndCheck = checkBox_andCheck.Checked;
		}
	}
}
