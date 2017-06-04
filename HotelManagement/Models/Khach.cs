using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class Khach
    {
        public String Ma { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set;  }
        public int GioiTinh { get; set; }
        public String DiaChi { get; set; }
        public String QuocTich { get; set; }
        public String ChungMinhThu { get; set; }
        public String SoDienThoai { get; set; }
        DataAccess da = new DataAccess();
        public void ThemKhachHang(string ten, DateTime ngaysinh , int gioitinh, string diachi, string quoctich, string chungminhthu, string sdt)
        {
            da.NonQuery("ThemKhachHang", new SqlParameter("@ten", ten)
                            , new SqlParameter("@ngaysinh", ngaysinh)
                            , new SqlParameter("@gioitinh", gioitinh)
                            , new SqlParameter("@diachi", diachi)
                            , new SqlParameter("@quoctich", quoctich)
                            , new SqlParameter("@socmnd", chungminhthu)
                            , new SqlParameter("@sodienthoai", sdt));
        }
        public void SuaThongTinKhachHang(string ma,string ten, DateTime ngaysinh, int gioitinh, string diachi, string quoctich, string chungminhthu, string sdt)
        {
            da.NonQuery("SuaThongTinKhach", new SqlParameter("@ma", ma)
                            , new SqlParameter("@ten", ten)
                            , new SqlParameter("@ngaysinh", ngaysinh)
                            , new SqlParameter("@gioitinh", gioitinh)
                            , new SqlParameter("@diachi", diachi)
                            , new SqlParameter("@quoctich", quoctich)
                            , new SqlParameter("@socmnd", chungminhthu)
                            , new SqlParameter("@sodt", sdt));
        }
        public void XoaKhachHang(string ma)
        {
            da.NonQuery("XoaThongTinKhach", new SqlParameter("@ma", ma));
        }
    }
}
