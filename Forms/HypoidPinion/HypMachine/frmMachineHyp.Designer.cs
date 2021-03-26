
namespace BMS
{
	partial class frmMachineHyp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMachineHyp));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreate = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.dtgvMachine = new DevExpress.XtraGrid.GridControl();
			this.gvMachine = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMachineCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStageID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStageCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMachine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMachine)).BeginInit();
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
			// dtgvMachine
			// 
			this.dtgvMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvMachine.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvMachine.Location = new System.Drawing.Point(4, 56);
			this.dtgvMachine.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvMachine.MainView = this.gvMachine;
			this.dtgvMachine.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMachine.Name = "dtgvMachine";
			this.dtgvMachine.Size = new System.Drawing.Size(1285, 596);
			this.dtgvMachine.TabIndex = 37;
			this.dtgvMachine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMachine});
			// 
			// gvMachine
			// 
			this.gvMachine.ColumnPanelRowHeight = 40;
			this.gvMachine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMachineCode,
            this.colSTT,
            this.colStageID,
            this.colStageCode});
			this.gvMachine.GridControl = this.dtgvMachine;
			this.gvMachine.Name = "gvMachine";
			this.gvMachine.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMachine.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMachine.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvMachine.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvMachine.OptionsBehavior.Editable = false;
			this.gvMachine.OptionsCustomization.AllowColumnMoving = false;
			this.gvMachine.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvMachine.OptionsFind.AlwaysVisible = true;
			this.gvMachine.OptionsFind.ShowCloseButton = false;
			this.gvMachine.OptionsView.ShowGroupPanel = false;
			this.gvMachine.RowHeight = 25;
			this.gvMachine.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvMachine.DoubleClick += new System.EventHandler(this.gvMachine_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colMachineCode
			// 
			this.colMachineCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colMachineCode.AppearanceCell.Options.UseFont = true;
			this.colMachineCode.AppearanceCell.Options.UseTextOptions = true;
			this.colMachineCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMachineCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMachineCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMachineCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colMachineCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colMachineCode.AppearanceHeader.Options.UseFont = true;
			this.colMachineCode.AppearanceHeader.Options.UseForeColor = true;
			this.colMachineCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colMachineCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMachineCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMachineCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMachineCode.Caption = "MÃ MÁY";
			this.colMachineCode.FieldName = "MachineCode";
			this.colMachineCode.Name = "colMachineCode";
			this.colMachineCode.OptionsColumn.AllowEdit = false;
			this.colMachineCode.Visible = true;
			this.colMachineCode.VisibleIndex = 1;
			this.colMachineCode.Width = 624;
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
			this.colSTT.Width = 173;
			// 
			// colStageID
			// 
			this.colStageID.Caption = "gridColumn1";
			this.colStageID.FieldName = "StageID";
			this.colStageID.Name = "colStageID";
			// 
			// colStageCode
			// 
			this.colStageCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStageCode.AppearanceCell.Options.UseFont = true;
			this.colStageCode.AppearanceCell.Options.UseTextOptions = true;
			this.colStageCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStageCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStageCode.AppearanceHeader.Options.UseFont = true;
			this.colStageCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colStageCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStageCode.Caption = "MÃ CÔNG ĐOẠN";
			this.colStageCode.FieldName = "StageCode";
			this.colStageCode.Name = "colStageCode";
			this.colStageCode.Visible = true;
			this.colStageCode.VisibleIndex = 2;
			this.colStageCode.Width = 470;
			// 
			// frmMachineHyp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 656);
			this.Controls.Add(this.dtgvMachine);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmMachineHyp";
			this.Text = "QUẢN LÝ MÁY";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMachineHyp_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMachine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMachine)).EndInit();
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
		private DevExpress.XtraGrid.GridControl dtgvMachine;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMachine;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colMachineCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colStageID;
		private DevExpress.XtraGrid.Columns.GridColumn colStageCode;
	}
}