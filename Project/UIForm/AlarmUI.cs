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
	public partial class AlarmUI : Form
	{
		FrameUI frameUI = new FrameUI();
		public AlarmUI()
		{
			InitializeComponent();
		}

		private void AlarmUI_Load(object sender, EventArgs e)
		{

			this.dataGridView1.Columns[0].HeaderCell.Value = "时间";
			this.dataGridView1.Columns[1].HeaderCell.Value = "类型";
			this.dataGridView1.Columns[2].HeaderCell.Value = "消息";

		}

		private void button_Find_Click(object sender, EventArgs e)
		{
			List<Log> log = LogOutControl.tag_logdatabase.Get(dateTimePicker_begin.Value, dateTimePicker_end.Value);

			this.dataGridView1.Rows.Clear();
			foreach (Log l in log)
			{
				this.dataGridView1.Rows.Add(l.tag_dateTime, l.tag_id, l.tag_info);
			}
		}
	}
}
