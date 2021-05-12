using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Controller
{
    class ChiTietSanPhamController
    {
        public static List<ChiTietSanPhamModel> GetSanPham()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.ChiTietSanPhams.Select(x => new ChiTietSanPhamModel()
            {
                MaCTSP = x.MaCTSP,
                ChiNhanh = x.ChiNhanh.Ten,
                Ten = x.SanPham.Ten,
                Size = x.Size,
                Gia = x.SanPham.Gia,
                SoLuong = x.SoLuong
            }).ToList();
        }
    }
}
