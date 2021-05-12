//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class SanPhamModel
    {
        public int MaSP { get; set; }
        public string LoaiSanPham{ get; set; }

        public string Ten { get; set; }
        public decimal Gia { get; set; }
        public bool TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}
