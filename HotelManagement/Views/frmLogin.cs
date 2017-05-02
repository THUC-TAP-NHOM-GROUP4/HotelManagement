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
    public partial class frmLogin : Form
    {
        private Controller control = new Controller();
        private frmMain frmMain;
        private NhanVien nhanvien = new NhanVien();
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isCheckedTrue())
            {
                nhanvien = control.getNhanVien(login_textbox_username.Text.ToString().Trim(), 
                    login_textbox_password.Text.ToString().Trim());
                frmMain = new frmMain(this, nhanvien);
                frmMain.Visible = true;
                this.Visible = false;
                login_erp_username.Clear();
                login_erp_password.Clear();
            }
            else
            {
                login_erp_username.SetError(login_textbox_username, "Tên đăng nhập sai hoặc không tồn tại!");
                login_erp_password.SetError(login_textbox_password, "Mật khẩu không đúng");
            }
        }
        private bool isCheckedTrue()
        {
            String username = login_textbox_username.Text.ToString().Trim();
            String password = login_textbox_password.Text.ToString().Trim();
            if (username.Equals("")) return false;
            else if (password.Equals("")) return false;
            else if (control.checkLogin(username, password))
                return true;
            return false;
        }
    }
}
