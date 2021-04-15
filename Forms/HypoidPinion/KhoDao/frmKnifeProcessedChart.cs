using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.Business;
using BMS.Model;

namespace BMS
{
	public partial class frmKnifeProcessedChart : _Forms
	{
		private string knifeCode;

		public frmKnifeProcessedChart()
		{
			InitializeComponent();
		}


		void LoadDataToChartProduct()
		{

			DataTable dt = TextUtils.LoadDataFromSP("spGetChartProductData", "A", new string[] { "@numberOfProduct" }, new object[] { 0 });
			DataTable dt1 = TextUtils.Select("SELECT KnifeCode, ATC FROM KnifeDetailList WHERE Status = 1");
			DataTable dt2 = TextUtils.Select("SELECT KnifeCode, STD FROM KnifeDetailList WHERE Status = 1");


			//  Chong' timer khi refresh se chay tren 1 luong rieng biet nen se gay loi Index of out bound
			chartControl2.Invoke((MethodInvoker)delegate
			{
				chartControl2.Series[0].DataSource = dt;
				chartControl2.Series[0].ArgumentScaleType = ScaleType.Auto;
				chartControl2.Series[0].ArgumentDataMember = "KnifeCode";
				chartControl2.Series[0].ValueScaleType = ScaleType.Numerical;
				chartControl2.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });

				chartControl2.Series[1].DataSource = dt2;
				chartControl2.Series[1].ArgumentScaleType = ScaleType.Auto;
				chartControl2.Series[1].ArgumentDataMember = "KnifeCode";
				chartControl2.Series[1].ValueScaleType = ScaleType.Numerical;
				chartControl2.Series[1].ValueDataMembers.AddRange(new string[] { "STD" });

				chartControl2.Series[2].DataSource = dt1;
				chartControl2.Series[2].ArgumentScaleType = ScaleType.Auto;
				chartControl2.Series[2].ArgumentDataMember = "KnifeCode";
				chartControl2.Series[2].ValueScaleType = ScaleType.Numerical;
				chartControl2.Series[2].ValueDataMembers.AddRange(new string[] { "ATC" });
			});

		}

		void LoadDataToChartTime(string knifeCode)
		{

			int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
			DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 1);
			DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, days, 23, 59, 59);

			DataTable dt = TextUtils.LoadDataFromSP("spGetChartProductHistoryData", "A", new string[] { "@knifeCode" }, new object[] { knifeCode });
			DataTable dt1 = TextUtils.LoadDataFromSP("spGetChartProductTotalHistory", "A", new string[] {  }, new object[] { });
			//DataTable dt1 = TextUtils.Select("SELECT KnifeCode, ATC FROM KnifeDetailList WHERE Status = 1");
			DataTable dt2 = new DataTable();

			//  Chong' timer khi refresh se chay tren 1 luong rieng biet nen se gay loi Index of out bound
			chartControl1.Invoke((MethodInvoker)delegate
			{
				chartControl1.Series[0].DataSource = dt;
				chartControl1.Series[0].ArgumentScaleType = ScaleType.Auto;
				chartControl1.Series[0].ArgumentDataMember = "CDay";
				chartControl1.Series[0].ValueScaleType = ScaleType.Numerical;
				chartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });

				chartControl1.Series[2].DataSource = dt2;
				

				chartControl1.Series[1].DataSource = dt1;
				chartControl1.Series[1].ArgumentScaleType = ScaleType.Auto;
				chartControl1.Series[1].ArgumentDataMember = "CDay";
				chartControl1.Series[1].ValueScaleType = ScaleType.Numerical;
				chartControl1.Series[1].ValueDataMembers.AddRange(new string[] { "Quantity" });
			});
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			LoadDataToChartProduct();
			//label1.Invoke((MethodInvoker)delegate {
			//     var rnd = new Random();
			//     label1.Text = rnd.Next().ToString();
			//     timer1.Enabled = true;
			// });

			timer1.Enabled = true;
		}

		private void frmKnifeProcessedChart_Load(object sender, EventArgs e)
		{
			LoadDataToChartProduct();
			timer1.Enabled = true;
			// Thuoc tinh RuntimeHitTesting can phai duoc bat thi bieu do khi click vao moi co the cho ra du lieu!!!
			chartControl2.RuntimeHitTesting = true;
		}

		private void chartControl2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				ChartHitInfo hitInfo = chartControl2.CalcHitInfo(e.Location);

				if (hitInfo.SeriesPoint != null)
				{
					knifeCode = hitInfo.SeriesPoint.Argument;
					LoadDataToChartTime(knifeCode);
					// double quantity = hitInfo.SeriesPoint.Values[0];
					//Arr = KnifeDetailListBO.Instance.FindByAttribute("KnifeCode", knifeCode);
				}
			}
			catch
			{
			}


		}

		private void chartControl2_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				ChartHitInfo hitInfo = chartControl2.CalcHitInfo(e.Location);

				if (hitInfo.SeriesPoint != null)
				{
					knifeCode = hitInfo.SeriesPoint.Argument;
					LoadDataToChartTime(knifeCode);
					// double quantity = hitInfo.SeriesPoint.Values[0];
					//Arr = KnifeDetailListBO.Instance.FindByAttribute("KnifeCode", knifeCode);
				}
			}
			catch
			{
			}
		}
	}
}
