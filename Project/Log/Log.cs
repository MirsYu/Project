using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class Log
	{
		public int tag_id;
		public string tag_info;
		public DateTime tag_dateTime;
		public string tag_OP;
		public Log(int id, string info, DateTime dateTime)
		{
			tag_id = id;
			tag_info = info;
			tag_dateTime = dateTime;
		}
	}
}
