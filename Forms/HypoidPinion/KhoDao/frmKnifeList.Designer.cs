
namespace BMS
{
	partial class frmKnifeList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKnifeList));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreateKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSharpenTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDisposeTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.dtgvKnife = new DevExpress.XtraGrid.GridControl();
			this.gvKnife = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKnifeCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKnifeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cbShowUnavailable = new System.Windows.Forms.CheckBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvKnife)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvKnife)).BeginInit();
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
            this.btnCreateKnife,
            this.toolStripSeparator1,
            this.btnEditKnife,
            this.toolStripSeparator7,
            this.btnDelKnife,
            this.toolStripSeparator2,
            this.btnSharpenTool,
            this.toolStripSeparator5,
            this.btnDisposeTool,
            this.toolStripSeparator3,
            this.btnRefresh,
            this.toolStripSeparator6});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(884, 42);
			this.toolStrip1.TabIndex = 32;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreateKnife
			// 
			this.btnCreateKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateKnife.ForeColor = System.Drawing.Color.Black;
			this.btnCreateKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateKnife.Image")));
			this.btnCreateKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreateKnife.Name = "btnCreateKnife";
			this.btnCreateKnife.Size = new System.Drawing.Size(103, 41);
			this.btnCreateKnife.Tag = "frmProduct_AddProductH";
			this.btnCreateKnife.Text = "Tạo dụng cụ";
			this.btnCreateKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCreateKnife.Click += new System.EventHandler(this.btnCreateKnife_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditKnife
			// 
			this.btnEditKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditKnife.ForeColor = System.Drawing.Color.Black;
			this.btnEditKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnEditKnife.Image")));
			this.btnEditKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditKnife.Name = "btnEditKnife";
			this.btnEditKnife.Size = new System.Drawing.Size(103, 41);
			this.btnEditKnife.Tag = "frmProduct_EditProductH";
			this.btnEditKnife.Text = "Sửa dụng cụ";
			this.btnEditKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditKnife.Click += new System.EventHandler(this.btnEditKnife_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelKnife
			// 
			this.btnDelKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelKnife.ForeColor = System.Drawing.Color.Black;
			this.btnDelKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnDelKnife.Image")));
			this.btnDelKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelKnife.Name = "btnDelKnife";
			this.btnDelKnife.Size = new System.Drawing.Size(103, 41);
			this.btnDelKnife.Tag = "frmProduct_DeleteProductH";
			this.btnDelKnife.Text = "Xóa dụng cụ";
			this.btnDelKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelKnife.Click += new System.EventHandler(this.btnDelKnife_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSharpenTool
			// 
			this.btnSharpenTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSharpenTool.ForeColor = System.Drawing.Color.Black;
			this.btnSharpenTool.Image = ((System.Drawing.Image)(resources.GetObject("btnSharpenTool.Image")));
			this.btnSharpenTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSharpenTool.Name = "btnSharpenTool";
			this.btnSharpenTool.Size = new System.Drawing.Size(100, 41);
			this.btnSharpenTool.Tag = "frmProduct_AddProductH";
			this.btnSharpenTool.Text = "Mài dụng cụ";
			this.btnSharpenTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSharpenTool.Click += new System.EventHandler(this.btnSharpenTool_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDisposeTool
			// 
			this.btnDisposeTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDisposeTool.ForeColor = System.Drawing.Color.Black;
			this.btnDisposeTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDisposeTool.Image")));
			this.btnDisposeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDisposeTool.Name = "btnDisposeTool";
			this.btnDisposeTool.Size = new System.Drawing.Size(103, 41);
			this.btnDisposeTool.Tag = "frmProduct_DeleteProductH";
			this.btnDisposeTool.Text = "Hủy dụng cụ";
			this.btnDisposeTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDisposeTool.Click += new System.EventHandler(this.btnDisposeTool_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
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
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.AutoSize = false;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
			// 
			// dtgvKnife
			// 
			this.dtgvKnife.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvKnife.Location = new System.Drawing.Point(0, 45);
			this.dtgvKnife.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvKnife.MainView = this.gvKnife;
			this.dtgvKnife.Name = "dtgvKnife";
			this.dtgvKnife.Size = new System.Drawing.Size(884, 384);
			this.dtgvKnife.TabIndex = 41;
			this.dtgvKnife.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKnife});
			// 
			// gvKnife
			// 
			this.gvKnife.ColumnPanelRowHeight = 40;
			this.gvKnife.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKnifeCode,
            this.colSTT,
            this.colWorkerID,
            this.colKnifeName,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colDepartmentID});
			this.gvKnife.GridControl = this.dtgvKnife;
			this.gvKnife.Name = "gvKnife";
			this.gvKnife.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnife.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnife.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnife.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvKnife.OptionsBehavior.Editable = false;
			this.gvKnife.OptionsCustomization.AllowColumnMoving = false;
			this.gvKnife.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvKnife.OptionsFind.AlwaysVisible = true;
			this.gvKnife.OptionsFind.ShowCloseButton = false;
			this.gvKnife.OptionsView.ShowGroupPanel = false;
			this.gvKnife.RowHeight = 25;
			this.gvKnife.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvKnife.DoubleClick += new System.EventHandler(this.gvKnife_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colKnifeCode
			// 
			this.colKnifeCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colKnifeCode.AppearanceCell.Options.UseFont = true;
			this.colKnifeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colKnifeCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colKnifeCode.AppearanceHeader.Options.UseFont = true;
			this.colKnifeCode.AppearanceHeader.Options.UseForeColor = true;
			this.colKnifeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.Caption = "MÃ DAO";
			this.colKnifeCode.FieldName = "KnifeCode";
			this.colKnifeCode.Name = "colKnifeCode";
			this.colKnifeCode.OptionsColumn.AllowEdit = false;
			this.colKnifeCode.Visible = true;
			this.colKnifeCode.VisibleIndex = 0;
			this.colKnifeCode.Width = 109;
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
			this.colSTT.Width = 173;
			// 
			// colWorkerID
			// 
			this.colWorkerID.Caption = "gridColumn1";
			this.colWorkerID.FieldName = "WorkerID";
			this.colWorkerID.Name = "colWorkerID";
			// 
			// colKnifeName
			// 
			this.colKnifeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colKnifeName.AppearanceCell.Options.UseFont = true;
			this.colKnifeName.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colKnifeName.AppearanceHeader.Options.UseFont = true;
			this.colKnifeName.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeName.Caption = "TÊN DAO";
			this.colKnifeName.FieldName = "KnifeName";
			this.colKnifeName.Name = "colKnifeName";
			this.colKnifeName.Visible = true;
			this.colKnifeName.VisibleIndex = 1;
			this.colKnifeName.Width = 107;
			// 
			// gridColumn2
			// 
			this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn2.AppearanceCell.Options.UseFont = true;
			this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn2.AppearanceHeader.Options.UseFont = true;
			this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn2.Caption = "NGÀY NHẬP";
			this.gridColumn2.FieldName = "ImportedDate";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 5;
			this.gridColumn2.Width = 127;
			// 
			// gridColumn3
			// 
			this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn3.AppearanceCell.Options.UseFont = true;
			this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn3.AppearanceHeader.Options.UseFont = true;
			this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn3.Caption = "MÔ TẢ";
			this.gridColumn3.FieldName = "Description";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 159;
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn1.AppearanceCell.Options.UseFont = true;
			this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn1.AppearanceHeader.Options.UseFont = true;
			this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.Caption = "STD";
			this.gridColumn1.FieldName = "STD";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 6;
			this.gridColumn1.Width = 52;
			// 
			// gridColumn4
			// 
			this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn4.AppearanceCell.Options.UseFont = true;
			this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn4.AppearanceHeader.Options.UseFont = true;
			this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn4.Caption = "ATC";
			this.gridColumn4.FieldName = "ATC";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 7;
			this.gridColumn4.Width = 76;
			// 
			// gridColumn5
			// 
			this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn5.AppearanceCell.Options.UseFont = true;
			this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn5.AppearanceHeader.Options.UseFont = true;
			this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn5.Caption = "NGƯỜI NHẬP";
			this.gridColumn5.FieldName = "UserCode";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 3;
			this.gridColumn5.Width = 150;
			// 
			// colDepartmentID
			// 
			this.colDepartmentID.Caption = "gridColumn6";
			this.colDepartmentID.FieldName = "DepartmentID";
			this.colDepartmentID.Name = "colDepartmentID";
			// 
			// gridColumn6
			// 
			this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn6.AppearanceCell.Options.UseFont = true;
			this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn6.AppearanceHeader.Options.UseFont = true;
			this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn6.Caption = "BỘ PHẬN";
			this.gridColumn6.FieldName = "DepartmentCode";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 4;
			this.gridColumn6.Width = 86;
			// 
			// cbShowUnavailable
			// 
			this.cbShowUnavailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbShowUnavailable.Location = new System.Drawing.Point(743, 8);
			this.cbShowUnavailable.Name = "cbShowUnavailable";
			this.cbShowUnavailable.Size = new System.Drawing.Size(138, 30);
			this.cbShowUnavailable.TabIndex = 0;
			this.cbShowUnavailable.Text = "Hiển thị những sản phẩm không khả dụng";
			this.cbShowUnavailable.UseVisualStyleBackColor = true;
			this.cbShowUnavailable.CheckedChanged += new System.EventHandler(this.cbShowUnavailable_CheckedChanged);
			// 
			// frmKnifeList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 431);
			this.Controls.Add(this.cbShowUnavailable);
			this.Controls.Add(this.dtgvKnife);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmKnifeList";
			this.Text = "DANH SÁCH KHO DAO";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmKnifeList_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvKnife)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvKnife)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCreateKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEditKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton btnDelKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSharpenTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnDisposeTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private DevExpress.XtraGrid.GridControl dtgvKnife;
		private DevExpress.XtraGrid.Views.Grid.GridView gvKnife;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colKnifeCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colWorkerID;
		private DevExpress.XtraGrid.Columns.GridColumn colKnifeName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
		private System.Windows.Forms.CheckBox cbShowUnavailable;
	}
}