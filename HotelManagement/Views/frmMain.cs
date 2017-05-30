using HotelManagement.Controllers;
using HotelManagement.Models;
using HotelManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmMain : Form
    {
        Controller controller = new Controller();
        private frmLogin frmLogin;
        private frmChiTietPhong frmChiTietPhong;
        private NhanVien nhanvien;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(frmLogin frmLogin, NhanVien nv)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.nhanvien = nv;
        }
        public frmMain(int tabpage)
        {
            InitializeComponent();
            Load_();
            tabControlMain.SelectTab(tabpage);//tabpage DatPhong
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //loaded tabpage Trang chu
            Load_tabpage_trangchu();
            //loaded tabpage DatPhong
            Load_tabpage_datphong();
            Load_tabpage_loaiphong();
            Load_tabpage_quanlyphong();
            Load_tabpage_quanlyDichVu();
            Load_tabpage_quanlySDDichVu();
            rtbhuongdan.Text = "\n\n\t\t\t" + "B1: Đăng nhập vào hệ thống" + "\n\t\t\t" +
                                              "B2: Thao tác với các chức năng sẵn có trên trang chủ" + "\n\t\t\t\t\t\t" +
                                                  " + Loại phòng: Có các chức năng thêm sửa xóa. Thêm sẽ thêm một bản ghi, sửa sẽ sửa lại một số thông tin, xóa: khi nhấn vào ta sẽ được hỏi có chắc xóa hay không" + "\n\t\t\t\t\t\t" +
                                                  " +Quản lý phòng: Có các chức năng thêm sửa xóa. Thêm sẽ thêm một bản ghi, sửa sẽ sửa lại một số thông tin, xóa: khi nhấn vào ta sẽ được hỏi có chắc xóa hay không" + "\n\t\t\t\t\t\t" +
                                                  " +Đặt phòng: Quản lý các thông tin về đặt phòng của khách" + "\n\t\t\t\t\t\t" +
                                                  " +Quản lý khách: Hiện thị danh sách các khách hàng đã đặt phòng và sử dụng dịch vụ" + "\n\t\t\t\t\t\t" +
                                                  " +Quản lý dịch vụ: Có các chức năng thêm sửa xóa. Thêm sẽ thêm một bản ghi, sửa sẽ sửa lại một số thông tin, xóa: khi nhấn vào ta sẽ được hỏi có chắc xóa hay không" + "\n\t\t\t\t\t\t" +
                                                  " +Sử dụng dịch vụ: Có thêm mới và chỉnh sửa các bản ghi" + "\n\t\t\t\t\t\t" +
                                                  " +Thống kê" + "\n\t\t\t\t\t\t" +
                                                  " +Hướng dẫn" + "\n\t\t\t" +
                                               "B3: Để thoát khỏi chương trình bạn có thể nhấn nút thoát hoặc dấu nhân bên phải màn hình để kết thúc" + "\n\n\t\t\t\t" +
                                                   " Chú thích: Các thanh bên cạnh tên của nó sẽ tương ứng với các chức năng của nó" + "\n\t\t\t\t\t\t\t\t\t" +
                                                     "CHÚC BẠN THÀNH CÔNG";
        }
        private void Load_()
        {

            Load_tabpage_trangchu();
            Load_tabpage_datphong();
          
        }
        private void Load_tabpage_trangchu()
        {
            //loaded tabpage TrangChu
            Phong[] lsPhong = controller.getList_Phong();
            int i = 0;
            String src_image = "";
            String trangthai = "";
            IEnumerable<Phong> ls_phong_sort = from phong in lsPhong
                                               orderby phong.SoPhong.Substring(0, 1)
                                               select phong;
            galleryControl_TrangChu.Gallery.Groups[0].Items.Clear();

            foreach (Phong phong in ls_phong_sort)
            {
                src_image = @"E:\HOC_KY_6\ThucTapNhom\PRO\ksan\HotelManagement\HotelManagement\Images\";
                if (phong.TrangThai == 0)
                {
                    trangthai = "Phòng trống";
                    src_image += "icon_correct.png";
                }
                else if (phong.TrangThai == 1)
                {
                    src_image += "icon_deny.png";
                    trangthai = "Có khách";
                }
                else if (phong.TrangThai == 2)
                {
                    src_image += "icon_no.png";
                    trangthai = "khác";
                }
                galleryControl_TrangChu.Gallery.Groups[0].Items.Add(
                    new DevExpress.XtraBars.Ribbon.GalleryItem(
                        new Bitmap(src_image), phong.SoPhong, trangthai));

                galleryControl_TrangChu.Gallery.Groups[0].Items[i].HoverImage =
                    galleryControl_TrangChu.Gallery.Groups[0].Items[i].Image;
                i++;
            }
        }
        private void Load_tabpage_datphong()
        {
            Phong[] lsPhong = controller.getList_Phong();
            IEnumerable<Phong> ls_phong_sort = from phong in lsPhong
                                               orderby phong.SoPhong.Substring(0, 1)
                                               select phong;
            dgv_DatPhong_DanhSach.Visible = false;
            int i = 0;
           
            tbDatPhong_HoTen.Text = "";
            dtpDatPhong_NgaySinh.Text = DateTime.Now.ToShortDateString().ToString();
            cbDatPhong_Nam.Checked = true;
            cbDatPhong_Nu.Checked = false;
            tbDatPhong_CMND.Text = "";
            tbDatPhong_DiaChi.Text = "";
            tbDatPhong_QuocTich.Text = "Việt Nam";
            tbDatPhong_SoDienThoai.Text = "";
            tbDatPhong_SoLuong.Text = "";
            cbbDatPhong_SoPhong.DataSource = controller.getList_Phong_byKey("sophong").Distinct().ToArray();
            cbbDatPhong_SoPhong.Text = "";
            cbbDatPhong_LoaiPhong.Text = "";
            cbbDatPhong_LoaiPhong.DataSource = controller.getList_LoaiPhong_byKey("loaiphong").Distinct().ToArray();
            cbbDatPhong_DonGia.Text = "";
            
            cbbDatPhong_DonGia.DataSource = controller.getList_Phong_byKey("dongia").Distinct().ToArray();
            tbDatPhong_TrangThai.Enabled = false;
            tbDatPhong_TrangThai.Text = "";
            cbbDatPhong_TrangThietBi.Text = "";
            cbbDatPhong_TrangThietBi.DataSource = controller.getList_TrangThietBi("").Distinct().ToArray();
            dtpDatPhong_NgayDen.Text = DateTime.Now.ToShortDateString().ToString();
            dtpDatPhong_NgayDi.Text = DateTime.Now.ToShortDateString().ToString();
            tbDatPhong_GioDen.Text = "";
            tbDatPhong_GioDi.Text = "";

            //load danh sách đăng ký
            Load_tabpage_datphong_ds_dangky();
        }
        private void Load_tabpage_datphong_ds_dangky()
        {
            dgv_DatPhong_DanhSach.DataSource = controller.getList_DangKy();
            dgv_DatPhong_DanhSach.Columns["Ma"].HeaderText = "Mã";
            dgv_DatPhong_DanhSach.Columns["Ma"].Width = 60;
            dgv_DatPhong_DanhSach.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";
            dgv_DatPhong_DanhSach.Columns["KhachMa"].HeaderText = "Khách hàng";
            dgv_DatPhong_DanhSach.Columns["NgayDen"].HeaderText = "Ngày đến";
            dgv_DatPhong_DanhSach.Columns["GioDen"].HeaderText = "Giờ đến";
            dgv_DatPhong_DanhSach.Columns["GioDen"].Width = 80;
            dgv_DatPhong_DanhSach.Columns["NgayDi"].HeaderText = "Ngày đi";
            dgv_DatPhong_DanhSach.Columns["GioDi"].HeaderText = "Giờ đi";
            dgv_DatPhong_DanhSach.Columns["GioDi"].Width = 70;
            dgv_DatPhong_DanhSach.Columns["PhongMa"].HeaderText = "Số phòng";
            dgv_DatPhong_DanhSach.Columns["TienDatCoc"].HeaderText = "Tiền đặt cọc";
            dgv_DatPhong_DanhSach.Columns["NhanVienMa"].HeaderText = "Nhân viên";
            dgv_DatPhong_DanhSach.Columns["NhanVienMa"].Width = 150;
        }
        private void Load_tabpage_loaiphong()
        {
            dtgLoaiPhong.DataSource = controller.getList_LoaiPhong();
            dtgLoaiPhong.Columns["Ma"].HeaderText = "Mã";
            dtgLoaiPhong.Columns["Ten"].HeaderText = "Tên";
            dtgLoaiPhong.Columns["MoTa"].HeaderText = "Mô Tả";
            dtgLoaiPhong.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgLoaiPhong.Columns["GiaQuaNgay"].HeaderText = "Gía Qua Ngày";
            dtgLoaiPhong.Columns["GiaQuaDem"].HeaderText = "Gía Qua Đêm";
            dtgLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Load_tabpage_quanlyphong()
        {
       
            dtgPhong.DataSource = controller.getList_Phong();
            dtgPhong.Columns["Ma"].HeaderText = "Mã";
            dtgPhong.Columns["SoPhong"].HeaderText = "Số Phòng";
            dtgPhong.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dtgPhong.Columns["DonGia"].HeaderText = "Đơn giá";
            dtgPhong.Columns["TrangThai"].HeaderText = "Trạng thái";
            dtgPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbLoaiPhong.DataSource = controller.getList_LoaiPhong();
            cbbLoaiPhong.DisplayMember = "ten";
            cbbLoaiPhong.ValueMember = "ma";
        }
        public void Load_tabpage_quanlyDichVu()
        {
            dtgDSDichVu.DataSource = controller.getList_DichVu();
            dtgDSDichVu.Columns["Ma"].HeaderText = "Mã";
            dtgDSDichVu.Columns["Ten"].HeaderText = "Tên";
            dtgDSDichVu.Columns["DonGia"].HeaderText = "Đơn Gía";
            dtgDSDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
   
        public void Load_tabpage_quanlySDDichVu()
        {
            dtgSuDungDichVu.DataSource = controller.getList_SuDungDichVu();
            dtgSuDungDichVu.Columns["Ma"].HeaderText = "Mã";
            dtgSuDungDichVu.Columns["PhongMa"].HeaderText = "Mã Phòng";
            dtgSuDungDichVu.Columns["KhachMa"].HeaderText = "Mã Khách Hàng";
            dtgSuDungDichVu.Columns["DichVuMa"].HeaderText = "Mã Khách Hàng";
            dtgSuDungDichVu.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
            dtgSuDungDichVu.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgSuDungDichVu.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dtgSuDungDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
            cbbSDDichVu.DataSource = controller.getList_DichVu();
            cbbSDDichVu.DisplayMember = "ten";
            cbbSDDichVu.ValueMember = "ma";
            cbbKhachMa.DataSource = controller.getList_Khach();
            cbbKhachMa.DisplayMember = "ma";
            cbbKhachMa.ValueMember = "ma";

            txtTenKhach.Text = controller.getTenKhach(cbbKhachMa.SelectedValue.ToString());
            cbbPhongSDDV.DataSource = controller.getList_Phong();
            cbbPhongSDDV.DisplayMember = "sophong";
            cbbPhongSDDV.ValueMember = "ma";
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.frmLogin == null) this.frmLogin = new frmLogin();
            this.frmLogin.Visible = true;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageTrangChu);

        }

        private void btnDatPhongNhanh_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageDatPhong);
        }

        private void btnTinhTrangPhong_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageQLPhong);
        }

        private void btnQLKhach_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageQLKhach);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// kích đúp để đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void galleryControl1_Gallery_ItemDoubleClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            frmChiTietPhong = new frmChiTietPhong(e.Item.Caption, this);
            frmChiTietPhong.ShowDialog();
        }

        private void nbiMain_PhongTrong_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("press");
        }
        /// <summary>
        /// đặt phòng: click chọn phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void galleryControl1_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Phong phong = new Phong();
            phong = controller.get_Phong(e.Item.Caption);
            cbbDatPhong_SoPhong.Text = phong.SoPhong;
            cbbDatPhong_LoaiPhong.Text = phong.LoaiPhong;
            cbbDatPhong_DonGia.Text = phong.DonGia.ToString();
            if (phong.TrangThai == 0) tbDatPhong_TrangThai.Text = "Phòng trống";
            else if (phong.TrangThai == 1)
                tbDatPhong_TrangThai.Text = "Phòng có khách";
            else tbDatPhong_TrangThai.Text = "Khác";

        }

        private void nbiMain_TrangChu_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageTrangChu);
        }

        private void nbiMain_QLPhong_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageQLPhong);
        }

        private void nbiMain_DatPhong_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageDatPhong);
        }

        private void nbiMain_QLKhach_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageQLKhach);
        }

        private void nbiMain_Thoat_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }

        private void btnDatPhong_DatPhong_Click(object sender, EventArgs e)
        {
            grbDatPhong_Khach.Visible = true;
            grbDatPhong_Phong.Visible = true;
            dgv_DatPhong_DanhSach.Visible = false;
            Khach khach = new Khach();
            khach.Ten = tbDatPhong_HoTen.Text;
            khach.NgaySinh = DateTime.Parse(dtpDatPhong_NgaySinh.Value.ToShortDateString());
            if (cbDatPhong_Nam.Checked) khach.GioiTinh = 1;
            else khach.GioiTinh = 0;
            khach.DiaChi = tbDatPhong_DiaChi.Text;
            khach.QuocTich = tbDatPhong_QuocTich.Text;
            khach.SoDienThoai = tbDatPhong_SoDienThoai.Text;
            khach.ChungMinhThu = tbDatPhong_CMND.Text;

            if (khach.Ten == "")
            {
                erpSoPhong.SetError(tbDatPhong_HoTen, "phải nhập họ tên khách hàng");
                return;
            }
            erpSoPhong.Clear();

            if(tbDatPhong_TrangThai.Text != "Phòng trống")
            {
                erpTinhTrang.SetError(tbDatPhong_TrangThai, "Không đặt phòng này!");
                erpSoPhong.SetError(cbbDatPhong_SoPhong, "Không đặt phòng này!");
                return;
            }
            erpSoPhong.Clear();
            erpTinhTrang.Clear();
            controller.ThemKhachHang(khach);

            khach.Ma = controller.getMaKhach(khach);

            DangKy dangky = new DangKy();
            dangky.NgayDangKy = DateTime.Now;
            dangky.KhachMa = khach.Ma;
            dangky.NgayDen = dtpDatPhong_NgayDen.Value;
            dangky.GioDen = int.Parse(tbDatPhong_GioDen.Text);
            dangky.NgayDi = dtpDatPhong_NgayDi.Value;
            dangky.GioDi = int.Parse(tbDatPhong_GioDi.Text);
            dangky.PhongMa = controller.get_Phong(cbbDatPhong_SoPhong.Text.ToString().Trim(), "ma");
            dangky.TienDatCoc = double.Parse(tbDatPhong_TienDatCoc.Text);
            dangky.NhanVienMa = nhanvien.Ma;
            //ma- ngaydangky- khachma- ngayden- gioden- ngaydi- giodi- phongma - tiendatcoc- nhanvienma
            if (tbDatPhong_TrangThai.Text == "Có khách" || tbDatPhong_TrangThai.Text == "Khác")
            {
                erpSoPhong.SetError(tbDatPhong_TrangThai, "Không đặt phòng này!");
                return;
            }
            erpSoPhong.Clear();
            controller.DatPhong(dangky);
            MessageBox.Show("Đặt phòng thành công", "Đặt phòng");
            tabControlMain.SelectTab(tabPageTrangChu);

            Load_();
            /*String khachMa, String phongMa, DateTime ngayDen, int gioDen, DateTime ngayDi, int gioDi, double tienDatCoc,
            String nhanVienMa)*/
        }

        private void btnDatPhong_Huy_Click(object sender, EventArgs e)
        {
            grbDatPhong_Phong.Visible = true;
            grbDatPhong_Khach.Visible = true;
            dgv_DatPhong_DanhSach.Visible = false;
            Load_tabpage_datphong();
        }

        private void btnDatPhong_Thoat_Click(object sender, EventArgs e)
        {
            grbDatPhong_Phong.Visible = true;
            grbDatPhong_Khach.Visible = true;
            dgv_DatPhong_DanhSach.Visible = false;

            tabControlMain.SelectTab(tabPageTrangChu);
        }

        private void cbbDatPhong_SoPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            String sophong = cbbDatPhong_SoPhong.SelectedValue.ToString().Trim();
            Phong phong = controller.get_Phong(sophong);
            int trangthai = controller.getTrangThai(sophong);
            if (trangthai == 0) tbDatPhong_TrangThai.Text = "Phòng trống";
            else if (trangthai == 1)
                tbDatPhong_TrangThai.Text = "Phòng có khách";
            else tbDatPhong_TrangThai.Text = "Khác";

            //cbbDatPhong_TrangThietBi.DataSource = controller.getList_TrangThietBi(sophong).Distinct().ToArray() ;
            cbbDatPhong_DonGia.DataSource = controller.getList_Phong_byKey("dongia").Distinct().ToArray();
            cbbDatPhong_DonGia.Text = phong.DonGia + "";
            cbbDatPhong_LoaiPhong.DataSource = controller.getList_LoaiPhong_byKey(phong.LoaiPhong).Distinct().ToArray() ;
            if(controller.getList_LoaiPhong_byKey(phong.LoaiPhong)[0] != null)
                cbbDatPhong_LoaiPhong.Text= controller.getList_LoaiPhong_byKey(phong.LoaiPhong)[0];
            //SelectedValue =controller.getList_Phong_byKey(sophong);
        }

        private void nbiMain_Thoat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }

        private void nbiMain_HuongDan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageHuongDan);
        }

        private void btnDatPhong_DanhSach_Click(object sender, EventArgs e)
        {
            Load_tabpage_datphong();
            dgv_DatPhong_DanhSach.Visible = true;

            dgv_DatPhong_DanhSach.Location = new Point(0, 0);
            dgv_DatPhong_DanhSach.Size = new System.Drawing.Size(994, 522);//877
            dgv_DatPhong_DanhSach.DataSource = controller.getList_DangKy();

            btnDatPhong_DatPhong.BackColor= Color.FromArgb(128, 255, 128);
            //224, 224, 224 ko dc ấn
            //(128, 255, 128 dc ấn

        }

        private void tabPageLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckLoaiPhong())
            {
                LoaiPhong lp = new LoaiPhong();
                lp.Ten = txtTen.Text.ToString().Trim();
                lp.MoTa = rtbMoTa.Text.ToString().Trim();
                lp.SoLuong = int.Parse(txtSoLuong.Text.ToString().Trim());
                double giaquadem = 0;
                if (double.TryParse(txtGiaQuaDem.Text.ToString().Trim(), out giaquadem))
                    lp.GiaQuaDem = giaquadem;
                double giaquangay = 0;
                if (double.TryParse(txtGiaQuaNgay.Text.ToString().Trim(), out giaquangay))
                    lp.GiaQuaNgay = giaquangay;
                if(controller.addLoaiPhong(lp))
                {
                    dtgLoaiPhong.DataSource=controller.getList_LoaiPhong();
                }
            }

        }
        private bool CheckLoaiPhong()
        { 
        
            if(txtTen.Text.ToString().Trim().Equals(""))
                {
                errTenLoaiPhong.SetError(txtTen, "nhap ten loai phong");
                return false;
                }
            errTenLoaiPhong.Clear();
            if (txtSoLuong.Text.ToString().Trim().Equals(""))
            {
                errSoLuongLoaiPhong.SetError(txtSoLuong, "nhap ten loai phong");
                return false;
            }
            errSoLuongLoaiPhong.Clear();
            if (txtGiaQuaNgay.Text.ToString().Trim().Equals(""))
            {
                errGiaQuaNgay.SetError(txtGiaQuaNgay, "nhap ten loai phong");
                return false;
            }
            errGiaQuaNgay.Clear();
            if (txtGiaQuaDem.Text.ToString().Trim().Equals(""))
            {
                errGiaQuaDem.SetError(txtGiaQuaDem, "nhap ten loai phong");
                return false;
            }
            errGiaQuaDem.Clear();
            if (rtbMoTa.Text.ToString().Trim().Equals(""))
            {
                errMoTaLoaiPhong.SetError(rtbMoTa, "nhap ten loai phong");
                return false;
            }
            errMoTaLoaiPhong.Clear();
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            LoaiPhong lp = new LoaiPhong();
            lp.Ma = dtgLoaiPhong.Rows[dtgLoaiPhong.CurrentRow.Index].Cells[0].Value.ToString();
            lp.Ten = txtTen.Text.ToString().Trim();
            lp.Ten = txtTen.Text.ToString().Trim();
            lp.MoTa = rtbMoTa.Text.ToString().Trim();
            lp.SoLuong = int.Parse(txtSoLuong.Text.ToString().Trim());
            double giaquadem = 0;
            if (double.TryParse(txtGiaQuaDem.Text.ToString().Trim(), out giaquadem))
                lp.GiaQuaDem = giaquadem;
            double giaquangay = 0;
            if (double.TryParse(txtGiaQuaNgay.Text.ToString().Trim(), out giaquangay))
                lp.GiaQuaNgay = giaquangay;
            if (controller.updateLP(lp))
            {
                dtgLoaiPhong.DataSource = controller.getList_LoaiPhong();
            }
        }

        private void dtgLoaiPhong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dtgLoaiPhong.Rows[e.RowIndex];
            try
            {
                txtTen.Text = row.Cells[1].Value.ToString();
                rtbMoTa.Text= row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGiaQuaNgay.Text= row.Cells[4].Value.ToString();
                txtGiaQuaDem.Text= row.Cells[5].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (this.dtgLoaiPhong.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgLoaiPhong.SelectedRows[0].Index;
                string rowID = dtgLoaiPhong[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  loại phòng mã " + rowID + "", "Xoa loại phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    controller.XoaLoaiPhong(rowID);
                    dtgLoaiPhong.DataSource = controller.getList_LoaiPhong();
                }
            }
        }

        private void dtgPhong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dtgPhong.Rows[e.RowIndex];
            try
            {
                txtSoPhong.Text = row.Cells[1].Value.ToString();
                cbbLoaiPhong.Text = row.Cells[2].Value.ToString();
                txtTrangThai.Text = row.Cells[3].Value.ToString();
                

            }
            catch (Exception)
            {

            }
        }
        private bool checkPhong()
        {
            if(txtSoPhong.Text.ToString().Trim().Equals(""))
            {
                errSoPhong.SetError(txtSoPhong, "Nhap so phong");
                return false;
            }
            errSoPhong.Clear();

            if (cbbLoaiPhong.Text.ToString().Trim().Equals(""))
            {
                errLoaiPhong.SetError(cbbLoaiPhong, "Nhap so phong");
                return false;
            }
            errLoaiPhong.Clear();

            if (txtTrangThai.Text.ToString().Trim().Equals(""))
            {
                errTrangThai.SetError(txtTrangThai, "Nhap so phong");
                return false;
            }
            errTrangThai.Clear();
            return true;
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {

            if(checkPhong())
            {
                Phong p = new Phong();
                p.SoPhong = txtSoPhong.Text.ToString().Trim();
                p.LoaiPhong = cbbLoaiPhong.SelectedValue.ToString().Trim();
                p.TrangThai = int.Parse(txtTrangThai.Text.ToString().Trim());
                if(controller.addPhong(p))
                {
                    dtgPhong.DataSource = controller.getList_Phong();
                }
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.Ma = dtgPhong.Rows[dtgPhong.CurrentRow.Index].Cells[0].Value.ToString();
            p.SoPhong = txtSoPhong.Text.ToString().Trim();
            p.TrangThai = int.Parse(txtTrangThai.Text.ToString().Trim());
            p.LoaiPhong = cbbLoaiPhong.SelectedValue.ToString().Trim();
            if(controller.updatePhong(p))
            {
               dtgPhong.DataSource = controller.getList_Phong();

            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {

            if (this.dtgPhong.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgPhong.SelectedRows[0].Index;
                string rowID = dtgPhong[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Chắc chắn xóa phòng mã " + rowID + "?", "Xoá loại phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    controller.XoaPhong(rowID);
                    dtgPhong.DataSource = controller.getList_Phong();
                }
            }
        }
        private bool checkDV()
        {
            if(txtTenDichVu.Text.ToString().Trim().Equals(""))
            {
                errTenDichVu.SetError(txtTenDichVu, "nhap ten dich vu");
                return false;
            }
            errTenDichVu.Clear();
            if(txtGiaDichVu.Text.ToString().Trim().Equals(""))
            {
                errGiaDichVu.SetError(txtGiaDichVu, "nhap gia dich vu");
                return false;
            }
            errGiaDichVu.Clear();
            return true;
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {

            if (checkDV())
            {
                DichVu dv = new DichVu();
                dv.Ten = txtTenDichVu.Text.ToString().Trim();
                double gia = 0;
                double.TryParse(txtGiaDichVu.Text.ToString().Trim(), out gia);
                dv.DonGia = gia;
               
                if (controller.addDichVu(dv))
                {
                    dtgDSDichVu.DataSource = controller.getList_DichVu();
                }
            }
        }

        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Ma = dtgDSDichVu.Rows[dtgDSDichVu.CurrentRow.Index].Cells[0].Value.ToString();
            dv.Ten = txtTenDichVu.Text.ToString().Trim();
            double gia = 0;
            double.TryParse(txtGiaDichVu.Text.ToString().Trim(), out gia);
            dv.DonGia = gia;

            if (controller.updateDichVu(dv))
            {
                dtgDSDichVu.DataSource = controller.getList_DichVu();
            }
        }

        private void dtgDSDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dtgDSDichVu.Rows[e.RowIndex];
            try
            {
                txtTenDichVu.Text = row.Cells[1].Value.ToString();
                txtGiaDichVu.Text = row.Cells[2].Value.ToString();
               
            }
            catch (Exception)
            {

            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (this.dtgDSDichVu.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgDSDichVu.SelectedRows[0].Index;
                string rowID = dtgDSDichVu[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn xóa dịch vụ mã " + rowID + "?", "Xoá dịch vụ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    controller.XoaDichVu(rowID);
                    dtgDSDichVu.DataSource = controller.getList_DichVu();
                }
            }
        }

        private void dtgSuDungDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgSuDungDichVu.Rows[e.RowIndex];
            try
            {
                cbbPhongSDDV.Text = row.Cells[1].Value.ToString();
                cbbKhachMa.Text = row.Cells[2].Value.ToString();
                cbbSDDichVu.Text = row.Cells[3].Value.ToString();
                txtSoLuongSDDV.Text= row.Cells[5].Value.ToString();

            }
            catch (Exception)
            {

            }
        }
        private bool checkSDDV()
        {
            if (cbbPhongSDDV.Text.ToString().Trim().Equals(""))
            {
                errPhongSDDV.SetError(cbbPhongSDDV, "chọn phòng sử dụng dich vu");
                return false;
            }
            errPhongSDDV.Clear();
            if (cbbKhachMa.Text.ToString().Trim().Equals(""))
            {
                errKhachHangSDDV.SetError(cbbKhachMa, "nhap khach hang su dung dich vu");
                return false;
            }
            errKhachHangSDDV.Clear();
            if (cbbSDDichVu.Text.ToString().Trim().Equals(""))
            {
                errDichVuSD.SetError(cbbSDDichVu, "nhap loại dich vu");
                return false;
            }
            errDichVuSD.Clear();
            if (txtSoLuongSDDV.Text.ToString().Trim().Equals(""))
            {
                errSoLuongSDDV.SetError(txtSoLuongSDDV, "nhap số lượng");
                return false;
            }
            errSoLuongSDDV.Clear();
            return true;
        }
        private void btnThemSDDV_Click(object sender, EventArgs e)
        {
            if (checkSDDV())
            {
                SuDungDichVu sddv = new SuDungDichVu();
                sddv.PhongMa = cbbPhongSDDV.SelectedValue.ToString().Trim();
                sddv.KhachMa = cbbKhachMa.Text.ToString().Trim();
                sddv.DichVuMa = cbbSDDichVu.SelectedValue.ToString().Trim();
                sddv.SoLuong = int.Parse(txtSoLuongSDDV.Text.ToString().Trim());
                if (controller.addSuDungDichVu(sddv))
                {
                    dtgSuDungDichVu.DataSource = controller.getList_SuDungDichVu();
                }
            }
        }

        private void cbbKhachMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenKhach.Text = controller.getTenKhach(cbbKhachMa.SelectedValue.ToString());

        }

        private void btnSuaSDDV_Click(object sender, EventArgs e)
        {
            SuDungDichVu sddv = new SuDungDichVu();
            sddv.Ma = dtgSuDungDichVu.Rows[dtgSuDungDichVu.CurrentRow.Index].Cells[0].Value.ToString();
            sddv.PhongMa = cbbPhongSDDV.SelectedValue.ToString().Trim();
            sddv.KhachMa = cbbKhachMa.Text.ToString().Trim();
            sddv.DichVuMa = cbbSDDichVu.SelectedValue.ToString().Trim();
            sddv.SoLuong = int.Parse(txtSoLuongSDDV.Text.ToString().Trim());
            if (controller.updateSuDungDichVu(sddv))
            {
                dtgSuDungDichVu.DataSource = controller.getList_SuDungDichVu();
            }
        }
        DataAccess da;
        private void btndatphong_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            dgrdanhsachkhach.DataSource = da.Query("DSKHACHPHONG");
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {

            da = new DataAccess();
            dgrdanhsachkhach.DataSource = da.Query("DSKHACH");
        }

        private void tabPageHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void galleryControl_TrangChu_Gallery_GalleryItemHover(object sender, DevExpress.XtraBars.Ribbon.GalleryItemEventArgs e)
        {
            
        }
    }
}

