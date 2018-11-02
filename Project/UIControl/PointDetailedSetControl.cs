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
	public partial class PointDetailedSetControl : UserControl
	{
		private PointModule _PointM;
		public AxisConfig _acf;
		public PointModule PointM
		{
			get { return _PointM; }
			set
			{
				if (value != null)
				{
					_PointM = value;
					InitControl();
				}
			}
		}
		public PointDetailedSetControl(AxisConfig AC)
		{
			_acf = AC;
			InitializeComponent();
		}
		public void InitControl()
		{
			CheckBox_Enable.Checked = _PointM.blnPointEnable;

			if (CheckBox_Enable.Checked)
			{
				chkSpecial.Checked = _PointM.blnIsSpecialPoint;
				numValue.Value = new System.Decimal(_PointM.dblPonitValue);
				numSpeed.Value = new System.Decimal(_PointM.dblPonitSpeed / _acf.Eucf);
				numAcc.Value = new System.Decimal(_PointM.dblAcc);
				numDec.Value = new System.Decimal(_PointM.dblDec);
				numericUpDown_ACCTime.Value = new System.Decimal(_PointM.dblAccTime);
				numericUpDown_DccTime.Value = new System.Decimal(_PointM.dblDecTime);
				numericUpDown_StartSpeed.Value = new System.Decimal(_PointM.dblPonitStartSpeed / _acf.Eucf);


				numericUpDown_S_StopTime.Value = new System.Decimal(_PointM.db_S_Time);
				numericUpDown_StopSpeed.Value = new System.Decimal(_PointM.db_StopSpeed);




			}
			else
			{
				numValue.Value = new System.Decimal(_PointM.dblPonitValue);
				numSpeed.Value = new System.Decimal(_PointM.dblPonitSpeed / _acf.Eucf);
				numAcc.Value = new System.Decimal(_PointM.dblAcc);
				numDec.Value = new System.Decimal(_PointM.dblDec);
				numericUpDown_ACCTime.Value = new System.Decimal(_PointM.dblAccTime);
				numericUpDown_DccTime.Value = new System.Decimal(_PointM.dblDecTime);
				numericUpDown_StartSpeed.Value = new System.Decimal(_PointM.dblPonitStartSpeed / _acf.Eucf);


				numericUpDown_S_StopTime.Value = new System.Decimal(_PointM.db_S_Time);
				numericUpDown_StopSpeed.Value = new System.Decimal(_PointM.db_StopSpeed);

				ControlEnable();
			}

		}
		public void Save()
		{
			try
			{
				_PointM.blnPointEnable = CheckBox_Enable.Checked;
				if (CheckBox_Enable.Checked)
				{
					_PointM.blnIsSpecialPoint = chkSpecial.Checked;
					_PointM.dblPonitValue = Convert.ToDouble(numValue.Value);
					_PointM.dblPonitSpeed = Convert.ToDouble(numSpeed.Value) * _acf.Eucf;
					_PointM.dblAcc = Convert.ToDouble(numAcc.Value);
					_PointM.dblDec = Convert.ToDouble(numDec.Value);



					_PointM.dblAccTime = Convert.ToDouble(numericUpDown_ACCTime.Value);
					_PointM.dblDecTime = Convert.ToDouble(numericUpDown_DccTime.Value);
					_PointM.dblPonitStartSpeed = Convert.ToDouble(numericUpDown_StartSpeed.Value) * _acf.Eucf;


					_PointM.db_S_Time = Convert.ToDouble(numericUpDown_S_StopTime.Value);
					_PointM.db_StopSpeed = Convert.ToDouble(numericUpDown_StopSpeed.Value);


				}

			}
			catch (System.Exception ex)
			{
				Console.Write(ex.ToString());
			}
		}
		public void ControlEnable()
		{
			if (CheckBox_Enable.Checked)
			{
				chkSpecial.Enabled = true;
				numValue.Enabled = true;
				numSpeed.Enabled = true;
				numAcc.Enabled = true;
				numDec.Enabled = true;
			}
			else
			{
				chkSpecial.Enabled = false;
				numValue.Enabled = false;
				numSpeed.Enabled = false;
				numAcc.Enabled = false;
				numDec.Enabled = false;
			}
		}

		private void CheckBox_Enable_CheckedChanged(object sender, EventArgs e)
		{
			ControlEnable();
		}
	}
}
