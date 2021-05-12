using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int MaLSP { get; set; }
        public int MaLSPCha { get; set; }
        public string Ten { get; set; }

        public LoaiSanPhamCha LoaiSanPhamCha { get; set; }
    }
}
