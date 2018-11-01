using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	class AllData
	{
		public AllData()
		{ }

		public String SN = "";
		public String Result;
		public String StarTime = " ";
		public String EndTime = " ";
		public String SW_Version;
		public String Reserved;

		public System.Collections.ObjectModel.Collection<DataType> DataItems = new System.Collections.ObjectModel.Collection<DataType>();
	}
}
