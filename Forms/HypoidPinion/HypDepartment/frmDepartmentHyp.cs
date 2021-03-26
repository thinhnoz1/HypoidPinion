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
	public partial class frmDepartmentHyp : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Method
		public frmDepartmentHyp()
		{
			InitializeComponent();
			LoadData();
		}

		void LoadData() {
			DataTable arr = TextUtils.Select(cGlobalFunction.GetAllQuery("Department", "DepartmentCode"));
			dtgvDepartment.DataSource = arr;
		}
		#endregion

		#region Event
		private void btnCreate_Click(object sender, EventArgs e)
		{
			frmAddEditDepartment frm = new frmAddEditDepartment(cGlobalVariables.Add);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvDepartment.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvDepartment.GetSelectedRows()[0];
			DepartmentModel model = (DepartmentModel)DepartmentBO.Instance.FindByPK(id);

			frmAddEditDepartment frm = new frmAddEditDepartment(cGlobalVariables.Edit);
			frm.departmentModel = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				gvDepartment.FocusedRowHandle = prevRow;
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (!gvDepartment.IsDataRow(gvDepartment.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvDepartment.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvDepartment.GetFocusedRowCellValue("DepartmentCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa bộ phận [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (StageBO.Instance.CheckExist("DepartmentID", strID))
					{
						MessageBox.Show("Bộ phận này đã tồn tại các công đoạn trực thuộc!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						DepartmentBO.Instance.Delete(strID);
						gvDepartment.DeleteRow(gvDepartment.FocusedRowHandle);
						MessageBox.Show("Xoá thành công", TextUtils.Caption);
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void frmDepartmentHyp_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void gvDepartment_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(null, null);
		}
		#endregion

	}
}
