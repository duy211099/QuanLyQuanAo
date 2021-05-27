using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Controller
{
    public class SanPhamController
    {
        public static List<SanPhamModel> GetSanPham()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.SanPhams.Select(x => new SanPhamModel() {
                MaSP = x.MaSP,
                LoaiSanPham = x.LoaiSanPham.Ten,
                Ten =x.Ten,
                Gia=x.Gia,
                TrangThai=x.TrangThai,
                MoTa=x.MoTa
            }).OrderBy(x=>x.Ten).ToList();
        }
    }
}
