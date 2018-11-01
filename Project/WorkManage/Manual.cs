using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	/// <summary>
	/// 手动调试参数
	/// </summary>
	public class Manual
	{
		/// <summary>
		/// 屏蔽作用
		/// </summary>
		public bool tag_Induction;
		/// <summary>
		/// 单步运行，
		/// </summary>
		public int tag_StepName;
		/// <summary>
		/// 单步调试开关
		/// </summary>
		public int tag_Step;
		/// <summary>
		/// 是否暂停
		/// </summary>
		public bool tag_IsSuspend;
		/// <summary>
		/// 暂停函数
		/// </summary>
		public delegate_PointModule tag_SuspendFun;
		/// <summary>
		/// 暂停继续函数
		/// </summary>
		public delegate_PointModule tag_ContinueFun;

		/// <summary>
		/// 当前正在运行的步骤
		/// </summary>
		public PointAggregate tag_ExePointAggregate;

		/// <summary>
		/// 构造函数，初始化的时候，表示从第几步开始 
		/// </summary>
		/// <param name="ndStep"></param>
		public Manual(int ndStep)
		{
			tag_StepName = ndStep;
		}
	}
}
