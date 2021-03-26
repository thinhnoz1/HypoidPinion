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
	public partial class frmMachineHyp : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Method
		public frmMachineHyp()
		{
			InitializeComponent();
		}
		void LoadData()
		{
			DataTable arr = TextUtils.Select(cGlobalFunction.GetAllQuery("Machine", "MachineCode"));
			dtgvMachine.DataSource = arr;
		}
		#endregion

		#region Event
		private void btnCreate_Click(object sender, EventArgs e)
		{
			frmAddEditMachineHyp frm = new frmAddEditMachineHyp(cGlobalVariables.Add);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvMachine.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			prevRow = gvMachine.GetSelectedRows()[0];
			MachineModel model = (MachineModel)MachineBO.Instance.FindByPK(id);

			frmAddEditMachineHyp frm = new frmAddEditMachineHyp(cGlobalVariables.Edit);
			frm.machineModel = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				gvMachine.FocusedRowHandle = prevRow;
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (!gvMachine.IsDataRow(gvMachine.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvMachine.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvMachine.GetFocusedRowCellValue("MachineCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa máy [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MachineBO.Instance.Delete(strID);
					gvMachine.DeleteRow(gvMachine.FocusedRowHandle);
					MessageBox.Show("Xoá thành công", TextUtils.Caption);
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

		private void frmMachineHyp_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void gvMachine_DoubleClick(object sender, EventArgs e)
		{
			btnEdit_Click(null, null);
		}
		#endregion

	}
}
