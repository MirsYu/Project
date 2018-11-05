using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project
{
	public partial class WaitUI : Form
	{
		public delegate short delegate_Exe(object o);

		public delegate_Exe tag_delegate_Exe;
		public delegate_Exe tag_delegate_End;
		public object tag_o;
		public WaitUI(delegate_Exe exe, object o)
		{
			tag_delegate_Exe = exe;
			tag_o = o;
			InitializeComponent();
		}
		public WaitUI(delegate_Exe exe, delegate_Exe end, object o)
		{
			tag_delegate_Exe = exe;
			tag_o = o;
			tag_delegate_End = end;
			InitializeComponent();
		}
		private void FrmWait_Load(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(
				 delegate
				 {

					 try
					 {
						 short ret = tag_delegate_Exe(tag_o);
						 this.Invoke(
							 (MethodInvoker)delegate
							 {

								 if (tag_delegate_End != null)
								 {

									 tag_delegate_End(tag_o);
								 }
								 else
								 {
									 if (ret != 0)
									 {
										 MessageBoxLog.Show("操作失败");
									 }
								 }
								 this.Close();

							 }
							 );
					 }
					 catch (System.Exception ex)
					 {
						 LogOutControl.OutLog(ex.Message, 0);
					 }
				 }
				 );
		}
		private bool _Cancelled = false;
		private void button_Cancel_Click(object sender, EventArgs e)
		{
			StationManage.StopAllAxis();
			Global.WorkVar.tag_IsExit = 1;
			_Cancelled = true;
		}
	}
}
