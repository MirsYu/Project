using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project
{
	class WPDCA
	{

		public WPDCA()
		{

		}

		public void WritData(AllData data, String path)
		{
			StreamWriter writer = new StreamWriter(path);
			String strdata = "";
			String passItems = "";
			String failItems = "";

			foreach (DataType each in data.DataItems)
			{
				passItems += "," + each.Name + "," + each.Unit + "," + each.Lower + "," + each.Upper + "," + each.Value;

				if (each.Lower != "NA")
				{
					if (double.Parse(each.Value) <= double.Parse(each.Lower) || double.Parse(each.Value) >= double.Parse(each.Upper))
					{
						failItems += each.Name + ";";
					}
				}
			}

			strdata = data.SN + "," + data.Result + "," + failItems + ",," + data.StarTime + "," + data.EndTime + ","
				+ data.SW_Version + "," + data.Reserved + passItems;

			writer.Write(strdata);
			writer.Flush();
			writer.Close();
		}
		public String GetSnFromStart(String path)
		{
			StreamReader reader;
			String SN = "";

			try
			{
				if (!File.Exists(path))

				{
					return SN;
				}
				reader = new StreamReader(path);
				SN = reader.ReadToEnd();
				reader.Close();
				File.Delete(path);
			}
			catch
			{
				return SN;
			}
			return SN;
		}
	}
}
