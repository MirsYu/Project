using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Project.Global;

namespace Project
{
	public static class CFile
	{

		/// <summary>
		/// 删除指定目录下所有超过保存时间的文件
		/// </summary>
		/// <param name="path"></param> 目录
		/// <param name="savetime"></param> 保存时间（天数）
		public static void DelectFile(string path, double savetime)
		{
			string[] DirectoryNames = Directory.GetDirectories(path);
			string[] FileNames = Directory.GetFiles(path);
			for (int i = 0; i < FileNames.Count(); i++)
			{
				if ((DateTime.Now - File.GetCreationTime(FileNames[i])).TotalDays > savetime)
				{

					File.Delete(FileNames[i]);

				}

			}
			for (int j = 0; j < DirectoryNames.Count(); j++)
			{
				DelectFile(DirectoryNames[j], savetime);
			}

		}

		/// <summary>
		/// 读取指定目录下所有保存时间在指定时间以内的文件，并显示在表格
		/// </summary>
		/// <param name="path"></param> 指定目录
		/// <param name="savetime"></param> 指定时间(天数)
		/// <param name="datagrid"></param>指定表格
		public static void ReadCsvDateToDataGridView(string path, double savetime, DataGridView datagrid)
		{
			List<string> FileNames = new List<string>();
			FileNames = FindFile(path, savetime, FileNames);
			datagrid.Rows.Clear();
			try
			{
				for (int i = 0; i < FileNames.Count(); i++)
				{
					StreamReader read = new StreamReader(FileNames[i], Encoding.Default);
					string strcontent = read.ReadToEnd();
					read.Close();
					string[] data = System.Text.RegularExpressions.Regex.Split(strcontent, "\r\n");
					for (int j = 1; j < data.Count(); j++)
					{
						if (data[j] != "")
						{
							string[] mydata = data[j].Split(',');
							bool HasData = false;
							for (int h = 0; h < mydata.Count(); h++)
							{
								if (mydata[h] != "")
								{
									HasData = true;
								}
							}
							if (HasData)
							{
								datagrid.Rows.Add(mydata);
							}
						}
					}

				}
			}
			catch (System.Exception ex)
			{
				HintMessageInfo.MessageTopMost("csv文件操作出错:" + ex.Message);
			}
		}

		/// <summary>
		/// 查找目录下所有保存时间在指定时间以内的文件
		/// </summary>
		/// <param name="path"></param> 目录
		/// <param name="savetime"></param> 保存时间（天数）
		/// <param name="filename"></param>
		/// <returns></returns>
		public static List<string> FindFile(string path, double savetime, List<string> filename)
		{
			string[] DirectoryNames = Directory.GetDirectories(path);
			string[] FileNames = Directory.GetFiles(path);
			for (int i = 0; i < FileNames.Count(); i++)
			{
				if ((DateTime.Now - File.GetCreationTime(FileNames[i])).TotalDays <= savetime)
				{
					filename.Add(FileNames[i]);
				}

			}
			for (int j = 0; j < DirectoryNames.Count(); j++)
			{
				FindFile(DirectoryNames[j], savetime, filename); //递归调用
			}
			return filename;

		}

		/// <summary>
		/// 查找目录下所有在指定时间段(天数)以内的文件
		/// </summary>
		/// <param name="path"></param>  目录
		/// <param name="startime"></param> 起始时间
		/// <param name="endtime"></param> 结束时间
		/// <param name="filename"></param>
		/// <returns></returns>
		public static List<string> FindFile(string path, DateTime startime, DateTime endtime, List<string> filename)
		{
			if ((startime - endtime).TotalDays > 0)
			{
				HintMessageInfo.MessageTopMost("查询时间设置错误");
				return filename;
			}
			string[] DirectoryNames = Directory.GetDirectories(path);
			string[] FileNames = Directory.GetFiles(path);
			for (int i = 0; i < FileNames.Count(); i++)
			{
				if ((File.GetCreationTime(FileNames[i]) - startime).TotalDays >= 0 && (endtime - File.GetCreationTime(FileNames[i])).TotalDays >= 0)
				{
					filename.Add(FileNames[i]);
				}

			}
			for (int j = 0; j < DirectoryNames.Count(); j++)
			{
				FindFile(DirectoryNames[j], startime, endtime, filename); //递归调用
			}
			return filename;

		}

