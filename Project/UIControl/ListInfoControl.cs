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
	public partial class ListInfoControl : UserControl
	{
		public ListInfoControl()
		{
			InitializeComponent();
		}
		private List<int> ErrorMessgIndex = new List<int>(); //记录错误信息的索引
		private string StatusMessage = "status";
		private string ErrorMessage = "err";
		private string LastMesg = "";  //记录上次信息
		private int MaxCnt = 200;  //记录的最大项数

		public int MaxListItem
		{
			set
			{
				MaxCnt = value;
			}
			get
			{
				return MaxCnt;
			}

		}
		//正常运行信息显示
		public string LastStatusMessage
		{

			set
			{
				StatusMessage = value;
				AddInfon(StatusMessage, false);
			}
		}
		//错误信息显示
		public string LastErrorMessage
		{
			set
			{
				ErrorMessage = value;
				AddInfon(ErrorMessage, true);
			}

		}
		private delegate void mydelegate(string messg, bool isError);
		private void ListBoxAddMessg(string messg, bool isError)
		{
			if (listBoxInfon.Items.Count >= MaxCnt)
			{
				listBoxInfon.Items.Clear();
				ErrorMessgIndex.Clear();
			}
			if (isError)
			{
				ErrorMessgIndex.Add(listBoxInfon.Items.Count);

			}
			string str = DateTime.Now.ToString("HH:mm:ss") + "  " + messg;
			listBoxInfon.Items.Add(str);
			listBoxInfon.TopIndex = listBoxInfon.Items.Count - 1;
			if (isError)
			{
				RecordDatalog("Alarm: " + messg);
			}


		}
		//记录运行的数据     
		private void RecordDatalog(string str)
		{
			string path = Global.CConst.SAVE_DATA_PATH + "\\RunInfon\\" + "AlarmLog";
			string filename = "log";
			CFile.WriteTxtLog(str, filename, path);
		}
		private void AddInfon(string messg, bool isError)
		{
			try
			{
				if (!LastMesg.Equals(messg))
				{
					lock (this)  //锁住下面的代码，执行完后才能被访问
					{
						this.Invoke(new mydelegate(ListBoxAddMessg), messg, isError);
					}
				}
				LastMesg = messg;

			}
			catch (Exception )
			{

			}

		}
		//每当Listbox添加项的时候该事件发生，遍历里面所有项的颜色
		private void listBoxInfon_DrawItem(object sender, DrawItemEventArgs e)
		{
			Brush FontBrush = null;
			ListBox listbox = sender as ListBox;
			try
			{
				if (e.Index > -1)
				{
					FontBrush = Brushes.Black;
					for (int i = 0; i < ErrorMessgIndex.Count; i++)
					{
						if (e.Index == ErrorMessgIndex[i])
						{
							FontBrush = Brushes.Red;
							break;
						}
					}
					e.DrawBackground();
					e.Graphics.DrawString(listbox.Items[e.Index].ToString(), e.Font, FontBrush, e.Bounds);
					e.DrawFocusRectangle();
				}
			}
			catch (Exception )
			{
			}
		}

		private void listBoxInfon_DoubleClick(object sender, EventArgs e)
		{
			listBoxInfon.Items.Clear();
			ErrorMessgIndex.Clear();
			LastMesg = "";  //记录上次信息
		}
	}
}
