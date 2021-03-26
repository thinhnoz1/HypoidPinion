using BMS.Business;
using BMS.Model;
using BMS.Utils;
using DevExpress.XtraCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
namespace BMS
{
    public partial class frmImportPart : _Forms
    {
        public frmImportPart()
        {
            InitializeComponent();
            txbWorkerCode.Focus();

        }
		System.Timers.Timer _timer;
        #region Method
        bool SaveData() {
            if (MessageBox.Show(String.Format("Bạn có chắc muốn lưu không?"), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbQuantity.Value > 0)
                {
                    if (PartSonBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
                    {
                        int type;
                        if (txbType.Text == "Xuất khẩu")
                            type = 1;
                        else type = 0; // lap rap
                        TextUtils.ExcuteProcedure("spImportPart",
                                    new string[] { "@partCode", "@orderCode", "@quantity", "@workerCode", "@partType" },
                                    new object[] { txbPartCode.Text.Trim(), txbOrderCode.Text.Trim(), (int)txbQuantity.Value, txbWorkerCode.Text, type });
                        return true;
                    }
                    else {
                        MessageBox.Show("Mã linh kiện không tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

            }
            else return false;
        }
        void LoadDataToChart()
        {
            //string sql = "SELECT * FROM dbo.SONHistoryImEx WHERE DateImEx <= DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) AND DateImEx > DATEADD(DD, -30, CAST(CURRENT_TIMESTAMP AS DATE))";



            DataTable dt = TextUtils.LoadDataFromSP("spGetSonPartImportDataByDate","A", new string[] { "@numofdate" }, new object[] { 30 });
            DataTable table = new DataTable();
            DataRow row = null;

            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            int sumQuantity = 0;

            //  Lấy dữ liệu ta cần từ list data 
            //  Trong bang, cot thu [3] la DateImEx, [4] la Quantity
            for (int i = 0; i < 31; i++)
            {
                DateTime past = DateTime.Now.AddDays(-i);
                foreach (DataRow model in dt.Rows)
                {
                    DateTime day = (DateTime)model.ItemArray[4];
                    int quantity = (int)model.ItemArray[5];
                    if (day.Day == past.Day && day.Month == past.Month)
                    {
                        sumQuantity = sumQuantity + quantity;
                    }

                }
                row = table.NewRow();
                row["Day"] = past.Day.ToString() + "/" + past.Month.ToString();
                row["Quantity"] = sumQuantity;
                table.Rows.Add(row);
                sumQuantity = 0;
            }

            
            //  Chong' timer khi refresh se chay tren 1 luong rieng biet nen se gay loi Index of out bound
            chartControl2.Invoke((MethodInvoker)delegate
			{
				chartControl2.Series[0].DataSource = table;
				chartControl2.Series[0].ArgumentScaleType = ScaleType.Auto;
				chartControl2.Series[0].ArgumentDataMember = "Day" ;
				chartControl2.Series[0].ValueScaleType = ScaleType.Numerical;
				chartControl2.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });
			});
			
        }
        #endregion


        #region Event

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("AAAA");
            if (SaveData())
            {
                LoadDataToChart();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void frmImportPart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                txbPartCode.Text = "";
                txbOrderCode.Text = "";
                txbCurrentQuantity.Text = "";
                txbQuantity.Value = 0;
                txbType.Text = "";
                LoadDataToChart();
                txbOrderCode.Focus();
            }
        }
        private void frmImportPart_Load(object sender, EventArgs e)
        {
            LoadDataToChart();
            timer1.Enabled = true;
        }
        private void txbOrderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                try
                {
                    txbType.Text = "";
                    txbCurrentQuantity.Text = "";
                    txbPartCode.Text = "";
                    if (SonPlanBO.Instance.CheckExist("OrderCode", txbOrderCode.Text.Trim()))
                    {
                        txbType.Text = "Xuất khẩu";
                        string str = txbOrderCode.Text.Trim();
                        ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("OrderCode", str);
                        SonPlanModel model = arrProduct[0] as SonPlanModel;
                        txbPartCode.Text = model.PartCode;

                        txbPartCode_KeyPress(new object(), new KeyPressEventArgs((char)13));
                    }
                    else
                    {
                        txbType.Text = "Lắp ráp";
                        txbPartCode.Focus();
                        txbPartCode.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void txbPartCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    txbCurrentQuantity.Text = "";
                    string query = string.Format("SELECT ISNULL((SELECT SUM(Quantity) FROM dbo.SONHistoryImEx WHERE PartCode = '{0}' AND DateImEx >= CAST(CURRENT_TIMESTAMP AS DATE) AND DateImEx < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE))), -1)", txbPartCode.Text.Trim());
                    int quantity = (int)TextUtils.ExcuteScalar(query);
                    if (quantity == -1) {
                        txbQuantity.Focus();
                        txbQuantity.Select(0, txbQuantity.Text.Length);
                        txbCurrentQuantity.Text = "0";
                    }
                    else {
                        txbQuantity.Focus();
                        txbQuantity.Select(0, txbQuantity.Text.Length);
                        txbCurrentQuantity.Text = quantity.ToString();
                    }

                }
                catch (Exception er)
                {

                }
            }
        }

		#endregion

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
            btnSaveNew_Click(null, null);

        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            timer1.Enabled = false;
            LoadDataToChart();
            //label1.Invoke((MethodInvoker)delegate {
            //     var rnd = new Random();
            //     label1.Text = rnd.Next().ToString();
            //     timer1.Enabled = true;
            // });

            timer1.Enabled = true;
        }

		private void txbWorkerCode_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)13)
                txbOrderCode.Focus();
        }
    }
}
