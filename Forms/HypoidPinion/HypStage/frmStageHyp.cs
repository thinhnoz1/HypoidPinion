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
	public partial class frmStageHyp : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Method
		public frmStageHyp()
		{
			InitializeComponent();
			LoadData();
		}
		void LoadData()
		{
			DataTable arr = TextUtils.Select(cGlobalFunction.GetAllQuery("Stage", "StageCode"));
			dtgvStage.DataSource = arr;
		}
		#endregion

		#region Event
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (!gvStage.IsDataRow(gvStage.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvStage.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvStage.GetFocusedRowCellValue("StageCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa công đoạn [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (MachineBO.Instance.CheckExist("StageID", strID))
					{
						MessageBox.Show("Công đoạn này đã tồn tại các máy trực thuộc!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						StageBO.Instance.Delete(strID);
						gvStage.DeleteRow(gvStage.FocusedRowHandle);
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvStage.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvStage.GetSelectedRows()[0];
			StageModel model = (StageModel)StageBO.Instance.FindByPK(id);

			frmAddEditStageHyp frm = new frmAddEditStageHyp(cGlobalVariables.Edit);
			frm.stageModel = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				gvStage.FocusedRowHandle = prevRow;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			frmAddEditStageHyp frm = new frmAddEditStageHyp(cGlobalVariables.Add);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void frmStageHyp_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void gvStage_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(null, null);
		}
		#endregion

	}
}
