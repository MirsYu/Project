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
	public partial class AxisSafetyManageUI : Form
	{
		/// <summary>
		///点位
		/// </summary>
		public PointAggregate tag_PointAggregate;
		/// <summary>
		/// 
		/// </summary>
		public List<AxisSafetySetControl> tag_AxisSafeList;
		/// <summary>
		/// 
		/// </summary>
		public AxisSafetyManageUI()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pa"></param>
		public AxisSafetyManageUI(PointAggregate pa)
		{
			tag_PointAggregate = pa;
			tag_AxisSafeList = new List<AxisSafetySetControl>();
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AxisSafetyManageUI_Load(object sender, EventArgs e)
		{
			listBox_Axis.Items.Clear();
			listBox_AllAxisConfig.Items.Clear();
			groupBox1.Controls.Clear();

			foreach (AxisConfig ac in StationManage._Config.axisArray)
			{

				listBox_Axis.Items.Add(ac.AxisName);
			}

			if (tag_PointAggregate != null)
			{

				int i = 0;
				if (tag_PointAggregate.tag_AxisSafeManage == null)
				{
					tag_PointAggregate.tag_AxisSafeManage = new AxisSafeManage(tag_PointAggregate);
				}
				foreach (AxisSafe asf in tag_PointAggregate.tag_AxisSafeManage.tag_AxisSafeList)
				{
					string AsixName = null;

					foreach (AxisConfig ac in StationManage._Config.axisArray)
					{

						int axis = (int)ac.tag_MotionCardManufacturer * 1000 + ac.CardNum * 100 + ac.AxisNum;
						if (axis == asf.tag_AxisId)
						{
							AsixName = ac.AxisName;
							break;
						}
					}
					listBox_AllAxisConfig.Items.Add(AsixName);
					AxisSafetySetControl uscAs = new AxisSafetySetControl(asf, AsixName);
					uscAs.Location = new Point(10, 30 + i * uscAs.Size.Height);
					tag_AxisSafeList.Add(uscAs);
					i++;
					groupBox1.Controls.Add(uscAs);
				}
			}
		}

		private void button_Save_Click(object sender, EventArgs e)
		{

			if (MessageBoxLog.Show("是否全部保存", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}

			foreach (AxisSafetySetControl usc_ax in tag_AxisSafeList)
			{
				usc_ax.Save(false);
			}
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			try
			{
				AxisConfig axis = null;
				string axisanem = null;
				foreach (StationModule sm in StationManage._Config.arrWorkStation)
				{
					int i = 0;
					if (!string.IsNullOrEmpty(sm.strStationName))
					{
						for (i = 0; i < sm.intUseAxisCount; i++)
						{
							string axisFind = sm.arrAxis[i].AxisName;
							if (axisFind == listBox_Axis.SelectedItem.ToString())
							{
								axis = sm.arrAxis[i];
								axisanem = axisFind;
								break;
							}

						}
					}
					if (axis != null)
						break;
				}

				foreach (AxisSafe asf in tag_PointAggregate.tag_AxisSafeManage.tag_AxisSafeList)
				{
					int axisid = ((int)(axis.tag_MotionCardManufacturer)) * 1000 + axis.CardNum * 100 + axis.AxisNum;
					if (axisid == asf.tag_AxisId)
					{
						return;
					}
				}
				tag_PointAggregate.tag_AxisSafeManage.Add((short)axis.tag_MotionCardManufacturer, axis.CardNum, axis.AxisNum);
				listBox_AllAxisConfig.Items.Add(axisanem);

			}
			catch
			{ }
		}

		private void button_Refresh_Click(object sender, EventArgs e)
		{
			AxisSafetyManageUI_Load(null, null);
		}

		private void button_Del_Click(object sender, EventArgs e)
		{
			if (listBox_AllAxisConfig.SelectedIndex > -1)
			{
				tag_PointAggregate.tag_AxisSafeManage.tag_AxisSafeList.RemoveAt(listBox_AllAxisConfig.SelectedIndex);
				listBox_AllAxisConfig.Items.RemoveAt(listBox_AllAxisConfig.SelectedIndex);
			}
		}
	}
}