		/// <summary>
		/// 查找指定路径下的所有文件
		/// </summary>
		/// <param name="path"></param>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static List<string> FindFile(string path, List<string> filename)
		{
			string[] DirectoryNames = Directory.GetDirectories(path);
			string[] FileNames = Directory.GetFiles(path);
			for (int i = 0; i < FileNames.Count(); i++)
			{
				filename.Add(FileNames[i]);
			}
			for (int j = 0; j < DirectoryNames.Count(); j++)
			{
				FindFile(DirectoryNames[j], filename); //递归调用
			}
			return filename;

		}

		/// <summary>
		/// 读取指定路径的CSV文件中的内容
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static List<string> GetCsvInfon(string filename)
		{
			List<string> mydata = new List<string>();
			try
			{
				StreamReader read = new StreamReader(filename, Encoding.Default);
				string strcontent = read.ReadToEnd();
				read.Close();
				string[] data = System.Text.RegularExpressions.Regex.Split(strcontent, "\r\n");
				for (int j = 1; j < data.Count(); j++)
				{
					if (data[j] != "")
					{
						mydata.Add(data[j]);
					}
				}
			}
			catch (Exception ex)
			{
				HintMessageInfo.MessageTopMost("csv文件操作出错:" + ex.Message);
			}

			return mydata;
		}


		/// <summary>
		/// 从指定的CSV文件中获取指定信息的数组
		/// </summary>
		/// <param name="filename"></param> 指定的CSV文件名 
		/// <param name="mesg"></param>指定信息
		/// <returns></returns>  返回数组元素为“”则引发了异常
		public static string[] GetAlarmMesgArray(string filename, string mesg)
		{
			List<string> mydata = new List<string>();
			string[] array = new string[100];
			try
			{
				StreamReader read = new StreamReader(filename, Encoding.Default);
				string strcontent = read.ReadToEnd();
				read.Close();
				string[] data = System.Text.RegularExpressions.Regex.Split(strcontent, "\r\n");
				for (int j = 1; j < data.Count(); j++)
				{
					if (data[j] != "")
					{
						mydata.Add(data[j]);
					}
				}
				for (int i = 0; i < mydata.Count(); i++)
				{
					string[] mess = mydata[i].Split(',');
					for (int h = 0; h < mess.Count(); h++)
					{
						if (mess[h].Equals(mesg))
						{
							return mess;
						}
					}

				}

			}
			catch (Exception ex)
			{
				HintMessageInfo.MessageTopMost("csv文件操作出错:" + ex.Message);
			}

			return array;

		}

		/// <summary>
		/// 将Excel表格中的内容读出到datagridview显示
		/// </summary>
		/// <param name="filename"></param> 文件的完整路径
		/// <param name="datagrid"></param> 要显示的表格
		public static void ReadExcelToDatagridview(string filename, DataGridView datagrid)
		{

			DataSet ds;
			string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties='Excel 12.0;HDR=YES';data source=" + filename; //excel 2007版
			OleDbConnection myConn = new OleDbConnection(strCon);
			string strCom = " SELECT * FROM [Sheet1$]";
			myConn.Open();
			OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
			ds = new DataSet();
			myCommand.Fill(ds);
			myConn.Close();
			datagrid.DataSource = ds.Tables[0];

		}

		//获取在指定时间的最近几天的日期
		public static string[] GetLastDate(DateTime datetime, int days)
		{
			string[] date = new string[days];
			for (int i = days; i > 0; i--)
			{
				date[days - i] = datetime.AddDays(1 - i).ToString("MM-dd");
			}

			return date;

		}

		/// <summary>
		/// 将指定的DataGridView表格中的内容写到指定路径，指定文件名下的CSV表格
		/// </summary>
		/// <param name="grid"></param> 指定的DataGridView
		/// <param name="filename"></param> 指定文件名
		/// <param name="path"></param> 指定路径
		public static void WriteGridToCsv(DataGridView grid, string filename, string path)
		{
			int cnt = grid.Rows.Count;
			int colums = grid.Columns.Count;
			string title = null;
			for (int h = 0; h < colums; h++)
			{
				string ColumValue = (string)grid.Columns[h].HeaderText;
				if (ColumValue != null)
				{
					title = title + ColumValue + ",";
				}

			}
			for (int i = 0; i < cnt; i++)
			{
				string str = null;
				bool hasdata = false;
				int num = grid.Rows[i].Cells.Count;
				for (int j = 0; j < num; j++)
				{
					string CellValue = (string)grid.Rows[i].Cells[j].Value;
					if (CellValue != null && CellValue != "")
					{
						hasdata = true;
					}
					str = str + CellValue + ",";
				}
				if (hasdata)
				{
					WriteCSVDate(str, filename, path, title);
				}

			}

		}

