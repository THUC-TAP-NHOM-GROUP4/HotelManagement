using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class SuDungDichVu
    {
        public SuDungDichVu() { }
        public string Ma { get; set; }
        public string PhongMa { get; set; }
        public string KhachMa { get; set; }
        public string DichVuMa { get; set; }
        public DateTime NgaySuDung { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
    }
}
