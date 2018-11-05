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
	public partial class DebugOffsetControl : UserControl
	{
		public DebugOffsetControl()
		{
			InitializeComponent();
		}
		public Work tag_work;

		private void DebugOffsetControl_Load(object sender, EventArgs e)
		{
			if (tag_work == null)
			{
				return;
			}
			textBox_OffsetTest.Text = Convert.ToDecimal(tag_work._Config.tag_PrivateSave.fTestCYTime).ToString();

		}

		private void button1_Save_Click(object sender, EventArgs e)
		{
			if (MessageBoxLog.Show("确定要保存数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				try
				{
					tag_work._Config.tag_PrivateSave.fTestCYTime = Convert.ToDouble(textBox_OffsetTest.Text);
					tag_work._Config.Save();
				}
				catch (Exception mess)
				{
					LogOutControl.OutLog(mess.Message, 0);
				}
			}
		}
	}
}
