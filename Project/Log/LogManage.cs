using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
	public class LogManage : BinarySerializer
	{
		public List<Log> tag_logList;
		public LogManage()
		{

		}
		protected static string GetSetPath(string filename)
		{
			string dir = Path.Combine(Application.StartupPath, "Data");
			if (Directory.Exists(dir) == false)
			{
				Directory.CreateDirectory(dir);
			}
			return Path.Combine(dir, filename);
		}
		public bool Save()
		{
			return this.Save(GetSetPath("log.config"));
		}
		public static LogManage Load()
		{
			LogManage log = Load(GetSetPath("log.config")) as LogManage;
			if (log == null)
			{
				log = new LogManage();
				log.tag_logList = new List<Log>();
			}
			return log;
		}
	}
}
