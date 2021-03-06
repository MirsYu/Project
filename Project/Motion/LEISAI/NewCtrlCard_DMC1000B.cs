﻿using System;
namespace Project
{





	public class NewCtrlCard_DMC1000B : NewCtrlCardBase
	{
		ushort[] tag_cardids = new ushort[8];
		uint[] tag_cardtypes = new uint[8];

		public static int tag_isInit = 0;
		/// <summary>
		///   
		/// </summary>
		public static int tag_CardCount = 0;

		public NewCtrlCard_DMC1000B(int axisCount)
		{
			tag_AxisCount = 4;
			SR_FunInit();
			tag_Manufacturer = MotionCardManufacturer.MotionCardManufacturer_8960m;
		}
		public void SR_FunInit()
		{

			SR_InitCard = _SR_InitCard;
			SR_Close = _SR_Close;

			SR_set_io_mode = _SR_set_io_mode;
			SR_set_limit_mode = _SR_set_limit_mode;
			SR_set_pulse_mode = _SR_set_pulse_mode;
			SR_AxisEmgStop = _SR_AxisEmgStop;
			SR_GetAxisStatus = _SR_GetAxisStatus;
			SR_RelativeMove = _SR_RelativeMove;
			SR_AbsoluteMove = _SR_AbsoluteMove;
			SR_LineMulticoorMove = _SR_LineMulticoorMove;
			SR_continue_move = _SR_continue_move;
			// SR_GoHome = _SR_GoHome;
			//   SR_GoOneHome = _SR_GoOneHome;
			SR_GetInputBit = _SR_GetInputBit;
			SR_GetOutputBit = _SR_GetOutputBit;
			SR_SetOutputBit = _SR_SetOutputBit;
			SR_GetPrfPos = _SR_GetPrfPos;
			SR_GetEncPos = _SR_GetEncPos;
			SR_AxisStop = _SR_AxisStop;
			//SR_ClrStatus = _SR_ClrStatus;
			//SR_ClrAllStatus = _SR_ClrAllStatus;
			//SR_GetServoEnable = _SR_GetServoEnable;
			//SR_SetServoEnable = _SR_SetServoEnable;
			SR_SetPrfPos = _SR_SetPrfPos;
			SR_SetEncPos = _SR_SetEncPos;
			SR_GetAlarmInput = _SR_GetAlarmInput;
			SR_GetLimitPInput = _SR_GetLimitPInput;
			SR_GetLimitNInput = _SR_GetLimitNInput;
			SR_GetOriginInput = _SR_GetOriginInput;
			SR_set_softlimit = _SR_set_softlimit;


		}
		/// <summary>
		/// 卡初始化
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axisCount"></param>
		/// <param name="configFileName"></param>
		/// <returns></returns>
		public short _SR_InitCard()
		{
			short returnValue = 0;
			if (tag_isInit == 0)
			{
				returnValue = (short)Dmc1000.d1000_board_init();//获取卡数量
				tag_CardCount = returnValue;
				tag_isInit = 1;
				if (returnValue <= 0 || returnValue > 8)
				{
					string str = "DMC100B控制卡初始化失败!";
					if (returnValue == 0) str = str + "\r\n没有安装雷赛卡";
					if (returnValue == -1) str = str + "没有安装端口驱动程序！";
					if (returnValue == -2) str = str + "PCI桥故障！";

					MessageBoxLog.Show(str);
					return -1;
				}
				short i = 0; short j = 0;



				while (i < returnValue)
				{
					while (j < 4)
					{
						_SR_AxisStop(i, j);
						_SR_SetEncPos(i, j, 0);

						j++;
					}
					i++;
				}
			}



			return returnValue;
		}

		public short _SR_Close()
		{
			short returnValue = 0;
			if (tag_isInit == 1)
			{
				returnValue = (short)Dmc1000.d1000_board_close();//获取卡数量
				tag_isInit = 0;
			}
			return 0;
		}

