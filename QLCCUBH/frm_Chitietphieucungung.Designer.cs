namespace QLCCUBH
{
    partial class frm_Chitietphieucungung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chitietphieucungung));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frm_chitietcungung = new System.Windows.Forms.DataGridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.combomahanghoa = new System.Windows.Forms.ComboBox();
            this.combosophieu = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonsave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtondelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonexist = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm_chitietcungung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1160, 568);
            this.groupControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(2, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frm_chitietcungung);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // frm_chitietcungung
            // 
            this.frm_chitietcungung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frm_chitietcungung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_chitietcungung.Location = new System.Drawing.Point(3, 19);
            this.frm_chitietcungung.Name = "frm_chitietcungung";
            this.frm_chitietcungung.RowHeadersWidth = 51;
            this.frm_chitietcungung.RowTemplate.Height = 24;
            this.frm_chitietcungung.Size = new System.Drawing.Size(1144, 304);
            this.frm_chitietcungung.TabIndex = 0;
            this.frm_chitietcungung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frm_chitietcungung_CellContentClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtthanhtien);
            this.layoutControl1.Controls.Add(this.txtsoluong);
            this.layoutControl1.Controls.Add(this.combomahanghoa);
            this.layoutControl1.Controls.Add(this.combosophieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(3, 19);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1150, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(662, 42);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(476, 25);
            this.txtthanhtien.TabIndex = 13;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(662, 12);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(476, 25);
            this.txtsoluong.TabIndex = 12;
            // 
            // combomahanghoa
            // 
            this.combomahanghoa.FormattingEnabled = true;
            this.combomahanghoa.Location = new System.Drawing.Point(98, 42);
            this.combomahanghoa.Name = "combomahanghoa";
            this.combomahanghoa.Size = new System.Drawing.Size(474, 24);
            this.combomahanghoa.TabIndex = 11;
            // 
            // combosophieu
            // 
            this.combosophieu.FormattingEnabled = true;
            this.combosophieu.Location = new System.Drawing.Point(98, 12);
            this.combosophieu.Name = "combosophieu";
            this.combosophieu.Size = new System.Drawing.Size(474, 24);
            this.combosophieu.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.BackgroundImageOptions.Image = global::QLCCUBH.Properties.Resources.login;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1150, 120);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.combosophieu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(564, 30);
            this.layoutControlItem1.Text = "Số phiếu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.combomahanghoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(564, 70);
            this.layoutControlItem3.Text = "Mã hàng hóa";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtsoluong;
            this.layoutControlItem5.Location = new System.Drawing.Point(564, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(566, 30);
            this.layoutControlItem5.Text = "Số lượng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtthanhtien;
            this.layoutControlItem2.Location = new System.Drawing.Point(564, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(566, 70);
            this.layoutControlItem2.Text = "Thành tiền";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 16);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1126, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu cung ứng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonsave,
            this.barButtondelete,
            this.barButtonancel,
            this.barButtonexist});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonsave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtondelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonexist, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonsave
            // 
            this.barButtonsave.Caption = "Save";
            this.barButtonsave.Id = 0;
            this.barButtonsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonsave.ImageOptions.Image")));
            this.barButtonsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonsave.ImageOptions.LargeImage")));
            this.barButtonsave.Name = "barButtonsave";
            this.barButtonsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonsave_ItemClick);
            // 
            // barButtondelete
            // 
            this.barButtondelete.Caption = "Delete";
            this.barButtondelete.Id = 1;
            this.barButtondelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtondelete.ImageOptions.Image")));
            this.barButtondelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtondelete.ImageOptions.LargeImage")));
            this.barButtondelete.Name = "barButtondelete";
            this.barButtondelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtondelete_ItemClick);
            // 
            // barButtonancel
            // 
            this.barButtonancel.Caption = "Cancel";
            this.barButtonancel.Id = 2;
            this.barButtonancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonancel.ImageOptions.Image")));
            this.barButtonancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonancel.ImageOptions.LargeImage")));
            this.barButtonancel.Name = "barButtonancel";
            this.barButtonancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonancel_ItemClick);
            // 
            // barButtonexist
            // 
            this.barButtonexist.Caption = "Exist";
            this.barButtonexist.Id = 3;
            this.barButtonexist.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonexist.ImageOptions.Image")));
            this.barButtonexist.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonexist.ImageOptions.LargeImage")));
            this.barButtonexist.Name = "barButtonexist";
            this.barButtonexist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonexist_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1160, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1160, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1160, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // frm_Chitietphieucungung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 618);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Chitietphieucungung";
            this.Text = "frm_Chitietphieucungung";
            this.Load += new System.EventHandler(this.frm_Chitietphieucungung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frm_chitietcungung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView frm_chitietcungung;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox combomahanghoa;
        private System.Windows.Forms.ComboBox combosophieu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonsave;
        private DevExpress.XtraBars.BarButtonItem barButtondelete;
        private DevExpress.XtraBars.BarButtonItem barButtonancel;
        private DevExpress.XtraBars.BarButtonItem barButtonexist;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}