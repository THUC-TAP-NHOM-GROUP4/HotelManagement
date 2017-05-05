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
        public frmMain(int key)
        {
            InitializeComponent();
            Load_();
            tabControlMain.SelectedIndex = 2;//tabpage DatPhong
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //loaded tabpage Trang chu
            Load_tabpage_trangchu();
            //loaded tabpage DatPhong
            Load_tabpage_datphong();
            
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

            foreach (Phong phong in ls_phong_sort)
            {
                src_image = "E:\\HOC_KY_6\\ThucTapNhom\\PROJECT\\HotelManagement\\HotelManagement\\Images\\";
                if (phong.TrangThai == 0)
                {
                    trangthai = "Phòng trống";
                    src_image += "no.png";
                }
                else if (phong.TrangThai == 1)
                {
                    src_image += "yes.png";
                    trangthai = "Có khách";
                }
                else
                {
                    src_image += "none.jpg";
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
            int i;
            Phong[] lsPhong = controller.getList_Phong();
            String src_image = "";
            String trangthai = "";
            IEnumerable<Phong> ls_phong_sort = from phong in lsPhong
                                               orderby phong.SoPhong.Substring(0, 1)
                                               select phong;
            i = 0;
            foreach (Phong phong in ls_phong_sort)
            {
                src_image = "E:\\HOC_KY_6\\ThucTapNhom\\PROJECT\\HotelManagement\\HotelManagement\\Images\\";
                if (phong.TrangThai == 0)
                {
                    trangthai = "Phòng trống";
                    src_image += "no.png";
                }
                else if (phong.TrangThai == 1)
                {
                    src_image += "yes.png";
                    trangthai = "Có khách";
                }
                else
                {
                    src_image += "none.jpg";
                    trangthai = "khác";
                }
                galleryControl_DatPhong.Gallery.Groups[0].Items.Add(
                    new DevExpress.XtraBars.Ribbon.GalleryItem(
                        new Bitmap(src_image), phong.SoPhong, trangthai));

                galleryControl_DatPhong.Gallery.Groups[0].Items[i].HoverImage =
                    galleryControl_DatPhong.Gallery.Groups[0].Items[i].Image;
                i++;
            }

            tbDatPhong_HoTen.Text = "";
            dtpDatPhong_NgaySinh.Text = DateTime.Now.ToShortDateString().ToString();
            cbDatPhong_Nam.Checked = true;
            cbDatPhong_Nu.Checked = false;
            tbDatPhong_CMND.Text = "";
            tbDatPhong_DiaChi.Text = "";
            tbDatPhong_QuocTich.Text = "Việt Nam";
            tbDatPhong_SoDienThoai.Text = "";
            tbDatPhong_SoLuong.Text = "";
            cbbDatPhong_SoPhong.DataSource = controller.getList_Phong_byKey("sophong");
            cbbDatPhong_SoPhong.Text = "";
            cbbDatPhong_LoaiPhong.Text = "";
            cbbDatPhong_LoaiPhong.DataSource = controller.getList_Phong_byKey("loaiphong");
            cbbDatPhong_DonGia.Text = "";
            cbbDatPhong_DonGia.DataSource = controller.getList_Phong_byKey("dongia");
            tbDatPhong_TrangThai.Text = "";
            cbbDatPhong_TrangThietBi.Text = "";
            cbbDatPhong_TrangThietBi.DataSource = controller.getList_TrangThietBi("");
            dtpDatPhong_NgayDen.Text = DateTime.Now.ToShortDateString().ToString();
            dtpDatPhong_NgayDi.Text = DateTime.Now.ToShortDateString().ToString();
            tbDatPhong_GioDen.Text = "";
            tbDatPhong_GioDi.Text = "";

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageThongKe);
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
            cbbDatPhong_DonGia.Text = phong.DonGia.ToString() ;
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

        private void nbiMain_ThongKe_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageThongKe);
        }

        private void nbiMain_Thoat_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }

        private void btnDatPhong_DatPhong_Click(object sender, EventArgs e)
        {
            Khach khach = new Khach();
            khach.Ten = tbDatPhong_HoTen.Text;
            khach.NgaySinh = DateTime.Parse(dtpDatPhong_NgaySinh.Value.ToShortDateString());
            if (cbDatPhong_Nam.Checked) khach.GioiTinh = 1;
            else khach.GioiTinh = 0;
            khach.DiaChi = tbDatPhong_DiaChi.Text;
            khach.QuocTich = tbDatPhong_QuocTich.Text;
            khach.SoDienThoai = tbDatPhong_SoDienThoai.Text;
            khach.ChungMinhThu = tbDatPhong_CMND.Text;
            controller.ThemKhachHang(khach);


            khach.Ma = controller.getMaKhach(khach);


            DangKy dangky = new DangKy();
            dangky.NgayDangKy = DateTime.Now;
            dangky.KhachMa = khach.Ma;
            dangky.NgayDen = dtpDatPhong_NgayDen.Value;
            dangky.GioDen = int.Parse(tbDatPhong_GioDen.Text);
            dangky.NgayDi = dtpDatPhong_NgayDi.Value;
            dangky.GioDi = int.Parse(tbDatPhong_GioDi.Text);
            dangky.PhongMa = controller.get_MaPhong(cbbDatPhong_SoPhong.Text.ToString().Trim());
            dangky.TienDatCoc = double.Parse(tbDatPhong_TienDatCoc.Text);
            dangky.NhanVienMa = nhanvien.Ma;
            //ma- ngaydangky- khachma- ngayden- gioden- ngaydi- giodi- phongma - tiendatcoc- nhanvienma
            if (tbDatPhong_TrangThai.Text == "Có khách" || tbDatPhong_TrangThai.Text == "Khác")
            {
                MessageBox.Show("Không đặt phòng này");

                return;
            }
            controller.DatPhong(dangky);
            MessageBox.Show("Đặt phòng thành công", "Đặt phòng");
            tabControlMain.SelectTab(tabPageTrangChu);
           
            Load_();
            /*String khachMa, String phongMa, DateTime ngayDen, int gioDen, DateTime ngayDi, int gioDi, double tienDatCoc,
            String nhanVienMa)*/
        }

        private void btnDatPhong_Huy_Click(object sender, EventArgs e)
        {
            Load_tabpage_datphong();
        }

        private void btnDatPhong_Thoat_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageTrangChu);
        }

        private void cbbDatPhong_SoPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbDatPhong_TrangThietBi.DataSource = controller.getList_TrangThietBi(cbbDatPhong_SoPhong.SelectedValue.ToString().Trim());

        }
    }
}
