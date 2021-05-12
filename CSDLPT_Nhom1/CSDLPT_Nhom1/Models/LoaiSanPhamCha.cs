using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class LoaiSanPhamCha
    {
        [Key]
        public int MaLSPCha { get; set; }

        public string Ten { get; set; }
    }
}
