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
	public partial class PortSetPanelControl : UserControl
	{
		public Work tag_Work;
		public PortSetPanelControl()
		{
			InitializeComponent();
		}

		private void PortSetPanelControl_Load(object sender, EventArgs e)
		{
			int i = 0;
			if (tag_Work == null)
				return;
			groupBox_PortMain.Controls.Clear();
			foreach (PortParameter pp in tag_Work._Config.tag_PortParameterList)
			{
				_SerialPortControl ctlsp = new _SerialPortControl(pp);
				ctlsp.Location = new Point(10 + i % 2 * (ctlsp.Size.Width + 10), 10 + i / 2 * (ctlsp.Size.Height + 10));
				groupBox_PortMain.Controls.Add(ctlsp);
				i++;
			}
		}

		private void MenuItem_Add_Click(object sender, EventArgs e)
		{
			int i = 0;
			if (Global.CConst.UserLevel != Global.CConst.USER_SUPERADMIN)
			{
				MessageBoxLog.Show("无权限");
				return;
			}
			if (MessageBoxLog.Show("确定要添加最后一个？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}

			tag_Work._Config.tag_PortParameterList.Add(new PortParameter());
			PortSetPanelControl_Load(null, null);
		}

		private void MenuItem_Del_Click(object sender, EventArgs e)
		{
			if (Global.CConst.UserLevel != Global.CConst.USER_SUPERADMIN)
			{
				MessageBoxLog.Show("无权限");
				return;
			}
			int i = 0;
			if (MessageBoxLog.Show("确定要删除最后一个？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			int count = tag_Work._Config.tag_PortParameterList.Count;
			if (count > 0)
				tag_Work._Config.tag_PortParameterList.RemoveAt(count - 1);
			PortSetPanelControl_Load(null, null);
		}

		private void MenuItem_Save_Click(object sender, EventArgs e)
		{
			int i = 0;
			if (MessageBoxLog.Show("确定要保存？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			tag_Work._Config.Save();
		}

		private void PortSetPanelControl_SizeChanged(object sender, EventArgs e)
		{

		}
	}
}
