using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class LogDataBase
	{
		public LogManage tag_Log;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="info"></param>
		/// <param name="dateTime"></param>
		public void addLog(int id, string info, DateTime dateTime)
		{
			if (tag_Log == null)
			{
				tag_Log = LogManage.Load();
			}
			if (tag_Log.tag_logList.Count > 0 && tag_Log.tag_logList[0].tag_info == info)
			{
				tag_Log.tag_logList.RemoveAt(0);
			}
			if (tag_Log.tag_logList.Count > 1014 * 1024)
			{
				tag_Log.tag_logList.RemoveAt(tag_Log.tag_logList.Count - 1);
			}

			tag_Log.tag_logList.Insert(0, new Log(id, info, dateTime));
			tag_Log.Save();
		}
		public List<Log> Get(int id, int count)
		{
			List<Log> ret = new List<Log>();
			if (tag_Log == null)
			{
				tag_Log = LogManage.Load();
			}
			for (int i = 0; i < count && i < tag_Log.tag_logList.Count; i++)
			{
				if (tag_Log.tag_logList[i].tag_id == id)
				{
					ret.Add(tag_Log.tag_logList[i]);
				}
			}
			return ret;
		}
		public List<Log> Get(DateTime BegindateTime, DateTime EndindateTime)
		{
			List<Log> ret = new List<Log>();
			if (tag_Log == null)
			{
				tag_Log = LogManage.Load();
			}
			for (int i = 0; i < tag_Log.tag_logList.Count; i++)
			{
				if (tag_Log.tag_logList[i].tag_dateTime >= BegindateTime && tag_Log.tag_logList[i].tag_dateTime <= EndindateTime)
				{
					ret.Add(tag_Log.tag_logList[i]);
				}
			}
			return ret;
		}
	}
}
