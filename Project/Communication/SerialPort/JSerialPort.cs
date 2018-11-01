using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project
{
	public class JSerialPort
	{
		public PortParameter tag_PortParameter;
		public SerialPort tag_SerialPort;
		byte[] tag_readBuffer = new byte[256];
		int tag_readBufferLen = 0;
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="portName">端口名</param>
		/// <param name="baudRate">波特率</param>
		public JSerialPort(string Name, PortParameter _PortParameter)
		{
			if (Name != null)
				_PortParameter.tag_name = Name;
			tag_PortParameter = _PortParameter;

		}
		// 摘要:
		//     表示将处理 System.IO.Ports.SerialPort 对象的 System.IO.Ports.SerialPort.DataReceived
		//     事件的方法。
		//
		// 参数:
		//   sender:
		//     事件的发送者，它是 System.IO.Ports.SerialPort 对象。
		//
		//   e:
		//     包含事件数据的 System.IO.Ports.SerialDataReceivedEventArgs 对象。
		public void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				int count = tag_SerialPort.Read(tag_readBuffer, tag_readBufferLen, 256 - tag_readBufferLen);
				tag_readBufferLen = tag_readBufferLen + count;

			}
			catch
			{ }
		}
		public void open()
		{
			try
			{
				if (tag_SerialPort == null)
					tag_SerialPort = new SerialPort(tag_PortParameter.tag_portName, tag_PortParameter.tag_baudRate, tag_PortParameter.tag_Parity, tag_PortParameter.tag_databits, tag_PortParameter.tag_stopBits);
				if (!tag_SerialPort.IsOpen)
					tag_SerialPort.Open();
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sendstr"></param>
		/// <returns></returns>
		public string sendCommand(string sendstr, int outTime)
		{
			try
			{
				if (!tag_PortParameter.tag_enable)
				{
					char[] ReadBuffer = new char[1024];


					if (tag_SerialPort == null)
						tag_SerialPort = new SerialPort(tag_PortParameter.tag_portName, tag_PortParameter.tag_baudRate, tag_PortParameter.tag_Parity, tag_PortParameter.tag_databits, tag_PortParameter.tag_stopBits);
					if (!tag_SerialPort.IsOpen)
						tag_SerialPort.Open();
					tag_SerialPort.ReadTimeout = outTime;
					tag_SerialPort.WriteTimeout = outTime;
					tag_SerialPort.Write(sendstr);
					string retstr = tag_SerialPort.ReadLine();

					return retstr;

				}
				else
				{
					return tag_PortParameter.tag_DefintRet;
				}
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
				return "";
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sendstr"></param>
		/// <returns></returns>
		public byte[] sendCommand(byte[] Buffer, int bufferLen, int outTime)
		{
			byte[] ReadBuffer = new byte[128];
			try
			{
				if (!tag_PortParameter.tag_enable)
				{



					if (tag_SerialPort == null)
						tag_SerialPort = new SerialPort(tag_PortParameter.tag_portName, tag_PortParameter.tag_baudRate, tag_PortParameter.tag_Parity, tag_PortParameter.tag_databits, tag_PortParameter.tag_stopBits);
					if (!tag_SerialPort.IsOpen)
						tag_SerialPort.Open();
					tag_SerialPort.ReadTimeout = outTime;
					tag_SerialPort.WriteTimeout = outTime;
					tag_SerialPort.Write(Buffer, 0, bufferLen);
					Thread.Sleep(100);
					tag_SerialPort.Read(ReadBuffer, 0, 128);

					return ReadBuffer;

				}
				else
				{
					return ReadBuffer;
				}
			}
			catch (Exception mess)
			{
				LogOutControl.OutLog(mess.Message, 0);
				return ReadBuffer;
			}
		}
	}
}
