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
	public partial class frmAreas : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Method
		public frmAreas()
		{
			InitializeComponent();
		}

		void LoadData()
		{
			DataTable arr = TextUtils.Select(cGlobalFunction.GetAllQuery("Area", "ID"));
			dtgvArea.DataSource = arr;
		}
		#endregion

		#region Event
		private void frmAreas_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void btnCreate_Click(object sender, EventArgs e)
		{
			frmAddEditAreas frm = new frmAddEditAreas(cGlobalVariables.Add);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvArea.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvArea.GetSelectedRows()[0];
			AreaModel model = (AreaModel)AreaBO.Instance.FindByPK(id);

			frmAddEditAreas frm = new frmAddEditAreas(cGlobalVariables.Edit);
			frm.areaModel = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				gvArea.FocusedRowHandle = prevRow;
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (!gvArea.IsDataRow(gvArea.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvArea.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvArea.GetFocusedRowCellValue("AreaCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa khu vực [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (DepartmentBO.Instance.CheckExist("AreaID", strID))
					{
						MessageBox.Show("Khu vực này đã tồn tại các bộ phận trực thuộc!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						AreaBO.Instance.Delete(strID);
						gvArea.DeleteRow(gvArea.FocusedRowHandle);
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
		private void gvArea_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(null, null);
		}
		#endregion

	}
}
