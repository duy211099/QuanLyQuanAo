using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class ChiTietSanPhamModel
    {
        public int MaCTSP { get; set; }
        public string ChiNhanh{ get; set; }
        public string Ten { get; set; }
        public string Size { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
    }
}