		/// <summary>
		/// 设定正负方向限位输入nLMT信号的模式
		/*功能：
        参数：
        cardno	    卡号
        axis		轴号(1-4)
        v1          0：正限位有效			1：正限位无效
        v2          0：负限位有效			1：负限位无效
        logic       0：低电平有效			1：高电平有效
        返回值			0：正确					1：错误 
        默认模式为：正限位有效，负限位有效，低电平有效
        *****************************************************/
		/// </summary>
		/// <param name="cardno"></param>
		/// <param name="axis"></param>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <param name="logic"></param>
		/// <returns></returns>
		public short _SR_set_limit_mode(int cardno, int axis, int v1, int v2, int logic)
		{

			/*功 能：设置 EL 限位信号
                参 数：CardNo 控制卡卡号
                axis 指定轴号，取值范围：DMC3410：0~3，DMC3800：0~7，DMC3600：0~5
                                    DMC3400A：0~3
                 el_enable EL 信号的使能状态：
                                        0：正负限位禁止
                                        1：正负限位允许
                                        2：正限位禁止、负限位允许（DMC3800/3600/3400A 专用）
                                        3：正限位允许、负限位禁止（DMC3800/3600/3400A 专用）
                el_logic EL 信号的有效电平：
                                        0：正负限位低电平有效
                                        1：正负限位高电平有效
                                        2：正限位低有效，负限位高有效（DMC3800/3600/3400A 专用）
                                        3：正限位高有效，负限位低有效（DMC3800/3600/3400A 专用）
                el_mode EL 制动方式：
                                        0：正负限位立即停止
                                        1：正负限位减速停止
                                        2：正限位立即停止，负限位减速停止（DMC3800/3600/3400A 专
                                        用）
                                        3：正限位减速停止，负限位立即停止（DMC3800/3600/3400A 专
                                        用）
                                           返回值：错误代码*/

			return 0;
		}


		/// <summary>
		///设定输入输出
		/*参数： 
		v1		    0:前面8个点定义为输入 1:前面的8个点定义为输出
				
	    v2		    0:后面8个点定义为输入 1:后面的8个点定义为输出
				
		返回值		0:正确				  1:错误
				
		注：当IO点作为输出点用的时候且能同时读到输入状态
		*********************************************************************/
		/// </summary>
		/// <param name="cardno"></param>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public short _SR_set_io_mode(int cardno, int v1, int v2)
		{
			/*   int returnValue = adt8960m.adt8960_set_io_mode(cardno, v1, v2);//设定输入输出

			   if (returnValue != 0)
			   {
				   return -1;
			   }
			 */
			return 0;
		}


