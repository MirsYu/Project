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
	public partial class AxisSetUI : Form
	{
		public Work _Worker = null;
		public AxisSetUI(Work Worker)
		{
			_Worker = Worker;
			InitializeComponent();
		}

		private void SetAxisUI_Load(object sender, EventArgs e)
		{
			if (_Worker._Config.axisArray != null)
			{
				int i = 0;
				if (i == 0)
				{
					AxisSetLabelControl axisL = new AxisSetLabelControl();
					Panel_SetAxis.Controls.Add(axisL);
					axisL.Location = new Point(42, 5);
				}
				while (i < _Worker._Config.axisArray.Count)
				{
					AxisSetConfigControl setC = new AxisSetConfigControl();
					Panel_SetAxis.Controls.Add((Control)setC);
					setC.Location = new Point(3, 32 + i * setC.Height + i * 5);
					setC.AxisSet = _Worker._Config.axisArray[i];
					i++;

				}
			}
		}

		private void button_AddAxis_Click(object sender, EventArgs e)
		{

			AxisConfig axis = new AxisConfig();
			axis.AxisIndex = _Worker._Config.axisArray.Count; ;
			_Worker._Config.axisArray.Add(axis);
			AxisSetConfigControl setC = new AxisSetConfigControl();
			Panel_SetAxis.Controls.Add((Control)setC);
			setC.Location = new Point(3, 32 + axis.AxisIndex * setC.Height + axis.AxisIndex * 5);
			setC.AxisSet = axis;


		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			foreach (Control con in Panel_SetAxis.Controls)
			{
				if (con is AxisSetConfigControl)
				{
					AxisSetConfigControl setA = (AxisSetConfigControl)con;
					setA.Save();
				}
			}
		}

		private void button_RemoveAxis_Click(object sender, EventArgs e)
		{
			Control[] finChild = new Control[CardManager.iMaxAxisCount];
			int i = 0;
			foreach (Control con in Panel_SetAxis.Controls)
			{
				if (con is AxisSetConfigControl)
				{
					finChild[i] = con;
					i++;
				}
			}
			if (i > 0)
			{
				AxisSetConfigControl sac = (AxisSetConfigControl)finChild[i - 1];
				Panel_SetAxis.Controls.Remove(sac);
				_Worker._Config.axisArray.Remove(sac.AxisSet);

			}
			else
			{
				MessageBoxLog.Show("轴已清空！");
			}
		}
	}
}
