using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }
        public int MaLSP { get; set; }
        public string Ten { get; set; }
        public decimal Gia{ get; set; }
        public bool TrangThai{ get; set; }
        public string MoTa{ get; set; }

        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