		/// <summary>
		/// 设置输出脉冲的工作方式    默认模式：脉冲+方向，正逻辑脉冲，方向输出信号正逻辑
		/// </summary>
		/// <param name="cardno"></param>
		/// <param name="axis"></param>
		/// <param name="value"> 0：脉冲+脉冲方式		1：脉冲+方向方式</param>
		/// <param name="logic">0：	正逻辑脉冲			1：	负逻辑脉冲</param>
		/// <param name="dir_logic">	0：方向输出信号正逻辑	1：方向输出信号负逻辑</param>
		/// <returns>	0：正确					1：错误</returns>
		public int _SR_set_pulse_mode(Int32 CardNo, Int32 axis, Int32 value, Int32 logic, Int32 dir_logic)
		{

			/*       参 数：CardNo 控制卡卡号
								   axis 指定轴号，取值范围：DMC3410：0~3，DMC3800：0~7，DMC3600：0~5
															 DMC3400A：0~3
													   outmode 脉冲输出方式选择，其值如表 8.1 所示
							   返回值：错误代码*/

			ushort outmode = 0;
			if (value == 0)
			{
				if (logic == 0)
				{
					outmode = 2;
				}
				else
				{
					outmode = 3;
				}
			}
			else
			{
				if ((logic == 0 && dir_logic == 0))//正脉冲逻辑，方向正
				{
					outmode = 0;
				}
				else if (logic == 0 && dir_logic == 1) //正脉冲逻辑，方向负
				{
					outmode = 1;
				}
				else if (logic == 1 && dir_logic == 0)//负方脉冲逻辑，方向正
				{
					outmode = 0;
				}
				else if (logic == 1 && dir_logic == 1)//负方脉冲逻辑，方向负
				{
					outmode = 1;
				}
			}
			if (tag_CardCount < 1 || CardNo >= tag_CardCount)
			{
				return -1;
			}
			if (axis < tag_AxisCount)
			{
				int returnValue = Dmc1000.d1000_set_pls_outmode((int)axis + (CardNo) * tag_AxisCount, outmode); //设定限位模式，设正负限位有效，低电平有效
				if (returnValue != 0)
				{
					return -1;
				}
			}
			return 0;
		}
		/// <summary>
		/// 设置单轴紧急停止
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <returns></returns>
		public short _SR_AxisEmgStop(short card, short axis)
		{
			short shrResult;

			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			shrResult = (short)Dmc1000.d1000_immediate_stop(axis + card * tag_AxisCount);
			if (shrResult != shrGtsSuccess)
			{
				CommandResult("d1000_stop", shrResult);
				return shrResult;
			}
			return shrResult;
		}
		/// <summary>
		/// 获取轴状态信息
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="axisStatus">获取的轴状态</param>
		/// <returns>返回0与非0   0代表轴停止， 非0轴在运动中</returns>
		public short _SR_GetAxisStatus(short card, short axis, out int axisStatus)
		{
			short shrResult = 0;
			axisStatus = 0;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			short staus = (short)Dmc1000.d1000_check_done(axis + card * tag_AxisCount);
			if (staus == 0)
			{
				axisStatus = 1;
			}
			else

			{
				axisStatus = 0;
			}


			return shrResult;
		}
		/// <summary>
		/// 单轴相对运动
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="postion">目标点位</param>
		/// <param name="speed">速度</param>
		/// <returns></returns>
		public short _SR_RelativeMove(AxisConfig axisC, PointModule point)
		{

			short shrResult = 0;

			if (point.dblPonitSpeed == 0.0)
			{
				MessageBoxLog.Show(axisC.AxisName + "速度设置位0,急停请设置");
				return -1;
			}
			if (tag_CardCount < 1 || axisC.CardNum >= tag_CardCount)
			{
				return -1;
			}

			Dmc1000.d1000_set_s_profile(axisC.CardNum * tag_AxisCount + axisC.AxisNum, point.db_S_Time);//设置S段时间（0-0.05s)
																										// Dmc1000.d1000_set_profile((ushort)axisC.CardNum, (ushort)axisC.AxisNum, dblPonitSpeed.StartSpeed, point.dblPonitSpeed, point.db_StopSpeed, point.dblAccTime, point.dblDecTime);//设置起始速度、运行速度、停止速度、加速时间、减速时间
			shrResult = (short)Dmc1000.d1000_start_t_move(axisC.CardNum * tag_AxisCount + axisC.AxisNum,
				(int)(point.dblPonitValue * axisC.Eucf), (int)point.dblPonitStartSpeed, (int)point.dblPonitSpeed, point.dblAcc);//定长运动


			if (shrResult != shrGtsSuccess)
			{
				CommandResult("_SR_RelativeMove", shrResult);
				return shrFail;
			}
			return shrResult;
		}
		/// <summary>
		/// 单轴绝对运动
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="postion">目标点位</param>
		/// <param name="speed">速度</param>
		/// <returns></returns>
		public short _SR_AbsoluteMove(AxisConfig axisC, PointModule point)
		{
			short shrResult = 0;
			if (point.dblPonitSpeed == 0.0)
			{
				MessageBoxLog.Show(axisC.AxisName + "速度设置位0,急停请设置");
				return -1;
			}

			if (tag_CardCount < 1 || axisC.CardNum >= tag_CardCount)
			{
				return -1;
			}
			Dmc1000.d1000_set_s_profile(axisC.CardNum * tag_AxisCount + axisC.AxisNum, point.db_S_Time);//设置S段时间（0-0.05s)
																										// Dmc1000.d1000_set_profile((ushort)axisC.CardNum, (ushort)axisC.AxisNum, dblPonitSpeed.StartSpeed, point.dblPonitSpeed, point.db_StopSpeed, point.dblAccTime, point.dblDecTime);//设置起始速度、运行速度、停止速度、加速时间、减速时间
			shrResult = (short)Dmc1000.d1000_start_sa_move(axisC.CardNum * tag_AxisCount + axisC.AxisNum,
				(int)(point.dblPonitValue * axisC.Eucf), (int)point.dblPonitStartSpeed, (int)point.dblPonitSpeed, point.dblAcc);//定长运动


			if (shrResult != shrGtsSuccess)
			{
				CommandResult("_SR_RelativeMove", shrResult);
				return shrFail;
			}
			return shrResult;
		}

