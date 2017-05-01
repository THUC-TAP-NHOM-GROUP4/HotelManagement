using HotelManagement.Controllers;
using HotelManagement.Models;
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
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Phong[] lsPhong = controller.getList_Phong();
            int i;
            String src_image = "";
            String trangthai = "";
            for (i = 0; i < lsPhong.Length; i++)
            {
                src_image = "E:\\HOC_KY_6\\ThucTapNhom\\PROJECT\\HotelManagement\\HotelManagement\\Images\\";
                if (lsPhong[i].TrangThai == 0)
                {
                    trangthai = "Phòng trống";
                    src_image += "no.png";
                }
                else if (lsPhong[i].TrangThai == 1)
                {
                    src_image += "yes.png";
                    trangthai = "Có khách";
                }
                else
                {
                    src_image += "none.jpg";
                    trangthai = "khác";
                }
                galleryControl_TrangChu.Gallery.Groups[0].Items.Add(new DevExpress.XtraBars.Ribbon.GalleryItem(
                        new Bitmap(src_image),lsPhong[i].SoPhong, trangthai));

                galleryControl_TrangChu.Gallery.Groups[0].Items[i].HoverImage =
                    galleryControl_TrangChu.Gallery.Groups[0].Items[i].Image;

            }
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
            tabControlMain.SelectTab(tabPageDatPhongNhanh);
        }

        private void btnTinhTrangPhong_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageTinhTrangPhong);
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

        }
    }
}
