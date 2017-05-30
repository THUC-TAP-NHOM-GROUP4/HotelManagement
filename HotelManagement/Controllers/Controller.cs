using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Controllers
{
    public class Controller
    {
        DataAccess da = new DataAccess();
        public Controller()
        {

        }
        public Phong[] getList_Phong()
        {
            DataTable table = da.Query("select *from phong");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            Phong[] list = new Phong[n];
            for (i = 0; i < n; i++)
            {
                list[i] = get_Phong(table.Rows[i]);
            }
            return list;
        }
        public List<LoaiPhong> getList_LoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            DataTable table = da.Query("select *from LoaiPhong");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            for (i = 0; i < n; i++)
            {
                list.Add(get_LoaiPhong(table.Rows[i]));
            }
            return list;
        }
        public List<DichVu> getList_DichVu()
        {
            List<DichVu> list = new List<DichVu>();
            DataTable table = da.Query("select *from DichVu");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            for (i = 0; i < n; i++)
            {
                list.Add(get_DichVu(table.Rows[i]));
            }
            return list;
        }
        public List<SuDungDichVu> getList_SuDungDichVu()
        {
            List<SuDungDichVu> list = new List<SuDungDichVu>();
            DataTable table = da.Query("select *from SuDungDichVu");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            for (i = 0; i < n; i++)
            {
                list.Add(get_SuDungDichVu(table.Rows[i]));
            }
            return list;
        }
        public List<Khach> getList_Khach()
        {
            List<Khach> list = new List<Khach>();
            DataTable table = da.Query("select *from Khach");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            for (i = 0; i < n; i++)
            {
                list.Add(get_Khach(table.Rows[i]));
            }
            return list;

        }
        public Khach get_Khach(DataRow row)
        {
            Khach k = new Khach();
            k.Ma = row["ma"].ToString().Trim();
            k.Ten = row["ten"].ToString().Trim();
            k.NgaySinh = DateTime.Parse(row["ngaysinh"].ToString().Trim());
            bool gt = true;
            if (bool.TryParse(row["gioitinh"].ToString().Trim(), out gt))
                k.GioiTinh = 1;
            else k.GioiTinh = 0;
            k.DiaChi = row["diachi"].ToString().Trim();
            k.QuocTich = row["quoctich"].ToString().Trim();
            k.ChungMinhThu = row["chungminhthu"].ToString().Trim();
            k.SoDienThoai = row["sodienthoai"].ToString().Trim();
            return k;

        }

        public SuDungDichVu get_SuDungDichVu(DataRow row)
        {
            SuDungDichVu sddv = new SuDungDichVu();
            sddv.Ma = row["ma"].ToString().Trim();
            sddv.PhongMa = row["phongma"].ToString().Trim();
            sddv.KhachMa = row["khachma"].ToString().Trim();
            sddv.DichVuMa = row["dichvuma"].ToString().Trim();
            sddv.NgaySuDung = DateTime.Parse(row["ngaysudung"].ToString().Trim());
            sddv.SoLuong = int.Parse(row["soluong"].ToString().Trim());
            double thanhtien = 0;
            double.TryParse(row["thanhtien"].ToString().Trim(), out thanhtien);
            sddv.ThanhTien = thanhtien;
            return sddv;
        }
        public DichVu get_DichVu(DataRow row)
        {
            DichVu dv = new DichVu();
            dv.Ma = row["ma"].ToString().Trim();
            dv.Ten = row["ten"].ToString().Trim();
            double gia = 0;
            double.TryParse(row["dongia"].ToString().Trim(), out gia);
            dv.DonGia = gia;
            return dv;
        }
        public LoaiPhong get_LoaiPhong(DataRow row)
        {
            LoaiPhong loaiphong = new LoaiPhong();
            loaiphong.Ma = row["ma"].ToString().Trim();
            loaiphong.Ten = row["ten"].ToString().Trim();
            loaiphong.MoTa = row["mota"].ToString().Trim();
            loaiphong.SoLuong = int.Parse(row["soluong"].ToString().Trim());
            double giaquangay = 0;
            if (double.TryParse(row["giaquangay"].ToString().Trim(), out giaquangay))
            {
                loaiphong.GiaQuaNgay = giaquangay;
            }
            double giaquadem = 0;
            if (double.TryParse(row["giaquadem"].ToString().Trim(), out giaquadem))
            {
                loaiphong.GiaQuaDem = giaquadem;
            }
            return loaiphong;
        }

        public bool addLoaiPhong(LoaiPhong lp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ten",lp.Ten),
                new SqlParameter("mota",lp.MoTa),
                new SqlParameter("soluong",lp.SoLuong),
                new SqlParameter("giaquangay",lp.GiaQuaNgay),
                new SqlParameter("giaquadem",lp.GiaQuaDem)
            };
            da.Query("procedure_insertLoaiPhong", para);
            return true;
        }
        public bool addPhong(Phong p)
        {
            SqlParameter[] para =
            {
                new SqlParameter("sophong",p.SoPhong),
                new SqlParameter("loaiphong",p.LoaiPhong),
                new SqlParameter("trangthai",p.TrangThai)
            };
            da.Query("procedure_insertPhong", para);
            return true;
        }
        public bool addDichVu(DichVu dv)
        {
            SqlParameter[] para =
         {
                new SqlParameter("ten",dv.Ten),
                new SqlParameter("dongia",dv.DonGia)

            };
            da.Query("procedure_insertDichVu", para);
            return true;
        }
        public bool addSuDungDichVu(SuDungDichVu sddv)
        {

            SqlParameter[] para =
         {
                new SqlParameter("phongma",sddv.PhongMa),
                new SqlParameter("khachma",sddv.KhachMa),
                new SqlParameter("dichvuma",sddv.DichVuMa),
                new SqlParameter("soluong",sddv.SoLuong),

            };
            da.Query("procedure_insertSuDungDichVu", para);
            return true;
        }
        public bool updateLP(LoaiPhong lp)
        {

            SqlParameter[] para =
            {
                new SqlParameter("ma",lp.Ma),
                new SqlParameter("ten",lp.Ten),
                new SqlParameter("mota",lp.MoTa),
                new SqlParameter("soluong",lp.SoLuong),
                new SqlParameter("giaquangay",lp.GiaQuaNgay),
                new SqlParameter("giaquadem",lp.GiaQuaDem)
            };
            da.Query("procedure_updateLoaiPhong", para);
            return true;
        }
        public bool updatePhong(Phong p)
        {

            SqlParameter[] para =
            {
                new SqlParameter("ma",p.Ma),
                new SqlParameter("sophong",p.SoPhong),
                new SqlParameter("loaiphong",p.LoaiPhong),
                new SqlParameter("trangthai",p.TrangThai)

            };
            da.Query("procedure_updatePhong", para);
            return true;
        }
        public bool updateDichVu(DichVu dv)
        {

            SqlParameter[] para =
            {
                new SqlParameter("ma",dv.Ma),
                new SqlParameter("ten",dv.Ten),
                new SqlParameter("dongia",dv.DonGia)
            };
            da.Query("procedure_updateDichVu", para);
            return true;
        }
        public bool updateSuDungDichVu(SuDungDichVu sddv)
        {
            SqlParameter[] para =
      {
                new SqlParameter("ma",sddv.Ma),
                new SqlParameter("phongma",sddv.PhongMa),
                new SqlParameter("khachma",sddv.KhachMa),
                new SqlParameter("dichvuma",sddv.DichVuMa),
                new SqlParameter("soluong",sddv.SoLuong),

            };
            da.Query("procedure_updateSuDungDichVu", para);
            return true;
        }
        public void XoaLoaiPhong(string ma)
        {
            da.NonQuery("delete LoaiPhong where ma='" + ma + "'");
        }
        public void XoaPhong(string ma)
        {
            da.NonQuery("delete Phong where ma='" + ma + "'");
        }
        public void XoaDichVu(string ma)
        {
            da.NonQuery("delete DichVu where ma='" + ma + "'");
        }

        public String[] getList_Phong_byKey(String key)
        {
            //chỉ hiển thị danh sách phòng trống
            DataTable table = da.Query("select distinct phong.ma, phong.sophong, phong.trangthai, phong.dongia, loaiphong.ten as loaiphongma from phong inner join LoaiPhong "
                + " on phong.loaiphongma = LoaiPhong.ma where phong.trangthai = 0 group by phong.ma, phong.sophong,phong.trangthai, phong.dongia, loaiphong.ten");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            String[] list = new String[n];
            for (i = 0; i < n; i++)
            {
                switch (key)
                {
                    case "sophong":
                        list[i] = get_Phong(table.Rows[i]).SoPhong;
                        break;
                    case "loaiphong":
                        list[i] = get_Phong(table.Rows[i]).LoaiPhong;
                        break;
                    case "dongia":
                        list[i] = get_Phong(table.Rows[i]).DonGia.ToString();
                        break;
                    default:
                        break;
                }

            }
            return list;
        }
        public String[] getList_LoaiPhong_byKey(String loaiphongma)
        {
            DataTable table = da.Query("select * from loaiphong ");
            int n = table.Rows.Count;
            int i, count = 0 ;
            if (n == 0) return null;
            String[] list = new String[n];
            for (i = 0; i < n; i++)
            {
                if (loaiphongma == "loaiphong")
                {
                    list[count++] = table.Rows[i]["ten"].ToString().Trim();
                   // break;
                }
                else if (table.Rows[i]["ma"].ToString().Trim() == loaiphongma)
                        list[count++] = table.Rows[i]["ten"].ToString().Trim();
            }
            return list;
        }
        public String[] getList_TrangThietBi(String sophong)
        {
            if (sophong == "")
                return new String[0];
            DataTable table = da.Query("select *from ThietBiPhong where "
                + "thietbiphong.phongma = (select ma from phong where phong.sophong = '" + sophong + "')");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            String[] list = new String[n];
            String ten = "";
            int soluong = 0;
            for (i = 0; i < n; i++)
            {
                ten = table.Rows[i]["ten"].ToString().Trim();
                soluong = int.Parse(table.Rows[i]["soluong"].ToString().Trim());
                list[i] = ten + "(" + soluong + ")";
            }
            return list;
        }
        private Phong get_Phong(DataRow row)
        {
            Phong phong = new Phong();
            phong.Ma = row["ma"].ToString().Trim();
            phong.SoPhong = row["sophong"].ToString().Trim();
            double dongia = 0;
            if (Double.TryParse(row["dongia"].ToString().Trim(), out dongia))
            {
                phong.DonGia = dongia;
            }
            int trangthai = 0;
            if (int.TryParse(row["trangthai"].ToString().Trim(), out trangthai))
                phong.TrangThai = trangthai;
            phong.LoaiPhong = row["loaiphongma"].ToString().Trim();
            return phong;
        }
        public Phong get_Phong(String sophong)
        {
            Phong phong = new Phong();
            DataTable table = da.Query("select *from Phong where phong.sophong = N'" + sophong + "'");
            int n = table.Rows.Count;
            int i;
            if (n == 1)
            {
                phong.Ma = table.Rows[0]["ma"].ToString().Trim();
                phong.SoPhong = table.Rows[0]["sophong"].ToString().Trim();
                phong.DonGia = double.Parse(table.Rows[0]["dongia"].ToString().Trim());
                phong.LoaiPhong = table.Rows[0]["loaiphongma"].ToString().Trim();
                phong.TrangThai = int.Parse(table.Rows[0]["trangthai"].ToString().Trim());
            }
            return phong;
        }
        public String get_Phong(String sophong, String key)
        {
            Phong phong = new Phong();
            DataTable table;
            if (key == "loaiphong")
            {
                table = da.Query("select ten from loaiphong inner join phong on phong.loaiphongma = loaiphong.ma"
                    + " where phong.sophong = " + sophong);
                key = "ten";
            }
            else table = da.Query("select  " + key + " from Phong where phong.sophong = N'" + sophong + "'");
            int n = table.Rows.Count;
            if (n == 1)
            {
                return table.Rows[0][key].ToString().Trim();
            }
            return "";
        }
        public String getMaKhach(Khach khach)
        {
            DataTable table = da.Query("select ma from khach where ten = N'" + khach.Ten + "' and gioitinh = " + khach.GioiTinh
                + " and quoctich = N'" + khach.QuocTich + "' and chungminhthu = '" + khach.ChungMinhThu + "'");
            String ma = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ma"].ToString().Trim();
            return ma;
        }
        public string getTenKhach(string ma)
        {
            DataTable table = da.Query("select ten from Khach where ma='" + ma + "'");
            string ten = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ten"].ToString().Trim();
            return ten;
        }
        public int getTrangThai(String soPhong)
        {
            String maphong = get_Phong(soPhong, "ma");
            DataTable table = da.Query("select trangthai from Phong where phong.ma = N'" + maphong + "'");
            int n = table.Rows.Count;
            int i;
            if (n == 1)
            {
                return int.Parse(table.Rows[0]["trangthai"].ToString().Trim());
            }
            return 2;
        }
        public void ThemKhachHang(Khach khach)
        {
            /*
    create proc proc_insertKhach(@ten nvarchar(50), @ngaysinh date, @gioitinh int, @diachi nvarchar(50),
    @quoctich nvarchar(30), @chungminhthu varchar(20), @sodienthoai varchar(12))*/
            SqlParameter[] para =
            {
                new SqlParameter("ten", khach.Ten),
                new SqlParameter("ngaysinh", khach.NgaySinh),
                new SqlParameter("gioitinh", khach.GioiTinh),
                new SqlParameter("diachi", khach.DiaChi),
                new SqlParameter("quoctich", khach.QuocTich),
                new SqlParameter("chungminhthu", khach.ChungMinhThu),
                new SqlParameter("sodienthoai", khach.SoDienThoai)
            };
            da.Query("proc_insertKhach", para);
        }

        public bool DatPhong(DangKy dk)
        {
            /*proc_insert_DatPhong](@khachma varchar(20), @phongma varchar(20),@ngaydangky date, @ngayden date, @gioden int, 
    @ngaydi date, @giodi int, @tiendatcoc money , @nhanvienma varchar(20)*/
            SqlParameter[] para =
            {
                //([proc_insert_DatPhong](@khachma varchar(20), @phongma varchar(20),@ngaydangky date, @ngayden date, @gioden int, 
//@ngaydi date, @giodi int, @tiendatcoc money , @nhanvienma varchar(20))
                new SqlParameter("khachma", dk.KhachMa),
                new SqlParameter("phongma", dk.PhongMa),
                new SqlParameter("ngaydangky",dk.NgayDangKy),
                new SqlParameter("ngayden", dk.NgayDen),
                new SqlParameter("gioden", dk.GioDen),
                new SqlParameter("ngaydi", dk.NgayDi),
                new SqlParameter("giodi", dk.GioDi),
                new SqlParameter("tiendatcoc", dk.TienDatCoc),
                new SqlParameter("nhanvienma", dk.NhanVienMa)
            };
            da.Query("proc_insert_DatPhong", para);
            return true;
        }
        public bool checkLogin(String username, String password)
        {
            DataTable table = da.Query("select ma from NhanVien where NhanVien.taikhoan  = '" + username + "' and NhanVien.matkhau = '" + password + "'");
            int n = table.Rows.Count;
            if (n == 1)
                return true;
            return false;
        }
        public NhanVien getNhanVien(String username, String password)
        {
            NhanVien nv = new NhanVien();
            DataTable table = da.Query("select *from NhanVien where NhanVien.taikhoan  = '" + username + "' and NhanVien.matkhau = '" + password + "'");
            int n = table.Rows.Count;
            int i;
            if (n == 1)
            {
                nv.Ma = table.Rows[0]["ma"].ToString().Trim();
                nv.Ten = table.Rows[0]["ten"].ToString().Trim();
                nv.TaiKhoan = username;
                nv.MatKhau = password;
            }
            return nv;
        }
        public DangKy[] getList_DangKy()
        {
            DataTable table = da.Query("select dk.ma, dk.ngaydangky, Khach.ten as [tenkhach], dk.ngayden, dk.gioden, dk.ngaydi, "
                                        + " dk.giodi, Phong.sophong as [sophong], dk.tiendatcoc, NhanVien.ten as [tennhanvien] "

                                        + " from dangky dk inner join Khach on dk.khachma = Khach.ma "

                                        + " inner  join NhanVien on NhanVien.ma = dk.nhanvienma "
                                        + " inner  join Phong on Phong.ma = dk.phongma "

                                        + " group by dk.ma, dk.ngaydangky, Khach.ten, dk.ngayden, dk.gioden, dk.ngaydi,dk.giodi, "
                                        + "          Phong.sophong, dk.tiendatcoc, NhanVien.ten ");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            DangKy[] list = new DangKy[n];
            DangKy dk = new DangKy();
            int soluong = 0;
            DateTime date = DateTime.Now;
            for (i = 0; i < n; i++)
            {
                dk = new DangKy();
                dk.Ma = table.Rows[i]["ma"].ToString().Trim();
                if (DateTime.TryParse(table.Rows[i]["ngaydangky"].ToString().Trim(), out date))
                {
                    dk.NgayDangKy = date;
                }
                dk.KhachMa = table.Rows[i]["tenkhach"].ToString().Trim();
                date = DateTime.Now;
                if (DateTime.TryParse(table.Rows[i]["ngayden"].ToString().Trim(), out date))
                {
                    dk.NgayDen = date;
                }
                date = DateTime.Now;
                dk.GioDen = int.Parse(table.Rows[i]["gioden"].ToString().Trim());
                if (DateTime.TryParse(table.Rows[i]["ngaydi"].ToString().Trim(), out date))
                {
                    dk.NgayDi = date;
                }
                dk.GioDi = int.Parse(table.Rows[i]["giodi"].ToString().Trim());

                dk.TienDatCoc = double.Parse(table.Rows[i]["tiendatcoc"].ToString().Trim());
                dk.NhanVienMa = table.Rows[i]["tennhanvien"].ToString().Trim();
                dk.PhongMa = table.Rows[i]["sophong"].ToString().Trim();
                list[i] = dk;
            }
            return list;
        }


    }
}

