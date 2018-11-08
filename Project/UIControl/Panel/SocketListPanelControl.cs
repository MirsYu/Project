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
	public partial class SocketListPanelControl : UserControl
	{
		public Work tag_Work;
		public SocketListPanelControl()
		{
			InitializeComponent();
		}

		private void MenuItem_Del_Click(object sender, EventArgs e)
		{
			if (Global.CConst.UserLevel != Global.CConst.USER_SUPERADMIN)
			{
				MessageBoxLog.Show("无权限");
				return;
			}
			if (MessageBoxLog.Show("确定要删除最后一个？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			int count = tag_Work._Config.tag_IPConfigList.Count;
			if (count > 0)
				tag_Work._Config.tag_IPConfigList.RemoveAt(count - 1);
			SocketListPanelControl_Load(null, null);
		}

		private void MenuItem_Add_Click(object sender, EventArgs e)
		{
			if (Global.CConst.UserLevel != Global.CConst.USER_SUPERADMIN)
			{
				MessageBoxLog.Show("无权限");
				return;
			}
			if (MessageBoxLog.Show("确定要添加最后一个？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}

			tag_Work._Config.tag_IPConfigList.Add(new IPConfig()); 
			SocketListPanelControl_Load(null, null);
		}

		private void MenuItem_Save_Click(object sender, EventArgs e)
		{

			if (MessageBoxLog.Show("确定要保存？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			tag_Work._Config.Save();
		}

		private void SocketListPanelControl_Load(object sender, EventArgs e)
		{
			int i = 0;
			if (tag_Work == null)
				return;
			this.Controls.Clear();
			int j = 0;
			foreach (SocketClient pp in tag_Work.tag_SocketClient)
			{
				NetSocketControl ctlsp = new NetSocketControl(pp);
				ctlsp.Location = new Point(10 + j % 2 * ctlsp.Size.Width, 10 + (i) / 2 * (ctlsp.Size.Height + 10));
				this.Controls.Add(ctlsp);

				j++;
				i++;

			}
		}
	}
}