		/// <summary>
		/// 直线查补运动
		/// </summary>
		/// <param name="card"></param>
		/// <param name="postion">目标点位</param>
		/// <param name="crd">坐标系</param>
		/// <param name="posi_mode">运动模式，0:相对坐标模式，1:绝对坐标模式</param>
		/// <returns></returns>
		public short _SR_LineMulticoorMove(AxisConfig[] axisC, PointModule[] point, short crd, short posi_mode)
		{
			short i = 0;
			if (axisC.Length == 0)
			{
				return 0;
			}
			while (i < axisC.Length - 1)
			{
				if (axisC[i].CardNum != axisC[i + 1].CardNum)
				{
					return -1;
				}
				i++;
			}
			i = 0;
			short[] axis = new short[axisC.Length];
			int[] pos = new int[axisC.Length];
			double Min_Vel = 0;
			double Max_Vel = 0;
			double Tacc = 0;
			double Tdec = 0;
			double Stop_Vel = 0;
			while (i < point.Length)
			{
				Min_Vel = Min_Vel + point[i].dblPonitStartSpeed;
				Max_Vel = Max_Vel + point[i].dblPonitSpeed;
				Stop_Vel = Stop_Vel + point[i].dblPonitSpeed;
				Tacc = Tacc + point[i].dblAccTime;
				Tdec = Tdec + point[i].dblDecTime;
				axis[i] = (short)(axisC[i].CardNum * tag_AxisCount + axisC[i].AxisNum);
				pos[i] = (int)(point[i].dblPonitValue * axisC[i].Eucf);
				i++;
			}
			Min_Vel = Min_Vel / i;
			Max_Vel = Max_Vel / i;
			Stop_Vel = Stop_Vel / i;
			Tacc = Tacc / i;
			Tdec = Tdec / i;

			if (posi_mode == 0)
			{
				return (short)Dmc1000.d1000_start_t_line(i,
					ref axis[0],
				   ref pos[0],
					(int)Min_Vel,
					(int)Max_Vel,
					Tacc);
			}
			else
			{
				return (short)Dmc1000.d1000_start_ta_line(i,
					ref axis[0],
				   ref pos[0],
					(int)Min_Vel,
					(int)Max_Vel,
					Tacc);
			}
			// return Dmc1000.d1000_start_ta_line(tag_cardids[(int)axisC[0].CardNum], (ushort)crd, (ushort)axisC.Length, axis, pos, (ushort)posi_mode);

		}


		/// <summary>
		/// 单轴连续运动
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="postion">目标点位</param>
		/// <param name="speed">速度</param>
		/// <returns></returns>
		public short _SR_continue_move(AxisConfig axisC, PointModule point, int dir)
		{
			if (tag_CardCount < 1 || axisC.CardNum >= tag_CardCount)
			{
				return -1;
			}
			int ddir = 1;
			if (dir == 1)
				ddir = -1;
			int speed = (int)point.dblPonitSpeed * ddir;
			int dblPonitStartSpeed = (int)point.dblPonitStartSpeed * ddir;
			short ret = (short)Dmc1000.d1000_start_sv_move(axisC.CardNum * tag_AxisCount + axisC.AxisNum, (int)dblPonitStartSpeed,
				(int)speed, point.dblAccTime);
			return ret;//连续运动

		}

		/// <summary>
		/// 获取单点 输入信号 
		/// </summary>
		/// <param name="card"></param>
		/// <param name="ioBit">0开始， 0-15</param>
		/// <param name="bStatus"></param>
		/// <returns></returns>
		public short _SR_GetInputBit(short card, short ioBit, out bool bStatus)
		{
			bStatus = false;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			int IOBool = Dmc1000.d1000_in_bit(ioBit + card * 32);

			if (IOBool == 1)
			{
				bStatus = true;
			}

			return 0;
		}
		/// <summary>
		/// 获取单个输出IO状态
		/// </summary>
		/// <param name="card"></param>
		/// <param name="ioBit"></param>
		/// <param name="outputIoStatus"></param>
		/// <returns></returns>
		public short _SR_GetOutputBit(short card, short ioBit, out bool outputIoStatus)
		{
			outputIoStatus = false;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			int IOBool = Dmc1000.d1000_get_outbit(ioBit + card * 32);

			if (IOBool == 1)
			{
				outputIoStatus = true;
			}
			return 0;
		}
		/// <summary>
		/// 设置单点 输出信号 
		/// </summary>
		/// <param name="card"></param>
		/// <param name="ioBit">0开始， 0-15</param>
		/// <param name="value"></param>
		/// <returns></returns>
		public short _SR_SetOutputBit(short card, short ioBit, short value)
		{
			short shrResult = 0;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			shrResult = (short)Dmc1000.d1000_out_bit(ioBit + card * 32, (int)value);
			if (shrResult != 0)
			{
				CommandResult("d1000_write_outbit", shrResult);
				return shrResult;
			}
			return shrResult;
		}

		/// <summary>
		/// 读取板卡规划位置
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="pos"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public short _SR_GetPrfPos(short card, short axis, ref double pos)
		{
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			pos = (double)Dmc1000.d1000_get_command_pos(card * tag_AxisCount + axis);
			return 0;
		}
		public short _SR_GetEncPos(short card, short axis, ref double pos)
		{
			pos = (double)Dmc1000.d1000_get_command_pos(card * tag_AxisCount + axis);
			return 0;
		}

