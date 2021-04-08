using System;
using System.Collections;
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
	public partial class frmKnifeSharpenList : _Forms
	{
		#region Variables
		//public KnifeDetailListModel knifeDetailListModel = new KnifeDetailListModel();
		private KnifeProcessedListModel knifeProcessedList = new KnifeProcessedListModel();
		public int knifeID = 0;
		int prevRow;
		#endregion

		#region Methods
		public frmKnifeSharpenList()
		{
			InitializeComponent();
		}

		void LoadListUsers()
		{
			DataTable dt = TextUtils.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "UserCode", "FullName", "BirthOfDate", "DepartmentID", "DepartmentCode" }, "Users", "UserCode"));
			cWorker.Properties.DataSource = dt;
			cWorker.Properties.DisplayMember = "UserCode";
			cWorker.Properties.ValueMember = "ID";
		}

		void LoadListKnifeList()
		{
			string sql = "SELECT ID, KnifeCode, STD, ATC FROM dbo.KnifeDetailList WHERE Status = 1";
			DataTable dt = TextUtils.Select(sql);
			cKnifeList.Properties.DataSource = dt;
			cKnifeList.Properties.DisplayMember = "KnifeCode";
			cKnifeList.Properties.ValueMember = "ID";
		}

		void LoadAllComboboxData() {
			LoadListUsers(); LoadListKnifeList();

			DataTable dt = TextUtils.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "MachineCode", "MachineName", "StageCode" }, "Machine", "MachineCode"));
			cMachine.Properties.DataSource = dt;
			cMachine.Properties.DisplayMember = "MachineCode";
			cMachine.Properties.ValueMember = "ID";
		}

		void LoadData()
		{
			string sql = "SELECT ksd.*, (kdl.STD - ksd.CurrentSTD) AS RemainSTD, (kdl.ATC - ksd.CurrentATC) AS RemainATC, u.UserCode, u.DepartmentCode FROM dbo.KnifeSharpeningDetails AS ksd, dbo.KnifeDetailList AS kdl, dbo.Users AS u WHERE ksd.KnifeID = kdl.ID AND kdl.Status = 1 AND	ksd.WorkerID = u.ID";
			DataTable arr = TextUtils.Select(sql);
			dtgvKnifeSharpen.DataSource = arr;
		}

		void LoadDataToForm()
		{
			cKnifeList.EditValue = knifeID;
		}

		void ClearFormData() {
			txbProductCode.Text = "";
			txbQuantity.Value = 0;
		}

		bool ValidateForm()
		{
			if (cKnifeList.EditValue == null)
			{
				MessageBox.Show("Vui lòng nhập mã dao!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (txbQuantity.Value == 0)
			{
				MessageBox.Show("Vui lòng nhập số lượng khác 0!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (cWorker.EditValue == null)
			{
				MessageBox.Show("Vui lòng chọn người phụ trách!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}


			if (string.IsNullOrEmpty(cKnifeList.Text)) {
				MessageBox.Show("Vui lòng chọn loại dao!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return true;
		}

		bool SaveData()
		{
			if (ValidateForm())
			{
				try
				{
					knifeProcessedList.KnifeCode = cKnifeList.Text.Trim();
					knifeProcessedList.KnifeID = TextUtils.ToInt(cKnifeList.EditValue);
					knifeProcessedList.WorkerID = TextUtils.ToInt(cWorker.EditValue);
					knifeProcessedList.DateProcess = DateTime.Now;
					knifeProcessedList.ProductCode = txbProductCode.Text.Trim();
					knifeProcessedList.MachineID = TextUtils.ToInt(cMachine.EditValue);
					knifeProcessedList.MachineCode = cMachine.Text.Trim();
					knifeProcessedList.Quantity = TextUtils.ToInt(txbQuantity.Value);

					string sql = "SELECT TOP 1 * FROM dbo.KnifeSharpeningDetails WHERE KnifeID = {0} ORDER BY DateSharpen DESC";
					DataTable arr = TextUtils.Select(sql);
					KnifeProcessedListBO.Instance.Insert(knifeProcessedList);
						return true;
				}
				catch (Exception ex)
				{
					return false;
				}
			}
			return false;
		}
		#endregion

		#region Events
		private void frmKnifeSharpenList_Load(object sender, EventArgs e)
		{
			LoadAllComboboxData();
			LoadData();
			if (knifeID != 0) {
				LoadDataToForm();
			}
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		#endregion

	

		private void timer1_Tick(object sender, EventArgs e)
		{
			txbTime.Text = string.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
		}

		private void cWorker_EditValueChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cWorker.Text))
			{
				DataRowView selectData = (DataRowView)cWorker.GetSelectedDataRow();
				string departmentCode = (string)selectData.Row.ItemArray[6];
				txbDepartmentCode.Text = departmentCode;
			}
		}

		private void frmKnifeSharpenList_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeProcessedList = new KnifeProcessedListModel();
				ClearFormData();
			}
		}

		private void cKnifeList_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cKnifeList.Text))
			{
				cKnifeList.BackColor = Color.White;
			}
			else {
				cKnifeList.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbProductCode_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbProductCode.Text))
			{
				txbProductCode.BackColor = Color.White;
			}
			else
			{
				txbProductCode.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void cMachine_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cMachine.Text))
			{
				cMachine.BackColor = Color.White;
			}
			else
			{
				cMachine.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void cWorker_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cWorker.Text))
			{
				cWorker.BackColor = Color.White;
			}
			else
			{
				cWorker.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbQuantity_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbQuantity.Text))
			{
				txbQuantity.BackColor = Color.White;
			}
			else
			{
				txbQuantity.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbDepartmentCode_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbDepartmentCode.Text))
			{
				txbDepartmentCode.BackColor = Color.White;
			}
			else
			{
				txbDepartmentCode.BackColor = Color.FromArgb(255, 153, 255);
			}
		}
	}
}
