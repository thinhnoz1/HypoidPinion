
namespace BMS
{
	partial class frmAreas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreate = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgvArea = new DevExpress.XtraGrid.GridControl();
			this.gvArea = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAreaCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManagerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvArea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvArea)).BeginInit();
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
			this.toolStrip1.TabIndex = 28;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.Black;
			this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
			this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(114, 44);
			this.btnCreate.Tag = "frmProduct_AddProductH";
			this.btnCreate.Text = "Tạo khu vực";
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
			this.btnEdit.Size = new System.Drawing.Size(115, 44);
			this.btnEdit.Tag = "frmProduct_EditProductH";
			this.btnEdit.Text = "Sửa khu vực";
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
			this.btnDel.Size = new System.Drawing.Size(115, 44);
			this.btnDel.Tag = "frmProduct_DeleteProductH";
			this.btnDel.Text = "Xóa khu vực";
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
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dtgvArea);
			this.panel1.Location = new System.Drawing.Point(0, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1293, 604);
			this.panel1.TabIndex = 29;
			// 
			// dtgvArea
			// 
			this.dtgvArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvArea.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvArea.Location = new System.Drawing.Point(4, 4);
			this.dtgvArea.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvArea.MainView = this.gvArea;
			this.dtgvArea.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvArea.Name = "dtgvArea";
			this.dtgvArea.Size = new System.Drawing.Size(1285, 596);
			this.dtgvArea.TabIndex = 35;
			this.dtgvArea.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArea});
			// 
			// gvArea
			// 
			this.gvArea.ColumnPanelRowHeight = 40;
			this.gvArea.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAreaCode,
            this.colManagerID,
            this.colManagerCode,
            this.colSTT});
			this.gvArea.GridControl = this.dtgvArea;
			this.gvArea.Name = "gvArea";
			this.gvArea.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvArea.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvArea.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvArea.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvArea.OptionsBehavior.Editable = false;
			this.gvArea.OptionsCustomization.AllowColumnMoving = false;
			this.gvArea.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvArea.OptionsFind.AlwaysVisible = true;
			this.gvArea.OptionsFind.ShowCloseButton = false;
			this.gvArea.OptionsView.ShowGroupPanel = false;
			this.gvArea.RowHeight = 25;
			this.gvArea.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvArea.DoubleClick += new System.EventHandler(this.gvArea_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colAreaCode
			// 
			this.colAreaCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colAreaCode.AppearanceCell.Options.UseFont = true;
			this.colAreaCode.AppearanceCell.Options.UseTextOptions = true;
			this.colAreaCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAreaCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colAreaCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colAreaCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colAreaCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colAreaCode.AppearanceHeader.Options.UseFont = true;
			this.colAreaCode.AppearanceHeader.Options.UseForeColor = true;
			this.colAreaCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colAreaCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAreaCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colAreaCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colAreaCode.Caption = "MÃ VỊ TRÍ";
			this.colAreaCode.FieldName = "AreaCode";
			this.colAreaCode.Name = "colAreaCode";
			this.colAreaCode.OptionsColumn.AllowEdit = false;
			this.colAreaCode.Visible = true;
			this.colAreaCode.VisibleIndex = 1;
			this.colAreaCode.Width = 583;
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
			this.colManagerCode.VisibleIndex = 2;
			this.colManagerCode.Width = 524;
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
			this.colSTT.Width = 160;
			// 
			// frmAreas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 656);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmAreas";
			this.Text = "QUẢN LÝ KHU VỰC";
			this.Load += new System.EventHandler(this.frmAreas_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvArea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvArea)).EndInit();
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
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraGrid.GridControl dtgvArea;
		private DevExpress.XtraGrid.Views.Grid.GridView gvArea;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colAreaCode;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerID;
		private DevExpress.XtraGrid.Columns.GridColumn colManagerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
	}
}