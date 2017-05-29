using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class DangKy
    {
        //ma- ngaydangky- khachma- ngayden- gioden- ngaydi- giodi- phongma - tiendatcoc- nhanvienma
        public String Ma { get; set; }
        public DateTime NgayDangKy { get; set; }
        public String KhachMa { get; set; }
        public DateTime NgayDen { get; set; }
        public int GioDen { get; set; }
        public DateTime NgayDi { get; set; }
        public int GioDi { get; set; }
        public String PhongMa { get; set; }
        public double TienDatCoc { get; set; }
        public String NhanVienMa { get; set; }
    }
}
