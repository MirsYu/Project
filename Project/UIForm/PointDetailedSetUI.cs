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
	public partial class PointDetailedSetUI : Form
	{
		public PointAggregate _PointA;
		//public DebugFrmSet debugF;
		public PointDetailedSetUI(PointAggregate pointA)
		{
			_PointA = pointA;
			InitializeComponent();

			//debugF=dbf;
		}

		public void InitForm()
		{
			if (_PointA == null)
			{
				return;
			}
			StationModule _stationM = StationManage.FindStation(_PointA.strStationName);
			if (_stationM != null)
			{
				for (int i = 0; i < _stationM.arrAxis.Count; i++)
				{
					PointDetailedSetControl queryP = new PointDetailedSetControl(_stationM.arrAxis[i]);
					queryP.PointM = _PointA.arrPoint[i];
					queryP.lblAxisName.Text = _stationM.arrAxis[i].AxisName;


					queryP.Location = new Point(3, 3 + i * queryP.Height + i * 5);
					panel1.Controls.Add(queryP);

				}
			}
		}

		private void PointDetailedSetUI_Load(object sender, EventArgs e)
		{
			InitForm();
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			foreach (Control con in panel1.Controls)
			{
				if (con is PointDetailedSetControl)
				{
					PointDetailedSetControl queryP = (PointDetailedSetControl)con;
					queryP.Save();
				}
			}
		}
	}
}
