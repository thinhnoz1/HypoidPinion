
namespace BMS
{
	partial class frmAddEditStageHyp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditStageHyp));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbManager = new DevExpress.XtraEditors.LookUpEdit();
			this.txbStageCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cDepartment = new DevExpress.XtraEditors.LookUpEdit();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catVaThemOiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMenu.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbManager.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cDepartment.Properties)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveClose,
            this.toolStripSeparator2,
            this.btnSaveNew});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(845, 50);
			this.mnuMenu.TabIndex = 225;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveClose.ForeColor = System.Drawing.Color.Black;
			this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
			this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(109, 44);
			this.btnSaveClose.Tag = "frmProduct_AddProductH";
			this.btnSaveClose.Text = "Cất && Đóng";
			this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSaveNew
			// 
			this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveNew.ForeColor = System.Drawing.Color.Black;
			this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
			this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new System.Drawing.Size(148, 44);
			this.btnSaveNew.Tag = "frmProduct_AddProductH";
			this.btnSaveNew.Text = "Cất && Thêm mới";
			this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2533F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.7467F));
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.cbManager, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.txbStageCode, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.cDepartment, 1, 2);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 52);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.14286F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(836, 178);
			this.tableLayoutPanel3.TabIndex = 227;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(3, 119);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 56);
			this.label1.TabIndex = 225;
			this.label1.Text = "Bộ phận";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbManager
			// 
			this.cbManager.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbManager.Location = new System.Drawing.Point(281, 63);
			this.cbManager.Margin = new System.Windows.Forms.Padding(0);
			this.cbManager.Name = "cbManager";
			this.cbManager.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
			this.cbManager.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.cbManager.Properties.Appearance.Options.UseFont = true;
			this.cbManager.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbManager.Properties.AppearanceDropDown.Options.UseFont = true;
			this.cbManager.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbManager.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.cbManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbManager.Properties.NullText = "";
			this.cbManager.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cbManager.Size = new System.Drawing.Size(552, 52);
			this.cbManager.TabIndex = 224;
			// 
			// txbStageCode
			// 
			this.txbStageCode.BackColor = System.Drawing.Color.White;
			this.txbStageCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbStageCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbStageCode.Location = new System.Drawing.Point(281, 3);
			this.txbStageCode.Margin = new System.Windows.Forms.Padding(0);
			this.txbStageCode.Name = "txbStageCode";
			this.txbStageCode.Size = new System.Drawing.Size(552, 53);
			this.txbStageCode.TabIndex = 217;
			this.txbStageCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(3, 63);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(275, 53);
			this.label5.TabIndex = 221;
			this.label5.Text = "Người phụ trách";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(275, 57);
			this.label2.TabIndex = 218;
			this.label2.Text = "Mã công đoạn";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cDepartment
			// 
			this.cDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cDepartment.Location = new System.Drawing.Point(281, 119);
			this.cDepartment.Margin = new System.Windows.Forms.Padding(0);
			this.cDepartment.Name = "cDepartment";
			this.cDepartment.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
			this.cDepartment.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.cDepartment.Properties.Appearance.Options.UseFont = true;
			this.cDepartment.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cDepartment.Properties.AppearanceDropDown.Options.UseFont = true;
			this.cDepartment.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cDepartment.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.cDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cDepartment.Properties.NullText = "";
			this.cDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cDepartment.Size = new System.Drawing.Size(552, 52);
			this.cDepartment.TabIndex = 227;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấtToolStripMenuItem,
            this.catVaThemOiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(345, 9);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(171, 28);
			this.menuStrip1.TabIndex = 228;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// cấtToolStripMenuItem
			// 
			this.cấtToolStripMenuItem.Name = "cấtToolStripMenuItem";
			this.cấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cấtToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
			this.cấtToolStripMenuItem.Text = "Cất";
			this.cấtToolStripMenuItem.Click += new System.EventHandler(this.cấtToolStripMenuItem_Click);
			// 
			// catVaThemOiToolStripMenuItem
			// 
			this.catVaThemOiToolStripMenuItem.Name = "catVaThemOiToolStripMenuItem";
			this.catVaThemOiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.catVaThemOiToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
			this.catVaThemOiToolStripMenuItem.Text = "Cat va them oi";
			this.catVaThemOiToolStripMenuItem.Click += new System.EventHandler(this.catVaThemOiToolStripMenuItem_Click);
			// 
			// frmAddEditStageHyp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 234);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.mnuMenu);
			this.Name = "frmAddEditStageHyp";
			this.Text = "frmAddEditStageHyp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditStageHyp_FormClosing);
			this.Load += new System.EventHandler(this.frmAddEditStageHyp_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbManager.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cDepartment.Properties)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnSaveClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSaveNew;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.LookUpEdit cbManager;
		private System.Windows.Forms.TextBox txbStageCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.LookUpEdit cDepartment;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catVaThemOiToolStripMenuItem;
	}
}