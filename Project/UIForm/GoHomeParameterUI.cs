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
	public partial class GoHomeParameterUI : Form
	{
		public AxisConfig tag_AxisConfig;
		public GoHomeParameterUI()
		{
			InitializeComponent();
		}
		public GoHomeParameterUI(AxisConfig ax)
		{
			tag_AxisConfig = ax;
			InitializeComponent();
		}

		private void GoHomeParameterUI_Load(object sender, EventArgs e)
		{
			if (tag_AxisConfig != null)
			{
				GoHomeParameterControl gohome = new GoHomeParameterControl(tag_AxisConfig);
				this.Controls.Add(gohome);
			}

		}
	}
}
