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
	public partial class GoHomeParameterControl : UserControl
	{
		public AxisConfig tag_AxisConfig;
		public GoHomeParameterControl(AxisConfig AxisConfig_)
		{
			tag_AxisConfig = AxisConfig_;
			InitializeComponent();
		}
		public GoHomeParameterControl()
		{
			InitializeComponent();
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			if (MessageBoxLog.Show("是否Save", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			try
			{
				tag_AxisConfig.intFirstFindOriginDis = double.Parse(textBox1.Text);
				tag_AxisConfig.intSecondFindOriginDis = double.Parse(textBox2.Text);
				tag_AxisConfig.intThreeFindOriginDis = double.Parse(textBox3.Text);



				if (checkBox_IoLimtPNHighEnable.Checked == false)
				{
					tag_AxisConfig.tag_IoLimtPNHighEnable = 0;
				}
				else
				{
					tag_AxisConfig.tag_IoLimtPNHighEnable = 1;
				}

				if (checkBox_Alarm.Checked == false)
				{
					tag_AxisConfig.tag_IoAlarmNHighEnable = 0;
				}
				else
				{
					tag_AxisConfig.tag_IoAlarmNHighEnable = 1;
				}



				if (checkBox_IoLimtNEnable.Checked == false)
				{
					tag_AxisConfig.tag_IoLimtNEnable = 1;
				}
				else
				{
					tag_AxisConfig.tag_IoLimtNEnable = 0;
				}
				if (checkBox_IoLimtPEnable.Checked == false)
				{
					tag_AxisConfig.tag_IoLimtPEnable = 1;
				}
				else
				{
					tag_AxisConfig.tag_IoLimtPEnable = 0;
				}

				tag_AxisConfig.tag_CC_value = comboBox_CC_value.SelectedIndex;
				tag_AxisConfig.tag_CC_logic = comboBox_CC_logic.SelectedIndex;
				tag_AxisConfig.tag_dir_logic = comboBox_dir_logic.SelectedIndex;
			}
			catch
			{ }
		}

		private void GoHomeParameterControl_Load(object sender, EventArgs e)
		{
			textBox1.Text = tag_AxisConfig.intFirstFindOriginDis.ToString();
			textBox2.Text = tag_AxisConfig.intSecondFindOriginDis.ToString();
			textBox3.Text = tag_AxisConfig.intThreeFindOriginDis.ToString();
			if (tag_AxisConfig.tag_IoLimtPEnable == 0)
			{
				checkBox_IoLimtPEnable.Checked = true;//tag_AxisConfig.tag_IoLimtPEnable;
			}
			else
			{
				checkBox_IoLimtPEnable.Checked = false;
			}

			if (tag_AxisConfig.tag_IoAlarmNHighEnable == 0)
			{
				checkBox_Alarm.Checked = false;//tag_AxisConfig.tag_IoLimtPEnable;
			}
			else
			{
				checkBox_Alarm.Checked = true;
			}


			if (tag_AxisConfig.tag_IoLimtNEnable == 0)
			{
				checkBox_IoLimtNEnable.Checked = true;//tag_AxisConfig.tag_IoLimtPEnable;
			}
			else
			{
				checkBox_IoLimtNEnable.Checked = false;
			}
			if (tag_AxisConfig.tag_IoLimtPNHighEnable == 0)
			{
				checkBox_IoLimtPNHighEnable.Checked = false;//tag_AxisConfig.tag_IoLimtPEnable;
			}
			else
			{
				checkBox_IoLimtPNHighEnable.Checked = true;
			}

			comboBox_CC_value.SelectedIndex = tag_AxisConfig.tag_CC_value;
			comboBox_CC_logic.SelectedIndex = tag_AxisConfig.tag_CC_logic;
			comboBox_dir_logic.SelectedIndex = tag_AxisConfig.tag_dir_logic;

		}
	}
}
