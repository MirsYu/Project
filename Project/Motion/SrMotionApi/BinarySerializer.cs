using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project
{
	[Serializable]
	public class BinarySerializer
	{
		private object o;
		private bool bResult = false;

		public static bool Serialize<T>(T o, string filePath)
		{
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();
				Stream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
				if(stream.Length != 0)
					formatter.Serialize(stream, o);
				stream.Flush();
				stream.Close();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		public virtual bool Save(string filePath)
		{
			o = this;
			if (o != null)
			{
				bResult = Serialize(o, filePath);
				return bResult;
			}
			return false;
		}

		public static T DeSerialize<T>(string filePath)
		{

			try
			{
				Stream destream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
				T o = default(T);
				BinaryFormatter formatter = new BinaryFormatter();
				if (destream.Length!=0)
					o = (T)formatter.Deserialize(destream);
				destream.Flush();
				destream.Close();
				return o;
			}
			catch (Exception) {

			}
			return default(T);
		}

		public static BinarySerializer Load(string Path)
		{
			return DeSerialize<BinarySerializer>(Path);
		}
	}
}
