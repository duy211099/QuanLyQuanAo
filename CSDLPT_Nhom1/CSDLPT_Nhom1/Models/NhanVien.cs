using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        public int MaCN { get; set; }
        public string Ten { get; set; }
        public decimal Luong { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    }
}