		//write csv log
		public static void WriteCSVDate(string WriteString, string fileName, string path, string title)
		{
			bool bfirst = false;
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			string strFile = path + "\\" + DateTime.Now.ToString("yyyyMMdd") + fileName + ".csv";
			if (File.Exists(strFile) == false)
			{
				bfirst = true;
			}

			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				if (bfirst)
				{
					swf.WriteLine(title);
				}
				swf.WriteLine(WriteString);
				swf.Close();
			}
			catch (System.Exception ex)
			{
				HintMessageInfo.MessageTopMost("csv文件操作出错:" + ex.Message);
			}
		}


		//读取注册表的值
		public static string GetRegistryValue(string foldname, string name)
		{
			string str = "";
			try
			{
				RegistryKey cu = Registry.CurrentUser;
				RegistryKey rk = cu.CreateSubKey(foldname);
				str = (String)rk.GetValue(name, "", RegistryValueOptions.DoNotExpandEnvironmentNames);
				rk.Close();
			}
			catch (Exception )
			{

			}
			return str;

		}

		//保存到注册表
		public static bool SaveRegistryValue(string foldname, string name, string value)
		{
			try
			{
				RegistryKey cu = Registry.CurrentUser; //注册表基项目录
				RegistryKey rk = cu.CreateSubKey(foldname); //创建或读取子文件夹
				rk.SetValue(name, value, RegistryValueKind.String);
				rk.Close();
				return true;
			}
			catch (Exception )
			{
				return false;
			}

		}

