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

namespace HotelManagement.Views
{
    public partial class frmChiTietPhong : Form
    {
        Controller controller = new Controller();
        Phong phong;
        frmMain frmMain;
        public frmChiTietPhong()
        {
            InitializeComponent();
        }
        public frmChiTietPhong(String sophong, frmMain frmMain)
        {
            InitializeComponent();
            this.phong = controller.get_Phong(sophong);

            this.frmMain = frmMain;
        }
        private void frmChiTietPhong_Load(object sender, EventArgs e)
        {
            lblSoPhong.Text = phong.SoPhong;
            lblKhachHang.Text = "khach";
            if (phong.TrangThai == 0)
            {
                lblTrangThai.Text = "Trống";
                btnDatPhong.Enabled = true;
            }
            else if (phong.TrangThai == 1)
            {
                lblTrangThai.Text = "Có khách";
                btnDatPhong.Enabled = false;
               
            }
            else
            {
                lblTrangThai.Text = "Khác";
                btnDatPhong.Enabled = false;
            } 
            lblTang.Text = phong.SoPhong.Substring(0, 1);
            cbbTrangThietBi.DataSource = new String[1] { "" };
            lblSoLuong.Text = "0";

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            this.frmMain = new frmMain(1);
            this.Close();
        }

        private void frmChiTietPhong_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


    }
}
