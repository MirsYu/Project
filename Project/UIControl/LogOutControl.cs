using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Project
{
	public delegate void delegate_FormMain_Log(string info, int type);

	/// <summary>
	/// 日志管理
	/// </summary>
	public partial class LogOutControl : UserControl
	{
		public static string tag_upstring;
		/// <summary>
		/// ui定时显示
		/// </summary>
		private Timer tag_ShowLogTimer;//
															/// <summary>
															/// 
															/// </summary>
		private static ArrayList tag_arrMsg = new ArrayList();
		/// <summary>
		/// 锁
		/// </summary>
		public static object tag_locker;
		public static int is_showMsg = 10;
		public static string tag_upmsg = null;

		public static LogDataBase tag_logdatabase = new LogDataBase();
		public LogOutControl()
		{
			InitializeComponent();
			tag_locker = new object();
			tag_ShowLogTimer = new System.Windows.Forms.Timer();
			tag_ShowLogTimer.Tick += new EventHandler(LogOutControl_Show);
			tag_ShowLogTimer.Interval = 1000;
			tag_ShowLogTimer.Start();
		}

		public void dataGridViewShow(List<Log> log, DataGridView daview)
		{

			int i = 0;
			int cunt = log.Count;
			while (i < cunt)
			{
				//   daview.ForeColor =
				daview[0, i].Value = log[i].tag_dateTime.ToString();
				daview[1, i].Value = log[i].tag_info.ToString();
				i++;
				;
			}
		}

		/// <summary>
		/// 定时显示串 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogOutControl_Show(object sender, EventArgs e)
		{
			try
			{
				if (tag_logdatabase == null)
					return;
				if (is_showMsg > 0)
				{
					is_showMsg--; ;
					dataGridView_Alarm.ForeColor = Color.Red;
					List<Log> listlog = tag_logdatabase.Get(0, 100);
					dataGridView_Alarm.ColumnCount = 2;
					dataGridView_Alarm.RowCount = 200;
					dataGridViewShow(listlog, dataGridView_Alarm);//0为报警
					listlog = tag_logdatabase.Get(1, 100);
					dataGridView_Step.ColumnCount = 2;
					dataGridView_Step.RowCount = 200;
					dataGridViewShow(listlog, dataGridView_Step);//1为运行信息
				}
			}
			catch (Exception)
			{

			}
		}
		/// <summary>
		/// 输出日志 ErrorType 0为红色异常信息，1为黑色运行信息
		/// </summary>
		/// <param name="Msg"></param>
		/// <param name="ErrorType"></param>
		public static void OutLog(string Msg, int ErrorType)
		{
			try
			{
				if (Msg == tag_upmsg)
					return;
				is_showMsg = 10;
				tag_logdatabase.addLog(ErrorType, Msg, DateTime.Now);
			}
			catch (Exception ex)
			{
				string str = ex.Message;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogOutControl_Load(object sender, EventArgs e)
		{

		}
	}
}
