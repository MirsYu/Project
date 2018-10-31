using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class PDCA
	{
		private static string path;
		private static WPDCA log;
		private string tag_index = "";
		public PDCA(string index)
		{

			path = "D:\\DropBox\\Start" + index + ".txt";
			tag_index = index;
			;
			log = new WPDCA();
		}

		public string GetSn()
		{
			return log.GetSnFromStart(path);
		}

		//     public  void WriteData(string sn, double Adc, int var)
		public void WriteData(string sn, int var)
		{
			AllData allData = new AllData();

			/*   DataType powerType = new DataType();
                 powerType.Name = "Adc";
                 powerType.Unit = "V";
                 powerType.Lower = "0";
                 powerType.Upper = "5.0";
                 powerType.Value = Adc.ToString();
                 allData.DataItems.Add(powerType);
             */

			DataType distanceType = new DataType();
			distanceType.Name = "var";
			distanceType.Unit = "bool";
			distanceType.Lower = "NA";
			distanceType.Upper = "NA";
			distanceType.Value = var.ToString();
			allData.DataItems.Add(distanceType);

			allData.SN = sn;
			allData.Reserved = "Reserved";
			allData.SW_Version = "1.0.0.1";
			allData.Result = (var == 1) ? "PASS" : "FAIL";

			string path = "D:\\DropBox\\Done" + tag_index + ".txt";
			log.WritData(allData, path);
		}
	}
}