		//写Txt LOG
		public static void WriteTxtLog(string WriteString, string fileName, string path)
		{
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			string strFile = path + "\\" + DateTime.Now.ToString("yyMMdd") + fileName + ".txt";
			if (File.Exists(strFile) == false)
			{//可用于第一行的写标题操作

			}
			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				swf.Write(DateTime.Now.ToString("yyMMdd-") + DateTime.Now.ToString("HH:mm:ss") + " " + WriteString + "\r\n");
				swf.Close();
			}
			catch
			{

			}
		}


		//write csv log
		public static void WriteCSVDate(string WriteString, int checkNum, bool bAppendEnter = true, string path = CConst.SAVE_DATA_PATH)
		{
			//path = Application.StartupPath + "\\Data";
			if (checkNum == 1)
			{
				CConst.Save_Folder_Name = "\\CamData1";
			}
			else if (checkNum == 2)
			{
				CConst.Save_Folder_Name = "\\CamData2";
			}
			else if (checkNum == 3)
			{
				CConst.Save_Folder_Name = "\\CamData3";
			}
			else if (checkNum == 4)
			{
				CConst.Save_Folder_Name = "\\CPK";
			}
			else if (checkNum == 5)
			{
				CConst.Save_Folder_Name = "\\PRODUCT";
			}
			path = path + CConst.Save_Folder_Name;
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			StreamWriter swf = null;
			string strFile = path + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
			if (File.Exists(strFile) == false)
			{
				swf = new StreamWriter(strFile, true, Encoding.Default);
				if (checkNum == 3 || checkNum == 2)
				{
					swf.Write("时间,指令,数量,穴3,穴6,穴9,穴12,穴2,穴5,穴8,穴11,穴1,穴4,穴7,穴10,NO1_1,NO1_2,NO1_3,NO1_4,NO1_5,NO2_1,NO2_2,NO2_3,NO2_4,NO2_5,NO3_1,NO3_2,NO3_3,NO3_4,NO3_5,NO4_1,NO4_2,NO4_3,NO4_4,NO4_5,NO5_1,NO5_2,NO5_3,NO5_4,NO5_5,NO6_1,NO6_2,NO6_3,NO6_4,NO6_5,NO7_1,NO7_2,NO7_3,NO7_4,NO7_5,NO8_1,NO8_2,NO8_3,NO8_4,NO8_5,NO9_1,NO9_2,NO9_3,NO9_4,NO9_5,NO10_1,NO10_2,NO10_3,NO10_4,NO10_5,NO11_1,NO11_2,NO11_3,NO11_4,NO11_5,NO12_1,NO12_2,NO12_3,NO12_4,NO12_5,\r\n");
				}
				else if (checkNum == 4 || checkNum == 5)
				{
					swf.Write("Time,Carrier_SN,Cavity,Machine_ID,MLB_SN,Pin1_Gap_X,Pin1_Gap_Y,Pin2_Gap_X,Pin2_Gap_Y,Angle,Press_Force,Press_Time,Tossing,Cycle_Time,Flex_VENDOR,CM_VENDOR,Operator_ID,Mode,TestSeriesID,Priority");

				}

			}

			try
			{
				if (swf == null)
				{
					swf = new StreamWriter(strFile, true, Encoding.Default);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
			}
			catch (System.Exception ex)
			{
				FormMessage.MesssageShowOnce("csv文件操作出错:" + ex.Message + " 请不要在运行中打开csv文件", FormMessage.MSG.CSV);
				RewrteCSV(WriteString, strFile, bAppendEnter);
			}
		}

		public static void WriteCCDReceiveDate(string WriteString, bool bAppendEnter = false, string path = CConst.SAVE_DATA_PATH)
		{
			path = Application.StartupPath + "\\Data";
			path = path + CConst.Save_Folder_Name;
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			StreamWriter swf = null;
			string strFile = path + "\\" + DateTime.Now.ToString("yyyyMMdd") + "CCDReceive.csv";
			try
			{
				//if (swf == null)
				{
					swf = new StreamWriter(strFile, true, Encoding.ASCII);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
				{
					swf = new StreamWriter(strFile, true, Encoding.Unicode);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
				{
					swf = new StreamWriter(strFile, true, Encoding.BigEndianUnicode);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
				{
					swf = new StreamWriter(strFile, true, Encoding.UTF32);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
				{
					swf = new StreamWriter(strFile, true, Encoding.UTF7);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
				{
					swf = new StreamWriter(strFile, true, Encoding.UTF8);
				}
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
			}
			catch (System.Exception ex)
			{
				HintMessageInfo.MessageTopMost("csv文件操作出错:" + ex.Message + " 请不要在运行中打开csv文件");
			}
		}

		//重写CSV文件
		public static void RewrteCSV(string WriteString, string strFile, bool bAppendEnter)
		{
			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				if (bAppendEnter)
				{
					swf.Write(WriteString + "\r\n");
				}
				else
				{
					swf.Write(WriteString);
				}

				swf.Close();
			}
			catch (System.Exception ex)
			{
				FormMessage.MesssageShowOnce("csv文件操作出错:" + ex.Message + " 请不要在运行中打开csv文件", FormMessage.MSG.CSV);
				RewrteCSV(WriteString, strFile, bAppendEnter);
				//HintMessageInfo.MessageTopMost("csv文件操作出错," +ex.Message+ " 请不要在运行中打开csv文件");
			}
		}

		//Write txt ，log名字前自动加日期
		public static void WriteCCDTxtDate(string WriteString, string fileName, string path = CConst.SAVE_DATA_PATH)//"..\\..\\log"
		{
			path = Application.StartupPath + "\\TcpReceiveData";
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			string strFile = path + "\\" + DateTime.Now.ToString("yyMMdd") + fileName + ".txt";
			if (File.Exists(strFile) == false)
			{//可用于第一行的写标题操作
			 //FileStream fs1 = new FileStream("..\\..\\message\\log.csv", FileMode.Create );
			}
			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				swf.Write(DateTime.Now.ToString("yyMMdd-") + DateTime.Now.ToString("HH:mm:ss.fff ") + WriteString + "\r\n");
				swf.Close();
			}
			catch
			{

			}
		}
		//Write txt ，log名字前自动加日期
		public static void WriteTxtDate(string WriteString, string fileName, string path = CConst.SAVE_DATA_PATH)//"..\\..\\log"
		{
			path = path + CConst.Save_Folder_Name;
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			string strFile = path + "\\" + DateTime.Now.ToString("yyMMdd") + fileName + ".txt";
			if (File.Exists(strFile) == false)
			{//可用于第一行的写标题操作
			 //FileStream fs1 = new FileStream("..\\..\\message\\log.csv", FileMode.Create );
			}
			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				swf.Write(DateTime.Now.ToString("yyMMdd-") + DateTime.Now.ToString("HH:mm:ss.fff ") + WriteString + "\r\n");
				swf.Close();
			}
			catch
			{

			}
		}
		//专门记录错误信息，只是默认路径不同
		public static void WriteTxtDateError(string WriteString, string fileName, string path = CConst.SAVE_DATA_PATH_ERROR)//"..\\..\\log"
		{
			//path = path + Global.CConst.Save_Folder_Name;
			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}
			string strFile = path + "\\" + fileName + ".txt";
			if (File.Exists(strFile) == false)
			{
				//可用于第一行的写标题操作
				//FileStream fs1 = new FileStream("..\\..\\message\\log.csv", FileMode.Create );
			}
			try
			{
				StreamWriter swf = new StreamWriter(strFile, true, Encoding.Default);
				swf.Write(DateTime.Now.ToString("yyMMdd-") + DateTime.Now.ToString("HH:mm:ss.fff ") + WriteString + "\r\n");
				swf.Close();
			}
			catch
			{

			}
		}

		public class MyFile
		{
			//delete folder
			//create folder
			public static void CreateFolder(string folder)
			{
				if (!Directory.Exists(folder))
				{
					Directory.CreateDirectory(folder);
				}
			}
			//delet folder beyond set days
			public static bool BeyondDays(string compare, int days = 7)
			{//some name may not format for yyMMdd, that will run to catch
				try
				{
					compare = GetNameWithoutSlash(compare);
					int nowMonth = DateTime.Now.Month;
					int nowDay = DateTime.Now.Day;

					int Month = int.Parse(compare.Substring(2, 2));
					int Days = int.Parse(compare.Substring(4, 2));

					//   //HCHEN 0315

					//DateTime creatTime  = File.GetCreationTime("D:\\DataScrewMachine\\" + compare);

					//TimeSpan   t = DateTime.Now - creatTime;
					//if (t.Days >= days)
					//{
					//    return true;
					//}
					//else
					//    return false;

					if ((30 * nowMonth + nowDay) - (30 * Month + Days) > days)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				catch
				{
					//System.Diagnostics.Debug.Assert(false);
					//HintMessageInfo.MessageTopMost(ex.Message);
				}
				return false;
			}
			//get name last of slash
			private static string GetNameWithoutSlash(string strName)
			{
				try
				{
					if (strName.IndexOf("\\") > 0)
					{
						int nLastSlash = strName.LastIndexOf("\\");
						string FileName = strName.Substring(nLastSlash + 1);
						return FileName;
					}
					else
					{
						return strName;
					}
				}
				catch
				{
				}
				return "";
			}
			//delete file
			public static void DeleteFile(string path)
			{
				if (System.IO.File.Exists(path))
				{
					System.IO.File.Delete(path);
				}
			}
			//move one file from folder to another
			public static void MoveFile(string oriFolder, string desFolder, string file)
			{
				if (System.IO.File.Exists(oriFolder + "\\" + file))
				{
					CreateFolder(desFolder);
					if (System.IO.Directory.Exists(desFolder))
					{
						System.IO.File.Move(oriFolder + "\\" + file, desFolder + "\\" + file);
					}
				}
			}
			//copy a file from a oriFolder to desFolder
			public static void CopyFile(string oriFolder, string desFolder, string file)
			{
				if (System.IO.File.Exists(oriFolder + "\\" + file))
				{
					CreateFolder(desFolder);
					if (System.IO.Directory.Exists(desFolder))
					{
						System.IO.File.Copy(oriFolder + "\\" + file, desFolder + "\\" + file + DateTime.Now.ToString("HHmm"), true);
						//System.IO.File.Copy(oriFolder + "\\" + file, desFolder + "\\" + file );
					}
				}
			}

			//move all files of folder to another
			public static void MoveFolderFiles(string OriFolder, string DesFolder)
			{
				try
				{
					if (Directory.Exists(OriFolder))
					{
						string[] FilesName = System.IO.Directory.GetFiles(OriFolder);
						for (int i = 0; i < FilesName.Length; i++)
						{
							string FileName = GetNameWithoutSlash(FilesName[i]);
							MoveFile(OriFolder, DesFolder, FileName);
						}
					}
				}
				catch
				{
				}


			}
			//copy all files of folder to another
			public static void CopyFolderFiles(string OriFolder, string DesFolder)
			{
				try
				{
					if (Directory.Exists(OriFolder))
					{
						string[] FilesName = System.IO.Directory.GetFiles(OriFolder);
						CreateFolder(DesFolder);
						for (int i = 0; i < FilesName.Length; i++)
						{
							string FileName = GetNameWithoutSlash(FilesName[i]);
							CopyFile(OriFolder, DesFolder, FileName);
						}
					}
				}
				catch
				{
				}

			}

		}
	}
}
