using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Controller
{
    public class LoaiSanPhamChaController
    {
       public static List<LoaiSanPhamCha> GetLoaiSPChas()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.LoaiSanPhamChas.ToList();
        }
    }
}
