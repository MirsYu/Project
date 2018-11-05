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
	public partial class WebControl : UserControl
	{
		public WebControl()
		{
			InitializeComponent();
		}

		public void RefreshURL(string URL)
		{
			this.webBrowser_NG.Navigate(URL);
			this.webBrowser_NG.Refresh();
		}
	}
}
