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
	public partial class frmKnifeSharpen : _Forms
	{
		#region Variables
		private KnifeSharpeningDetailsModel knifeSharpeningModel = new KnifeSharpeningDetailsModel();
		public int knifeID = 0;
		int prevRow;
		#endregion

		#region Methods
		public frmKnifeSharpen()
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
			string sql = "SELECT ID, KnifeCode, STD, ATC, CurrentSTD, CurrentATC FROM dbo.KnifeDetailList WHERE Status = 1";
			DataTable dt = TextUtils.Select(sql);
			cKnifeList.Properties.DataSource = dt;
			cKnifeList.Properties.DisplayMember = "KnifeCode";
			cKnifeList.Properties.ValueMember = "ID";
		}

		void LoadData()
		{
			string sql = "SELECT kdl.*, u.UserCode, u.DepartmentCode FROM dbo.KnifeSharpeningDetails AS kdl, dbo.Users AS u WHERE kdl.WorkerID = u.ID";
			DataTable arr = TextUtils.Select(sql);
			dtgvKnifeSharpen.DataSource = arr;
		}

		void LoadDataToForm()
		{
			cKnifeList.EditValue = knifeID;
		}

		void ClearFormData()
		{
			cKnifeList.EditValue = 0;
			txbSTD.Text = "";
			txbATC.Text = "";
		}

		bool ValidateForm()
		{
			
			if (cWorker.EditValue == null)
			{
				MessageBox.Show("Vui lòng chọn người phụ trách!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}


			if (string.IsNullOrEmpty(cKnifeList.Text))
			{
				MessageBox.Show("Vui lòng chọn loại dao!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			DataRowView selectData = (DataRowView)cKnifeList.GetSelectedDataRow();
			int std = TextUtils.ToInt(selectData.Row.ItemArray[2]);
			int atc = TextUtils.ToInt(selectData.Row.ItemArray[3]);
			int currentSTD = TextUtils.ToInt(selectData.Row.ItemArray[4]);
			int currentATC = TextUtils.ToInt(selectData.Row.ItemArray[5]);
			if (currentATC == atc)
			{
				if (MessageBox.Show("Mã dao này không thể tiếp tục sử dụng! \n Bạn có muốn hủy mã dao này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					// Huy dao
					frmKnifeDisposed frm = new frmKnifeDisposed();
					frm.knifeID = TextUtils.ToInt(cKnifeList.EditValue);
					if (frm.ShowDialog() == DialogResult.OK)
					{
						knifeSharpeningModel = new KnifeSharpeningDetailsModel();
						ClearFormData();
						LoadData();
					}
				}
				return false;

			}

			/*if (currentModel.CurrentSTD == currentModel.STD)
			{
				if (MessageBox.Show("Mã dao này cần được mài trước khi sử dụng! \n Bạn có muốn mài mã dao này ngay bây giờ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					// Mai dao
					frmKnifeSharpen frm = new frmKnifeSharpen();
					frm.knifeID = TextUtils.ToInt(cKnifeList.EditValue);
					if (frm.ShowDialog() == DialogResult.OK)
					{

					}
				}
				return false;

			}*/
			return true;
		}

		bool SaveData()
		{
			if (ValidateForm())
			{
				try
				{
					knifeSharpeningModel.KnifeCode = cKnifeList.Text.Trim();
					knifeSharpeningModel.KnifeID = TextUtils.ToInt(cKnifeList.EditValue);
					knifeSharpeningModel.WorkerID = TextUtils.ToInt(cWorker.EditValue);


					TextUtils.ExcuteProcedure("spKnifeAddToSharpenQueue",
									new string[] { "@knifeCode", "@knifeID", "@workerID" },
									new object[] { knifeSharpeningModel.KnifeCode, knifeSharpeningModel.KnifeID, knifeSharpeningModel.WorkerID });
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Có lỗi trong quá trình xử lý!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
			}
			return false;
		}


		#endregion

		#region Events
		private void cKnifeList_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cKnifeList.Text))
			{
				cKnifeList.BackColor = Color.White;
			}
			else
			{
				cKnifeList.BackColor = Color.FromArgb(255, 153, 255);
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

		private void txbSTD_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbSTD.Text))
			{
				txbSTD.BackColor = Color.White;
			}
			else
			{
				txbSTD.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbATC_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbATC.Text))
			{
				txbATC.BackColor = Color.White;
			}
			else
			{
				txbATC.BackColor = Color.FromArgb(255, 153, 255);
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			txbTime.Text = string.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
		}

		private void frmKnifeSharpen_Load(object sender, EventArgs e)
		{
			LoadListUsers();
			LoadListKnifeList();
			LoadData();
			LoadDataToForm();
		}

		private void frmKnifeSharpen_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void cKnifeList_EditValueChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cKnifeList.Text))
			{
				//KnifeDetailListModel currentModel = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(TextUtils.ToInt64(cKnifeList.EditValue));
				DataRowView selectData = (DataRowView)cKnifeList.GetSelectedDataRow();
				string std = TextUtils.ToString(selectData.Row.ItemArray[2]);
				string atc = TextUtils.ToString(selectData.Row.ItemArray[3]);
				string currentSTD = TextUtils.ToString(selectData.Row.ItemArray[4]);
				string currentATC = TextUtils.ToString(selectData.Row.ItemArray[5]);
				txbSTD.Text = string.Format("{0} / {1}", currentSTD, std);
				txbATC.Text = string.Format("{0} / {1}", currentATC, atc);

			}
			cKnifeList_Leave(null, null);

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

		private void gvKnifeSharpen_DoubleClick(object sender, EventArgs e)
		{
			knifeID = TextUtils.ToInt(gvKnifeSharpen.GetFocusedRowCellValue(colKnifeID));
			if (knifeID == 0) return;
			LoadDataToForm();
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeSharpeningModel = new KnifeSharpeningDetailsModel();
				ClearFormData();
				LoadListKnifeList();
				LoadData();
			}
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}
		#endregion
	}
}
