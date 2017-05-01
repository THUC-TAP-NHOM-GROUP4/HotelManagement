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
        private frmMain frmMain;
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isCheckedTrue())
            {
                frmMain = new frmMain(this);
                frmMain.Visible = true;
                this.Visible = false;
            }
            else
            {
                login_erp_username.SetError(login_textbox_username, "Tên đăng nhập sai hoặc không tồn tại!");
                login_erp_password.SetError(login_textbox_password, "Mật khẩu không đúng");
            }
        }
        private bool isCheckedTrue()
        {
            return true;
        }
    }
}
