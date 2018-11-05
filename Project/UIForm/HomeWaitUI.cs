using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project.UIForm
{
	public partial class HomeWaitUI : Form
	{
		private AxisConfig _Axis = null;
		public HomeWaitUI(AxisConfig axis)
		{

			InitializeComponent();
			_Axis = axis;
		}

		private void HomeWaitUI_Load(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(
				delegate
				{
					int iResult = NewCtrlCardV0.GoHome(_Axis);
					try
					{
						this.Invoke(
							(MethodInvoker)delegate
							{
								if (iResult != 0 && _Cancelled == false)
								{
									MessageBoxLog.Show("回零失败,请重新回零.");
								}
								this.Close();
							}
							);
					}
					catch (System.Exception ex)
					{

					}
				}
				);
		}
		private bool _Cancelled = false;
		private void button_Cancel_Click(object sender, EventArgs e)
		{
			_Cancelled = true;
			NewCtrlCardV0.SR_AxisEmgStop((int)_Axis.tag_MotionCardManufacturer, _Axis.CardNum, (short)_Axis.AxisNum);
		}
	}
}