		/// <summary>
		/// 设置板卡规划位置
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <param name="pos"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public short _SR_SetPrfPos(short card, short axis, double pos)
		{
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			short ret = (short)Dmc1000.d1000_set_command_pos(card * tag_AxisCount + axis, (int)pos);
			return ret;
		}
		public short _SR_SetEncPos(short card, short axis, double pos)
		{
			short ret = (short)Dmc1000.d1000_set_command_pos(card * tag_AxisCount + axis, (int)pos);
			return ret;
		}

		/// <summary>
		/// 设置单轴停止 减速停止
		/// </summary>
		/// <param name="card"></param>
		/// <param name="axis"></param>
		/// <returns></returns>
		public short _SR_AxisStop(short card, short axis)
		{
			short shrResult;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			shrResult = (short)Dmc1000.d1000_immediate_stop(axis + card * tag_AxisCount);
			if (shrResult != shrGtsSuccess)
			{
				CommandResult("adt8960m_dec_stop", shrResult);
				return shrFail;
			}
			return shrResult;
		}
		/// <summary>
		/// 获取单卡 报警输入状态 
		/// </summary>
		/// <param name="card"></param>
		/// <param name="pValue"></param>
		/// <returns></returns>
		public short _SR_GetAlarmInput(short card, short axisNum, out bool pValue)
		{
			/*short shrResult;

            int status = Dmc1000.d1000_get_axis_status(card * tag_AxisCount + axisNum);
 
            if ((status & 1) == 1)
              {
                    pValue = true;
               }
               else
                {
                    pValue = false;
                }*/
			pValue = true;
			return 0;


		}
		/// <summary>
		/// 获取单卡 正极限输入状态
		/// </summary>
		/// <param name="card"></param>
		/// <param name="pValue"></param>
		/// <returns></returns>
		public short _SR_GetLimitPInput(short card, short axisNum, out bool pValue)
		{
			pValue = false;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			int status = Dmc1000.d1000_get_axis_status(card * tag_AxisCount + axisNum);
			int bit = (int)Math.Pow(2, 1);
			if ((status & bit) == bit)
			{
				pValue = true;
			}
			else
			{
				pValue = false;
			}
			return 0;
		}
		/// <summary>
		/// 获取单卡 负极限输入状态
		/// </summary>
		/// <param name="card"></param>
		/// <param name="pValue"></param>
		/// <returns></returns>
		public short _SR_GetLimitNInput(short card, short axisNum, out bool pValue)
		{
			pValue = false;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			int status = Dmc1000.d1000_get_axis_status(card * tag_AxisCount + axisNum);
			int bit = (int)Math.Pow(2, 0);
			if ((status & bit) == bit)
			{
				pValue = true;
			}
			else
			{
				pValue = false;
			}
			return 0;
		}

		/// <summary>
		/// 获取单卡 原点输入状态 
		/// </summary>
		/// <param name="card"></param>
		/// <param name="pValue">原点状态值，按位取</param>
		/// <returns></returns>        
		public short _SR_GetOriginInput(short card, short axisNum, out bool pValue)
		{
			pValue = false;
			if (tag_CardCount < 1 || card >= tag_CardCount)
			{
				return -1;
			}
			int status = Dmc1000.d1000_get_axis_status(card * tag_AxisCount + axisNum);

			int bit = (int)Math.Pow(2, 2);
			if ((status & bit) == bit)
			{
				pValue = true;
			}
			else
			{
				pValue = false;
			}
			return 0;

		}
		/// <summary>
		/// 获取急停 原点输入状态 
		/// </summary>
		/// <param name="card"></param>
		/// <param name="pValue">原点状态值，按位取</param>
		/// <returns></returns>        
		public short _SR_GetStopInput(short card, short axisNum, out bool pValue)
		{

			pValue = false;
			return 0;

		}

		/// <summary>
		/// 设置软限位
		/// </summary>
		/// <param name="axisC"></param>
		/// <returns></returns>
		public short _SR_set_softlimit(AxisConfig axisC)
		{

			/*功 能：设置软限位
                  参 数：CardNo 控制卡卡号
              axis 指定轴号，取值范围：DMC3410：0~3，DMC3800：0~7，DMC3600：0~5
              DMC3400A：0~3
              enable 使能状态，0：禁止，1：允许
              source_sel 计数器选择，0：指令位置计数器，1：编码器计数器
              SL_action 限位停止方式，0：减速停止，1：立即停止
              N_limit 负限位位置，单位：pulse
              P_limit 正限位位置，单位：pulse*/


			return 0;
		}

	}
}
