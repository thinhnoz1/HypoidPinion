﻿
namespace BMS
{
	partial class frmStageHyp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStageHyp));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreate = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.dtgvStage = new DevExpress.XtraGrid.GridControl();
			this.gvStage = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStageCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvStage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvStage)).BeginInit();
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
			this.toolStrip1.TabIndex = 30;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.Black;
			this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
			this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(136, 44);
			this.btnCreate.Tag = "frmProduct_AddProductH";
			this.btnCreate.Text = "Tạo công đoạn";
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
			this.btnEdit.Size = new System.Drawing.Size(137, 44);
			this.btnEdit.Tag = "frmProduct_EditProductH";
			this.btnEdit.Text = "Sửa công đoạn";
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
			this.btnDel.Size = new System.Drawing.Size(137, 44);
			this.btnDel.Tag = "frmProduct_DeleteProductH";
			this.btnDel.Text = "Xóa công đoạn";
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
			// dtgvStage
			// 
			this.dtgvStage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvStage.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvStage.Location = new System.Drawing.Point(4, 56);
			this.dtgvStage.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvStage.MainView = this.gvStage;
			this.dtgvStage.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvStage.Name = "dtgvStage";
			this.dtgvStage.Size = new System.Drawing.Size(1285, 596);
			this.dtgvStage.TabIndex = 37;
			this.dtgvStage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStage});
			// 
			// gvStage
			// 
			this.gvStage.ColumnPanelRowHeight = 40;
			this.gvStage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStageCode,
            this.colManagerID,
            this.colManagerCode,
            this.colSTT,
            this.colDepartmentID,
            this.colDepartmentCode});
			this.gvStage.GridControl = this.dtgvStage;
			this.gvStage.Name = "gvStage";
			this.gvStage.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvStage.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvStage.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvStage.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvStage.OptionsBehavior.Editable = false;
			this.gvStage.OptionsCustomization.AllowColumnMoving = false;
			this.gvStage.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvStage.OptionsFind.AlwaysVisible = true;
			this.gvStage.OptionsFind.ShowCloseButton = false;
			this.gvStage.OptionsView.ShowGroupPanel = false;
			this.gvStage.RowHeight = 25;
			this.gvStage.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvStage.DoubleClick += new System.EventHandler(this.gvStage_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colStageCode
			// 
			this.colStageCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStageCode.AppearanceCell.Options.UseFont = true;
			this.colStageCode.AppearanceCell.Options.UseTextOptions = true;
			this.colStageCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStageCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStageCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStageCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStageCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colStageCode.AppearanceHeader.Options.UseFont = true;
			this.colStageCode.AppearanceHeader.Options.UseForeColor = true;
			this.colStageCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colStageCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStageCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStageCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStageCode.Caption = "MÃ CÔNG ĐOẠN";
			this.colStageCode.FieldName = "StageCode";
			this.colStageCode.Name = "colStageCode";
			this.colStageCode.OptionsColumn.AllowEdit = false;
			this.colStageCode.Visible = true;
			this.colStageCode.VisibleIndex = 1;
			this.colStageCode.Width = 426;
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
			// colDepartmentID
			// 
			this.colDepartmentID.Caption = "gridColumn1";
			this.colDepartmentID.FieldName = "DepartmentID";
			this.colDepartmentID.Name = "colDepartmentID";
			// 
			// colDepartmentCode
			// 
			this.colDepartmentCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDepartmentCode.AppearanceCell.Options.UseFont = true;
			this.colDepartmentCode.AppearanceCell.Options.UseTextOptions = true;
			this.colDepartmentCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDepartmentCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDepartmentCode.AppearanceHeader.Options.UseFont = true;
			this.colDepartmentCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colDepartmentCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDepartmentCode.Caption = "MÃ BỘ PHẬN";
			this.colDepartmentCode.FieldName = "DepartmentCode";
			this.colDepartmentCode.Name = "colDepartmentCode";
			this.colDepartmentCode.Visible = true;
			this.colDepartmentCode.VisibleIndex = 2;
			this.colDepartmentCode.Width = 251;
			// 
			// frmStageHyp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 656);
			this.Controls.Add(this.dtgvStage);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmStageHyp";
			this.Text = "QUẢN LÝ CÔNG ĐOẠN";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStageHyp_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvStage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvStage)).EndInit();
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
		private DevExpress.XtraGrid.GridControl dtgvStage;
		private DevExpress.XtraGrid.Views.Grid.GridView gvStage;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colStageCode;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerID;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartmentCode;
	}
}