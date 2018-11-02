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
	public partial class AxisManageUI : Form
	{
		public StationModule tag_StationManage;
		public AxisManageUI(StationModule sm)
		{
			tag_StationManage = sm;
			InitializeComponent();
		}

		private void AxisManageUI_Load(object sender, EventArgs e)
		{
			if (tag_StationManage != null)
				this.Text = tag_StationManage.strStationName;

			int i = 0;

			while (i < StationManage._Config.axisArray.Count)
			{
				listBox_AllAxisConfig.Items.Add(StationManage._Config.axisArray[i].AxisName);
				i++;
			}

			i = 0;
			if (!string.IsNullOrEmpty(tag_StationManage.strStationName))
			{
				for (i = 0; i < tag_StationManage.intUseAxisCount; i++)
				{
					listBox_Axis.Items.Add(tag_StationManage.arrAxis[i].AxisName);

				}
			}


		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			try
			{
				AxisConfig axis = null;

				int i = 0;

				while (i < StationManage._Config.axisArray.Count)
				{
					string axisFind = StationManage._Config.axisArray[i].AxisName;
					if (axisFind == listBox_AllAxisConfig.SelectedItem.ToString())
					{
						axis = StationManage._Config.axisArray[i];
						break;
					}
					i++;

				}



				foreach (AxisConfig ax in tag_StationManage.arrAxis)
				{
					if (ax == axis)
					{
						return;
					}
				}
				tag_StationManage.arrAxis.Add(axis);
				tag_StationManage.intUseAxisCount++;
				listBox_Axis.Items.Add(axis.AxisName);


			}
			catch
			{ }
		}

		private void button_Del_Click(object sender, EventArgs e)
		{
			try
			{
				AxisConfig axis = null;
				int i = 0;
				if (!string.IsNullOrEmpty(tag_StationManage.strStationName))
				{
					for (i = 0; i < tag_StationManage.intUseAxisCount; i++)
					{
						string axisFind = tag_StationManage.arrAxis[i].AxisName;
						if (axisFind == listBox_Axis.SelectedItem.ToString())
						{
							axis = tag_StationManage.arrAxis[i];
							break;
						}

					}
				}

				if (axis == null)
				{
					return;
				}
				tag_StationManage.arrAxis.Remove(axis);
				tag_StationManage.intUseAxisCount--;
				listBox_Axis.Items.Remove(axis.AxisName);


			}
			catch
			{ }
		}
	}
}
