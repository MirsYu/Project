using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class AxisSafe
	{
		/// <summary>
		/// 轴ID
		/// </summary>
		public int tag_AxisId = 0;
		/// <summary>
		/// 最大值 
		/// </summary>
		public double tag_max = 99999999999;
		/// <summary>
		/// 最小值
		/// </summary>
		public double tag_min = -99999999999;
		public short tag_type = 0;
		/// <summary>
		/// card 卡号，axisId 轴号
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axisId"></param>
		public AxisSafe(short type, short card, short axisId)
		{
			tag_AxisId = type * 1000 + card * 100 + axisId;
		}
		/// <summary>
		///设置安全位   max z最大安全位，min 最小安全位
		/// </summary>
		/// <param name="max"></param>
		/// <param name="min"></param>
		public void SetSafe(double max, double min)
		{
			tag_max = max;
			tag_min = min;
		}
		/// <summary>
		/// 判断是否在安全位
		/// </summary>
		/// <returns></returns>
		public bool IsSafe(double coordinate)
		{
			bool ret = false;
			if (coordinate <= tag_max && coordinate >= tag_min)
			{
				ret = true;
			}
			else
			{

			}
			return ret;
		}
	}
}
