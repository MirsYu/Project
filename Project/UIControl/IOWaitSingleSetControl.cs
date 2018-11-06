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
	public partial class IOWaitSingleSetControl : UserControl
	{
		public InIOParameterPoint tag_io;

		public int tag_type;
		public IOWaitSingleSetControl()
		{
			InitializeComponent();
		}
		public void show(InIOParameterPoint _io)
		{
			tag_io = _io;
			if (_io == null)
			{
				if (label_name.Text != null)
				{
					checkBox_en.Checked = false;
				}
				return;
			}

			label_name.Text = tag_io.tag_IOName;
			if (label_name.Text == null || label_name.Text.Length < 1)
			{
				checkBox_en.Checked = false;
				return;
			}
			if (_io.tag_var)
			{
				comboBox_IO.SelectedIndex = 1;
			}
			else
			{
				comboBox_IO.SelectedIndex = 0;
			}
			textBox_WaitTime.Text = tag_io.tag_IOParameterOutTime.ToString();
			if (label_name.Text != null)
			{
				checkBox_en.Checked = true;
			}

		}

		private void comboBox_IO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_IO.SelectedIndex == 0)
			{
				tag_io.tag_var = false;
			}
			else
			{
				tag_io.tag_var = true;
			}
		}

		private void checkBox_en_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (checkBox_en.Checked == true)
				{

					tag_io.tag_IOParameterOutTime = long.Parse(textBox_WaitTime.Text);
				}
				else
				{


					label_name.Text = "请选择输出IO";
					tag_io.tag_IOName = null;

				}
			}
			catch
			{ }
		}

		private void tbxTime_TextChanged(object sender, EventArgs e)
		{
			try
			{
				tag_io.tag_IOParameterOutTime = long.Parse(textBox_WaitTime.Text);
			}
			catch
			{ }
		}
	}
}
