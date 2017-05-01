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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTinhTrangPhong = new System.Windows.Forms.Button();
            this.btnQLKhach = new System.Windows.Forms.Button();
            this.btnDatPhongNhanh = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTrangChu = new System.Windows.Forms.TabPage();
            this.tabPageQLKhach = new System.Windows.Forms.TabPage();
            this.tabPageDatPhongNhanh = new System.Windows.Forms.TabPage();
            this.tabPageTinhTrangPhong = new System.Windows.Forms.TabPage();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.galleryControl_TrangChu = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_TrangChu)).BeginInit();
            this.galleryControl_TrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnTinhTrangPhong);
            this.panel1.Controls.Add(this.btnQLKhach);
            this.panel1.Controls.Add(this.btnDatPhongNhanh);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 705);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources._12512603_467712036748896_4824590879508992717_n;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 165);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(0, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 52);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(0, 379);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(188, 52);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTinhTrangPhong
            // 
            this.btnTinhTrangPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTrangPhong.Location = new System.Drawing.Point(0, 327);
            this.btnTinhTrangPhong.Name = "btnTinhTrangPhong";
            this.btnTinhTrangPhong.Size = new System.Drawing.Size(188, 52);
            this.btnTinhTrangPhong.TabIndex = 3;
            this.btnTinhTrangPhong.Text = "TÌNH TRẠNG PHÒNG";
            this.btnTinhTrangPhong.UseVisualStyleBackColor = true;
            this.btnTinhTrangPhong.Click += new System.EventHandler(this.btnTinhTrangPhong_Click);
            // 
            // btnQLKhach
            // 
            this.btnQLKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKhach.Location = new System.Drawing.Point(0, 223);
            this.btnQLKhach.Name = "btnQLKhach";
            this.btnQLKhach.Size = new System.Drawing.Size(188, 52);
            this.btnQLKhach.TabIndex = 1;
            this.btnQLKhach.Text = "QUẢN LÝ KHÁCH";
            this.btnQLKhach.UseVisualStyleBackColor = true;
            this.btnQLKhach.Click += new System.EventHandler(this.btnQLKhach_Click);
            // 
            // btnDatPhongNhanh
            // 
            this.btnDatPhongNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatPhongNhanh.Location = new System.Drawing.Point(0, 275);
            this.btnDatPhongNhanh.Name = "btnDatPhongNhanh";
            this.btnDatPhongNhanh.Size = new System.Drawing.Size(188, 52);
            this.btnDatPhongNhanh.TabIndex = 2;
            this.btnDatPhongNhanh.Text = "ĐẶT PHÒNG NHANH";
            this.btnDatPhongNhanh.UseVisualStyleBackColor = true;
            this.btnDatPhongNhanh.Click += new System.EventHandler(this.btnDatPhongNhanh_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.Location = new System.Drawing.Point(0, 171);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(188, 52);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "TRANG CHỦ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTrangChu);
            this.tabControlMain.Controls.Add(this.tabPageQLKhach);
            this.tabControlMain.Controls.Add(this.tabPageDatPhongNhanh);
            this.tabControlMain.Controls.Add(this.tabPageTinhTrangPhong);
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
            // tabPageQLKhach
            // 
            this.tabPageQLKhach.Location = new System.Drawing.Point(4, 24);
            this.tabPageQLKhach.Name = "tabPageQLKhach";
            this.tabPageQLKhach.Size = new System.Drawing.Size(986, 585);
            this.tabPageQLKhach.TabIndex = 2;
            this.tabPageQLKhach.Text = "Quản Lý Khách";
            this.tabPageQLKhach.UseVisualStyleBackColor = true;
            // 
            // tabPageDatPhongNhanh
            // 
            this.tabPageDatPhongNhanh.Location = new System.Drawing.Point(4, 24);
            this.tabPageDatPhongNhanh.Name = "tabPageDatPhongNhanh";
            this.tabPageDatPhongNhanh.Size = new System.Drawing.Size(986, 585);
            this.tabPageDatPhongNhanh.TabIndex = 3;
            this.tabPageDatPhongNhanh.Text = "Đặt Phòng Nhanh";
            this.tabPageDatPhongNhanh.UseVisualStyleBackColor = true;
            // 
            // tabPageTinhTrangPhong
            // 
            this.tabPageTinhTrangPhong.Location = new System.Drawing.Point(4, 24);
            this.tabPageTinhTrangPhong.Name = "tabPageTinhTrangPhong";
            this.tabPageTinhTrangPhong.Size = new System.Drawing.Size(986, 585);
            this.tabPageTinhTrangPhong.TabIndex = 4;
            this.tabPageTinhTrangPhong.Text = "Tình trạng phòng";
            this.tabPageTinhTrangPhong.UseVisualStyleBackColor = true;
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
            galleryItemGroup1.Caption = "Danh sách phòng";
            this.galleryControl_TrangChu.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoarom Hotel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTrangChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl_TrangChu)).EndInit();
            this.galleryControl_TrangChu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTinhTrangPhong;
        private System.Windows.Forms.Button btnDatPhongNhanh;
        private System.Windows.Forms.Button btnQLKhach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTrangChu;
        private System.Windows.Forms.TabPage tabPageQLKhach;
        private System.Windows.Forms.TabPage tabPageDatPhongNhanh;
        private System.Windows.Forms.TabPage tabPageTinhTrangPhong;
        private System.Windows.Forms.TabPage tabPageThongKe;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl_TrangChu;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}