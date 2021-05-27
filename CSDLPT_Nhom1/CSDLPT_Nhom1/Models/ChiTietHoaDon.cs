using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public string Ten { get; set; }
        public string Size{ get; set; }
        public decimal GiaHienTai { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
    }
}
