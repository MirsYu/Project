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
	public partial class NetSocketControl : UserControl
	{
		public delegate void delegate_UIShow(string outStr);
		public IPConfig tag_IPAdrr;
		public SocketClient tag_SocketClient;
		public void SocketClient(IPConfig _IPAdrr)
		{
			tag_IPAdrr = _IPAdrr;
		}

		/// <summary>
		/// 初始化
		/// </summary>
		public NetSocketControl(SocketClient sc)
		{
			tag_SocketClient = sc;
			tag_IPAdrr = tag_SocketClient.tag_IPConfig;
			InitializeComponent();

		}
		private void NetSocketControl_Load(object sender, EventArgs e)
		{
			textBox_Ip.Text = tag_IPAdrr.tag_ip;
			textBox_port.Text = tag_IPAdrr.tag_port.ToString();
			txtName.Text = tag_IPAdrr.tag_name;

			checkBox_Enable.Checked = tag_IPAdrr.tag_Enable;
			textBox3.Text = tag_IPAdrr.tag_defineRet;
		}
		private void button_Save_Click(object sender, EventArgs e)
		{
			try
			{
				tag_IPAdrr.tag_name = txtName.Text;
				tag_IPAdrr.tag_ip = textBox_Ip.Text;
				tag_IPAdrr.tag_port = int.Parse(textBox_port.Text);
				tag_IPAdrr.tag_Enable = checkBox_Enable.Checked;
				tag_IPAdrr.tag_defineRet = textBox3.Text;
			}
			catch (Exception mes)
			{

			}
		}
		void UIShow(string outStr)
		{
			textBox2.Text = textBox2.Text + outStr;
		}
		void delegate_SocketClientRead(string outStr)
		{

			if (this.textBox2.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
			{

				delegate_UIShow d = new delegate_UIShow(UIShow);
				this.textBox1.Invoke(d, new object[] { outStr });
			}
			else
			{
				textBox2.Text = textBox2.Text + outStr;
			}
		}
		private void button_Send_Click(object sender, EventArgs e)
		{

			string t = tag_SocketClient.send(textBox1.Text, 0, delegate_SocketClientRead);
			textBox2.Text = textBox2.Text + t;
		}

		private void button_Connect_Click(object sender, EventArgs e)
		{
			if (tag_SocketClient.tag_Socket == null || !tag_SocketClient.tag_Socket.Connected)
			{
				tag_SocketClient.ConnectThread();
				if (tag_SocketClient.tag_Socket.Connected)
				{
					button_Connect.Text = "关闭";
				}
			}
			else
				if (tag_SocketClient.tag_Socket.Connected)
			{
				tag_SocketClient.tag_Socket.Close();
				button_Connect.Text = "连接";
			}
		}
	}
}
