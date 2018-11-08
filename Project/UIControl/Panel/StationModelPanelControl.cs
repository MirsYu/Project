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
	public partial class StationModelPanelControl : UserControl
	{
		public Work tag_Work;
		public StationModelPanelControl()
		{
			InitializeComponent();
		}

		private void StationModelPanelControl_Load(object sender, EventArgs e)
		{
			int offsetH = 0;
			StationTrialRunControl _stepTrialRun = null;
			if (tag_Work == null)
				return;

			foreach (object o in tag_Work.tag_workObject)
			{
				WorkBase wb = (WorkBase)o;
				if (o == null)
					return;
				_stepTrialRun = new StationTrialRunControl(o);
				this.Controls.Add(_stepTrialRun);
				_stepTrialRun.Location = new Point(0, offsetH);
				offsetH = _stepTrialRun.Size.Height + offsetH;
			}
		}
	}
}
