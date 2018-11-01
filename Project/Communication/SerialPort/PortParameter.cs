using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Project
{
	public class PortParameter
	{
		public string tag_name;
		public string tag_portName;
		public int tag_baudRate;
		public Parity tag_Parity;
		public int tag_databits;
		public StopBits tag_stopBits;
		public bool tag_enable;
		/// <summary>
		/// 默认返回值
		/// </summary>
		public string tag_DefintRet;

	}
}
