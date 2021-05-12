using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Controller
{
    public class LoaiSanPhamController
    {
        public static List<LoaiSanPham> GetLoaiSPs()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.LoaiSanPhams.ToList();
        }
    }
}
