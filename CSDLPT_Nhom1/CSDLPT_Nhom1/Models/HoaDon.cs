using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public int GiamGia { get; set; }
        //public decimal TongTien { get; set; }
        public DateTime NgayMua { get; set; }
        //public decimal TamTinh { get; set; }
        //public int GiamGia { get; set; }
        //public decimal TongTien { get; set; }

        //public NhanVien NhanVien{ get; set; }
    }
}
