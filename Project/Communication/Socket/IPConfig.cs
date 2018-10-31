using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class IPConfig
	{
		public string tag_name = "Net";
		public string tag_ip = "127.0.0.1";
		public int tag_port = 10000;
		/// <summary>
		/// 是否启用相机
		/// </summary>
		public bool tag_Enable;
		/// <summary>
		/// 默认返回值，当不启用相机时候的返回值
		/// </summary>
		public string tag_defineRet;
	}
}
