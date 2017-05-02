﻿using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Controllers
{
    class Controller
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
        private Phong get_Phong(DataRow row)
        {
            Phong phong = new Phong();
            phong.Ma = row["ma"].ToString().Trim();
            phong.SoPhong = row["sophong"].ToString().Trim();
            double dongia = 0;
            if( Double.TryParse(row["dongia"].ToString().Trim(), out dongia))
            {
                phong.DonGia = dongia;
            }
            int trangthai = 0;
            if (int.TryParse(row["trangthai"].ToString().Trim(), out trangthai))
                phong.TrangThai = trangthai;

            return phong;
        }
        public Phong get_Phong(String sophong)
        {
            Phong phong = new Phong();
            DataTable table = da.Query("select *from Phong where phong.sophong = N'" + sophong + "'");
            int n = table.Rows.Count;
            int i;
            if(n== 1)
            {
                phong.Ma = table.Rows[0]["ma"].ToString().Trim();
                phong.SoPhong = table.Rows[0]["sophong"].ToString().Trim();
                phong.DonGia = double.Parse(table.Rows[0]["dongia"].ToString().Trim());
                phong.LoaiPhong = table.Rows[0]["loaiphongma"].ToString().Trim();
                phong.TrangThai = int.Parse(table.Rows[0]["trangthai"].ToString().Trim());
            }
            return phong;
        }
    }
}

