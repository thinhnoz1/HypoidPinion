
namespace BMS
{
	partial class frmDepartmentHyp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentHyp));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreate = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.dtgvDepartment = new DevExpress.XtraGrid.GridControl();
			this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAreaID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAreaCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.toolStripSeparator1,
            this.btnEdit,
            this.toolStripSeparator7,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1293, 52);
			this.toolStrip1.TabIndex = 29;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.Black;
			this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
			this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(116, 44);
			this.btnCreate.Tag = "frmProduct_AddProductH";
			this.btnCreate.Text = "Tạo bộ phận";
			this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.Black;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(117, 44);
			this.btnEdit.Tag = "frmProduct_EditProductH";
			this.btnEdit.Text = "Sửa bộ phận";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.ForeColor = System.Drawing.Color.Black;
			this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
			this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(117, 44);
			this.btnDel.Tag = "frmProduct_DeleteProductH";
			this.btnDel.Text = "Xóa bộ phận";
			this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = false;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(91, 44);
			this.btnRefresh.Tag = "";
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// dtgvDepartment
			// 
			this.dtgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvDepartment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvDepartment.Location = new System.Drawing.Point(4, 56);
			this.dtgvDepartment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvDepartment.MainView = this.gvDepartment;
			this.dtgvDepartment.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvDepartment.Name = "dtgvDepartment";
			this.dtgvDepartment.Size = new System.Drawing.Size(1285, 596);
			this.dtgvDepartment.TabIndex = 36;
			this.dtgvDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
			// 
			// gvDepartment
			// 
			this.gvDepartment.ColumnPanelRowHeight = 40;
			this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDepartmentCode,
            this.colManagerID,
            this.colManagerCode,
            this.colSTT,
            this.colAreaID,
            this.colAreaCode});
			this.gvDepartment.GridControl = this.dtgvDepartment;
			this.gvDepartment.Name = "gvDepartment";
			this.gvDepartment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvDepartment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvDepartment.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvDepartment.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvDepartment.OptionsBehavior.Editable = false;
			this.gvDepartment.OptionsCustomization.AllowColumnMoving = false;
			this.gvDepartment.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvDepartment.OptionsFind.AlwaysVisible = true;
			this.gvDepartment.OptionsFind.ShowCloseButton = false;
			this.gvDepartment.OptionsView.ShowGroupPanel = false;
			this.gvDepartment.RowHeight = 25;
			this.gvDepartment.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvDepartment.DoubleClick += new System.EventHandler(this.gvDepartment_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colDepartmentCode
			// 
			this.colDepartmentCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDepartmentCode.AppearanceCell.Options.UseFont = true;
			this.colDepartmentCode.AppearanceCell.Options.UseTextOptions = true;
			this.colDepartmentCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDepartmentCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDepartmentCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDepartmentCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDepartmentCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colDepartmentCode.AppearanceHeader.Options.UseFont = true;
			this.colDepartmentCode.AppearanceHeader.Options.UseForeColor = true;
			this.colDepartmentCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colDepartmentCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDepartmentCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDepartmentCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDepartmentCode.Caption = "MÃ BỘ PHẬN";
			this.colDepartmentCode.FieldName = "DepartmentCode";
			this.colDepartmentCode.Name = "colDepartmentCode";
			this.colDepartmentCode.OptionsColumn.AllowEdit = false;
			this.colDepartmentCode.Visible = true;
			this.colDepartmentCode.VisibleIndex = 1;
			this.colDepartmentCode.Width = 426;
			// 
			// colManagerID
			// 
			this.colManagerID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colManagerID.AppearanceCell.Options.UseFont = true;
			this.colManagerID.AppearanceCell.Options.UseTextOptions = true;
			this.colManagerID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colManagerID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colManagerID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colManagerID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colManagerID.AppearanceHeader.Options.UseFont = true;
			this.colManagerID.AppearanceHeader.Options.UseForeColor = true;
			this.colManagerID.AppearanceHeader.Options.UseTextOptions = true;
			this.colManagerID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colManagerID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colManagerID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colManagerID.Caption = "Mô tả";
			this.colManagerID.FieldName = "ManagerID";
			this.colManagerID.Name = "colManagerID";
			this.colManagerID.OptionsColumn.AllowEdit = false;
			this.colManagerID.Width = 338;
			// 
			// colManagerCode
			// 
			this.colManagerCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colManagerCode.AppearanceCell.Options.UseFont = true;
			this.colManagerCode.AppearanceCell.Options.UseTextOptions = true;
			this.colManagerCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colManagerCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colManagerCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colManagerCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colManagerCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colManagerCode.AppearanceHeader.Options.UseFont = true;
			this.colManagerCode.AppearanceHeader.Options.UseForeColor = true;
			this.colManagerCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colManagerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colManagerCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colManagerCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colManagerCode.Caption = "NGƯỜI PHỤ TRÁCH";
			this.colManagerCode.FieldName = "ManagerCode";
			this.colManagerCode.Name = "colManagerCode";
			this.colManagerCode.OptionsColumn.AllowEdit = false;
			this.colManagerCode.Visible = true;
			this.colManagerCode.VisibleIndex = 3;
			this.colManagerCode.Width = 439;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSTT.AppearanceCell.Options.UseFont = true;
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseForeColor = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.Visible = true;
			this.colSTT.VisibleIndex = 0;
			this.colSTT.Width = 151;
			// 
			// colAreaID
			// 
			this.colAreaID.Caption = "gridColumn1";
			this.colAreaID.FieldName = "AreaID";
			this.colAreaID.Name = "colAreaID";
			// 
			// colAreaCode
			// 
			this.colAreaCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colAreaCode.AppearanceCell.Options.UseFont = true;
			this.colAreaCode.AppearanceCell.Options.UseTextOptions = true;
			this.colAreaCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAreaCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colAreaCode.AppearanceHeader.Options.UseFont = true;
			this.colAreaCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colAreaCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAreaCode.Caption = "MÃ KHU VỰC";
			this.colAreaCode.FieldName = "AreaCode";
			this.colAreaCode.Name = "colAreaCode";
			this.colAreaCode.Visible = true;
			this.colAreaCode.VisibleIndex = 2;
			this.colAreaCode.Width = 251;
			// 
			// frmDepartmentHyp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 656);
			this.Controls.Add(this.dtgvDepartment);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmDepartmentHyp";
			this.Text = "QUẢN LÝ BỘ PHẬN";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDepartmentHyp_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCreate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton btnDel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private DevExpress.XtraGrid.GridControl dtgvDepartment;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartmentCode;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerID;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colAreaID;
		private DevExpress.XtraGrid.Columns.GridColumn colAreaCode;
	}
}