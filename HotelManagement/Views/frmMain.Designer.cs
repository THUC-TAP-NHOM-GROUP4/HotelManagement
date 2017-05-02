namespace HotelManagement
{
    partial class frmMain
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup5 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup6 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTrangChu = new System.Windows.Forms.TabPage();
            this.galleryControl_TrangChu = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.tabPageQLKhach = new System.Windows.Forms.TabPage();
            this.tabPageDatPhong = new System.Windows.Forms.TabPage();
            this.tabPageQLPhong = new System.Windows.Forms.TabPage();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.nbgMain_TrangChu = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgMain_Khach = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgMain_DatPhong = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgMain_Phong = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgMain_ThongKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgMain_Thoat = new DevExpress.XtraNavBar.NavBarGroup();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.nbiMain_PhongTrong = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMain_PhongCoKhach = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMain_PhongKhac = new DevExpress.XtraNavBar.NavBarItem();
            this.galleryControl_DatPhong = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.tabControlMain.SuspendLayout();
            this.tabPageTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_TrangChu)).BeginInit();
            this.galleryControl_TrangChu.SuspendLayout();
            this.tabPageDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_DatPhong)).BeginInit();
            this.galleryControl_DatPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTrangChu);
            this.tabControlMain.Controls.Add(this.tabPageQLPhong);
            this.tabControlMain.Controls.Add(this.tabPageDatPhong);
            this.tabControlMain.Controls.Add(this.tabPageQLKhach);
            this.tabControlMain.Controls.Add(this.tabPageThongKe);
            this.tabControlMain.Location = new System.Drawing.Point(190, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(994, 613);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTrangChu
            // 
            this.tabPageTrangChu.Controls.Add(this.galleryControl_TrangChu);
            this.tabPageTrangChu.Location = new System.Drawing.Point(4, 24);
            this.tabPageTrangChu.Name = "tabPageTrangChu";
            this.tabPageTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrangChu.Size = new System.Drawing.Size(986, 585);
            this.tabPageTrangChu.TabIndex = 1;
            this.tabPageTrangChu.Text = "Trang chủ";
            this.tabPageTrangChu.UseVisualStyleBackColor = true;
            // 
            // galleryControl_TrangChu
            // 
            this.galleryControl_TrangChu.Controls.Add(this.galleryControlClient1);
            this.galleryControl_TrangChu.DesignGalleryGroupIndex = 0;
            this.galleryControl_TrangChu.DesignGalleryItemIndex = 0;
            this.galleryControl_TrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.galleryControl_TrangChu.Gallery.AllowHoverImages = true;
            this.galleryControl_TrangChu.Gallery.BackColor = System.Drawing.Color.White;
            galleryItemGroup5.Caption = "Danh sách phòng";
            this.galleryControl_TrangChu.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup5});
            this.galleryControl_TrangChu.Gallery.HoverImageSize = new System.Drawing.Size(60, 60);
            this.galleryControl_TrangChu.Gallery.ImageSize = new System.Drawing.Size(100, 100);
            this.galleryControl_TrangChu.Gallery.ShowItemText = true;
            this.galleryControl_TrangChu.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemDoubleClick);
            this.galleryControl_TrangChu.Location = new System.Drawing.Point(3, 3);
            this.galleryControl_TrangChu.Name = "galleryControl_TrangChu";
            this.galleryControl_TrangChu.Size = new System.Drawing.Size(980, 579);
            this.galleryControl_TrangChu.TabIndex = 0;
            this.galleryControl_TrangChu.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl_TrangChu;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(959, 575);
            // 
            // tabPageQLKhach
            // 
            this.tabPageQLKhach.Location = new System.Drawing.Point(4, 24);
            this.tabPageQLKhach.Name = "tabPageQLKhach";
            this.tabPageQLKhach.Size = new System.Drawing.Size(986, 585);
            this.tabPageQLKhach.TabIndex = 2;
            this.tabPageQLKhach.Text = "Quản Lý Khách";
            this.tabPageQLKhach.UseVisualStyleBackColor = true;
            // 
            // tabPageDatPhong
            // 
            this.tabPageDatPhong.Controls.Add(this.galleryControl_DatPhong);
            this.tabPageDatPhong.Location = new System.Drawing.Point(4, 24);
            this.tabPageDatPhong.Name = "tabPageDatPhong";
            this.tabPageDatPhong.Size = new System.Drawing.Size(986, 585);
            this.tabPageDatPhong.TabIndex = 3;
            this.tabPageDatPhong.Text = "Đặt Phòng";
            this.tabPageDatPhong.UseVisualStyleBackColor = true;
            // 
            // tabPageQLPhong
            // 
            this.tabPageQLPhong.Location = new System.Drawing.Point(4, 24);
            this.tabPageQLPhong.Name = "tabPageQLPhong";
            this.tabPageQLPhong.Size = new System.Drawing.Size(986, 585);
            this.tabPageQLPhong.TabIndex = 4;
            this.tabPageQLPhong.Text = "Quản Lý Phòng";
            this.tabPageQLPhong.UseVisualStyleBackColor = true;
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 24);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Size = new System.Drawing.Size(986, 585);
            this.tabPageThongKe.TabIndex = 5;
            this.tabPageThongKe.Text = "Thống kê";
            this.tabPageThongKe.UseVisualStyleBackColor = true;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // nbgMain_TrangChu
            // 
            this.nbgMain_TrangChu.Caption = "Trang chủ";
            this.nbgMain_TrangChu.Expanded = true;
            this.nbgMain_TrangChu.Name = "nbgMain_TrangChu";
            // 
            // nbgMain_Khach
            // 
            this.nbgMain_Khach.Caption = "Quản lý khách";
            this.nbgMain_Khach.Expanded = true;
            this.nbgMain_Khach.Name = "nbgMain_Khach";
            // 
            // nbgMain_DatPhong
            // 
            this.nbgMain_DatPhong.Caption = "Đặt phòng";
            this.nbgMain_DatPhong.Expanded = true;
            this.nbgMain_DatPhong.Name = "nbgMain_DatPhong";
            // 
            // nbgMain_Phong
            // 
            this.nbgMain_Phong.Caption = "Quản lý phòng";
            this.nbgMain_Phong.Expanded = true;
            this.nbgMain_Phong.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMain_PhongTrong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMain_PhongCoKhach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMain_PhongKhac)});
            this.nbgMain_Phong.Name = "nbgMain_Phong";
            // 
            // nbgMain_ThongKe
            // 
            this.nbgMain_ThongKe.Caption = "Thống kê";
            this.nbgMain_ThongKe.Name = "nbgMain_ThongKe";
            // 
            // nbgMain_Thoat
            // 
            this.nbgMain_Thoat.Caption = "Thoát";
            this.nbgMain_Thoat.Name = "nbgMain_Thoat";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 584);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgMain_TrangChu;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMain_TrangChu,
            this.nbgMain_Khach,
            this.nbgMain_DatPhong,
            this.nbgMain_Phong,
            this.nbgMain_ThongKe,
            this.nbgMain_Thoat});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiMain_PhongTrong,
            this.nbiMain_PhongCoKhach,
            this.nbiMain_PhongKhac});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 191;
            this.navBarControl1.Size = new System.Drawing.Size(191, 584);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "Trang chủ";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("27f5f9b3-1b88-4b06-97f2-dcefe9168714");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 600);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // nbiMain_PhongTrong
            // 
            this.nbiMain_PhongTrong.Caption = "Phòng trống";
            this.nbiMain_PhongTrong.Name = "nbiMain_PhongTrong";
            this.nbiMain_PhongTrong.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMain_PhongTrong_LinkPressed);
            // 
            // nbiMain_PhongCoKhach
            // 
            this.nbiMain_PhongCoKhach.Caption = "Có khách";
            this.nbiMain_PhongCoKhach.Name = "nbiMain_PhongCoKhach";
            // 
            // nbiMain_PhongKhac
            // 
            this.nbiMain_PhongKhac.Caption = "Khác";
            this.nbiMain_PhongKhac.Name = "nbiMain_PhongKhac";
            // 
            // galleryControl_DatPhong
            // 
            this.galleryControl_DatPhong.Controls.Add(this.galleryControlClient2);
            this.galleryControl_DatPhong.DesignGalleryGroupIndex = 0;
            this.galleryControl_DatPhong.DesignGalleryItemIndex = 0;
            // 
            // 
            // 
            galleryItemGroup6.Caption = "Phòng";
            this.galleryControl_DatPhong.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup6});
            this.galleryControl_DatPhong.Gallery.HoverImageSize = new System.Drawing.Size(30, 30);
            this.galleryControl_DatPhong.Gallery.ImageSize = new System.Drawing.Size(70, 70);
            this.galleryControl_DatPhong.Gallery.ShowItemText = true;
            this.galleryControl_DatPhong.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemClick);
            this.galleryControl_DatPhong.Location = new System.Drawing.Point(4, 4);
            this.galleryControl_DatPhong.Name = "galleryControl_DatPhong";
            this.galleryControl_DatPhong.Size = new System.Drawing.Size(111, 581);
            this.galleryControl_DatPhong.TabIndex = 0;
            this.galleryControl_DatPhong.Text = "galleryControl_DatPhong";
            // 
            // galleryControlClient2
            // 
            this.galleryControlClient2.GalleryControl = this.galleryControl_DatPhong;
            this.galleryControlClient2.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient2.Size = new System.Drawing.Size(90, 577);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.dockPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoarom Hotel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTrangChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_TrangChu)).EndInit();
            this.galleryControl_TrangChu.ResumeLayout(false);
            this.tabPageDatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_DatPhong)).EndInit();
            this.galleryControl_DatPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTrangChu;
        private System.Windows.Forms.TabPage tabPageQLKhach;
        private System.Windows.Forms.TabPage tabPageDatPhong;
        private System.Windows.Forms.TabPage tabPageQLPhong;
        private System.Windows.Forms.TabPage tabPageThongKe;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl_TrangChu;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_TrangChu;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_Khach;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_DatPhong;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_Phong;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_ThongKe;
        private DevExpress.XtraNavBar.NavBarGroup nbgMain_Thoat;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarItem nbiMain_PhongTrong;
        private DevExpress.XtraNavBar.NavBarItem nbiMain_PhongCoKhach;
        private DevExpress.XtraNavBar.NavBarItem nbiMain_PhongKhac;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl_DatPhong;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;
    }
}