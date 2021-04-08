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
	public partial class frmAddEditKnife : _Forms
	{
		#region Variables
		public KnifeDetailListModel knifeDetailListModel = new KnifeDetailListModel();
		private int _type = 1;
		#endregion

		#region Methods
		public frmAddEditKnife(int type)
		{
			InitializeComponent();
			if (type == cGlobalVariables.Add)
			{
				this.Text = "THÊM CÔNG CỤ";
				_type = cGlobalVariables.Add;
			}
			if (type == cGlobalVariables.Edit)
			{
				this.Text = "SỬA CÔNG CỤ";
				_type = cGlobalVariables.Edit;
			}
		}

		void LoadListUsers()
		{
			DataTable dt = TextUtils.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "UserCode", "FullName", "BirthOfDate", "DepartmentID", "DepartmentCode" }, "Users", "UserCode"));
			cWorker.Properties.DataSource = dt;
			cWorker.Properties.DisplayMember = "UserCode";
			cWorker.Properties.ValueMember = "ID";
		}
		void LoadDataToForm()
		{
			txbKnifeCode.Text = knifeDetailListModel.KnifeCode;
			cWorker.EditValue = knifeDetailListModel.WorkerID;
			txbKnifeName.Text = knifeDetailListModel.KnifeName;
			txbDescription.Text = knifeDetailListModel.Description;
			txbATC.Value = knifeDetailListModel.ATC;
			txbSTD.Value = knifeDetailListModel.STD;

			/*if (!string.IsNullOrEmpty(cWorker.Text)) { 
				DataRowView selectData = (DataRowView)cWorker.GetSelectedDataRow();
				string departmentCode = (string)selectData.Row.ItemArray[6];
				txbDepartmentCode.Text = departmentCode;
			}*/

	
		}

		bool ValidateForm()
		{
			if (txbKnifeCode.Text == "")
			{
				MessageBox.Show("Vui lòng nhập mã dao!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			/*if (txbKnifeName.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên dao!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}*/

			if (txbSTD.Value == 0 || txbATC.Value == 0)
			{
				MessageBox.Show("Vui lòng nhập dữ liệu ATC và STD khác 0!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (cWorker.EditValue == null)
			{
				MessageBox.Show("Vui lòng chọn người phụ trách!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}


			if (KnifeDetailListBO.Instance.CheckExist("KnifeCode", txbKnifeCode.Text))
			{
				if (_type == cGlobalVariables.Edit && txbKnifeCode.Text.Trim() != knifeDetailListModel.KnifeCode || _type == cGlobalVariables.Add)
				{
					MessageBox.Show("Mã dao đã tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
			}
			return true;
		}

		bool SaveData()
		{
			if (ValidateForm())
			{
				try
				{
					if (_type == cGlobalVariables.Add)
					{
						knifeDetailListModel.KnifeCode = txbKnifeCode.Text.Trim();
						knifeDetailListModel.WorkerID = TextUtils.ToInt(cWorker.EditValue);
						knifeDetailListModel.KnifeName = txbKnifeName.Text.Trim();
						knifeDetailListModel.ImportedDate = DateTime.Now;
						knifeDetailListModel.ATC = TextUtils.ToInt(txbATC.Value);
						knifeDetailListModel.STD = TextUtils.ToInt(txbSTD.Value);
						knifeDetailListModel.Description = txbDescription.Text;
						knifeDetailListModel.Status = true;
						KnifeDetailListBO.Instance.Insert(knifeDetailListModel);
						return true;
					}
					if (_type == cGlobalVariables.Edit)
					{
						knifeDetailListModel.KnifeCode = txbKnifeCode.Text.Trim();
						knifeDetailListModel.WorkerID = TextUtils.ToInt(cWorker.EditValue);
						knifeDetailListModel.KnifeName = txbKnifeName.Text.Trim();
						knifeDetailListModel.ImportedDate = DateTime.Now;
						knifeDetailListModel.ATC = TextUtils.ToInt(txbATC.Value);
						knifeDetailListModel.STD = TextUtils.ToInt(txbSTD.Value);
						knifeDetailListModel.Description = txbDescription.Text;

						TextUtils.ExcuteProcedure("spKnifeDetailUpdate",
									new string[] { "@id", "@knifeCode", "@knifeName", "@description", "@std", "@atc", "@workerID"},
									new object[] { knifeDetailListModel.ID, knifeDetailListModel.KnifeCode, knifeDetailListModel.KnifeName, knifeDetailListModel.Description, knifeDetailListModel.STD, knifeDetailListModel.ATC, knifeDetailListModel.WorkerID });

						return true;
					}
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
		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveClose_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeDetailListModel = new KnifeDetailListModel();
				this.Text = "THÊM CÔNG CỤ";
				_type = cGlobalVariables.Add;
				LoadDataToForm();
			}
		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				this.DialogResult = DialogResult.OK;
			}
		}

		private void frmAddEditKnife_Load(object sender, EventArgs e)
		{
			LoadListUsers();
			LoadDataToForm();
		}

		private void frmAddEditKnife_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
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

		#endregion

	}
}
