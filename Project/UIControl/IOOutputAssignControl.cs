using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
	public partial class IOOutputAssignControl : UserControl
	{
		public StationModule tag_StationModule;
		public IOOutputAssignControl()
		{
			InitializeComponent();
		}

		private void comboBox_Station_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				int i = 0;

				if (!string.IsNullOrEmpty(sm.strStationName) && (sm.strStationName == comboBox_Station.SelectedItem.ToString()))
				{
					for (i = 0; i < sm.intUseOutputIoCount; i++)
					{
						listBox1.Items.Add(sm.arrOutputIo[i].StrIoName);
					}
				}

			}
		}

		private void comboBox_Station2_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				int i = 0;

				if (!string.IsNullOrEmpty(sm.strStationName) && (sm.strStationName == comboBox_Station2.SelectedItem.ToString()))
				{
					for (i = 0; i < sm.intUseOutputIoCount; i++)
					{
						listBox2.Items.Add(sm.arrOutputIo[i].StrIoName);
					}
					tag_StationModule = sm;
					break;

				}

			}
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			try
			{
				IOParameter IO = null;
				foreach (StationModule sm in StationManage._Config.arrWorkStation)
				{
					int i = 0;

					if (!string.IsNullOrEmpty(sm.strStationName))
					{
						for (i = 0; i < sm.intUseOutputIoCount; i++)
						{
							string axisFind = sm.arrOutputIo[i].StrIoName;
							if (axisFind == listBox1.SelectedItem.ToString())
							{
								IO = sm.arrOutputIo[i];
								break;
							}

						}
					}
					if (IO != null)
						break;
				}

				foreach (IOParameter io in tag_StationModule.arrOutputIo)
				{
					if (io == IO)
					{
						return;
					}
				}
				tag_StationModule.arrOutputIo.Add(IO);
				tag_StationModule.intUseOutputIoCount++;
				listBox2.Items.Add(IO.StrIoName);


			}
			catch
			{

			}
		}

		private void button_Del_Click(object sender, EventArgs e)
		{
			try
			{
				IOParameter IO = null;
				int i = 0;
				if (!string.IsNullOrEmpty(tag_StationModule.strStationName))
				{
					for (i = 0; i < tag_StationModule.intUseOutputIoCount; i++)
					{
						string axisFind = tag_StationModule.arrOutputIo[i].StrIoName;
						if (axisFind == listBox2.SelectedItem.ToString())
						{
							IO = tag_StationModule.arrOutputIo[i];
							break;
						}

					}
				}

				if (IO == null)
				{
					return;
				}
				tag_StationModule.arrOutputIo.Remove(IO);
				tag_StationModule.intUseOutputIoCount--;
				listBox2.Items.Remove(IO.StrIoName);


			}
			catch
			{

			}
		}

		private void IOOutputAssignControl_Load(object sender, EventArgs e)
		{
			if (StationManage._Config == null)
				return;

			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				comboBox_Station.Items.Add(sm.strStationName);
				comboBox_Station2.Items.Add(sm.strStationName);
			}
			int i = 0;
			foreach (StationModule sm in StationManage._Config.arrWorkStation)
			{
				i = 0;

				if (!string.IsNullOrEmpty(sm.strStationName))
				{
					for (i = 0; i < sm.intUseOutputIoCount; i++)
					{
						listBox1.Items.Add(sm.arrOutputIo[i].StrIoName);

					}
				}

			}
		}
	}
}
