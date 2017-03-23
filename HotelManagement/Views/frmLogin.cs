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
            frmMain = new frmMain(this);
            frmMain.Visible = true;
            this.Visible = false;
        }
    }
}
