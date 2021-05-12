using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class ChiTietSanPham
    {
        [Key]
        public int MaCTSP { get; set; }
        public int MaCN { get; set; }
        public int MaSP { get; set; }
        public string Size { get; set; }
        public string Mau { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string GiamGia { get; set; }

        public SanPham SanPham { get; set; }
        public ChiNhanh ChiNhanh { get; set; }
    }
}
