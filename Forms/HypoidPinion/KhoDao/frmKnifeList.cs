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
	public partial class frmKnifeList : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Methods
		public frmKnifeList()
		{
			InitializeComponent();
		}
		void LoadData() {
			string sql = "SELECT KnifeDetailList.*, Users.UserCode, Users.DepartmentCode FROM dbo.KnifeDetailList, dbo.Users WHERE dbo.KnifeDetailList.WorkerID = dbo.Users.ID AND KnifeDetailList.Status = 1";
			DataTable arr = TextUtils.Select(sql);
			dtgvKnife.DataSource = arr;
		}

		void LoadUnavailableData()
		{
			string sql = "SELECT KnifeDetailList.*, Users.UserCode, Users.DepartmentCode FROM dbo.KnifeDetailList, dbo.Users WHERE dbo.KnifeDetailList.WorkerID = dbo.Users.ID AND KnifeDetailList.Status = 0";
			DataTable arr = TextUtils.Select(sql);
			dtgvKnife.DataSource = arr;
		}
		#endregion

		#region Events
		private void btnCreateKnife_Click(object sender, EventArgs e)
		{
			frmAddEditKnife frm = new frmAddEditKnife(cGlobalVariables.Add);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
			}
		}

		private void btnEditKnife_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvKnife.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvKnife.GetSelectedRows()[0];
			KnifeDetailListModel model = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(id);

			frmAddEditKnife frm = new frmAddEditKnife(cGlobalVariables.Edit);
			frm.knifeDetailListModel = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
				gvKnife.FocusedRowHandle = prevRow;

			}
		}

		private void btnDelKnife_Click(object sender, EventArgs e)
		{
			if (!gvKnife.IsDataRow(gvKnife.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvKnife.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvKnife.GetFocusedRowCellValue("KnifeCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa công đoạn [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (KnifeSharpeningDetailsBO.Instance.CheckExist("KnifeID", strID))
					{
						MessageBox.Show("Dao đã được sử dụng! Vui lòng chọn hủy dao thay cho xóa", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						KnifeDetailListBO.Instance.Delete(strID);
						gvKnife.DeleteRow(gvKnife.FocusedRowHandle);
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
			cbShowUnavailable_CheckedChanged(null, null);
		}

		private void frmKnifeList_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void gvKnife_DoubleClick(object sender, EventArgs e)
		{
			btnEditKnife_Click(null, null);
		}

		private void cbShowUnavailable_CheckedChanged(object sender, EventArgs e)
		{
			if (cbShowUnavailable.Checked)
			{
				LoadUnavailableData();
			}
			else { 
				LoadData();
			}
		}

		private void btnDisposeTool_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvKnife.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvKnife.GetSelectedRows()[0];
			frmKnifeDisposed frm = new frmKnifeDisposed();
			frm.knifeID = id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
				gvKnife.FocusedRowHandle = prevRow;

			}
		}
		private void btnSharpenKnife_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvKnife.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvKnife.GetSelectedRows()[0];
			frmKnifeSharpen frm = new frmKnifeSharpen();
			frm.knifeID = id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
				gvKnife.FocusedRowHandle = prevRow;

			}
		}

		private void btnProcessTool_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvKnife.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvKnife.GetSelectedRows()[0];
			frmKnifeProcessedList frm = new frmKnifeProcessedList();
			frm.knifeID = id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
				gvKnife.FocusedRowHandle = prevRow;

			}
		}
		#endregion


	}
}
