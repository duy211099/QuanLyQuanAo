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
                SoLuong = x.SoLuong,
                LoaiSanPhamCha = x.SanPham.LoaiSanPham.LoaiSanPhamCha.Ten,
                LoaiSanPham = x.SanPham.LoaiSanPham.Ten
            }).OrderBy(x => x.Ten).ToList();
        }
        public static List<ChiTietSanPhamModel> GetSanPhamByLSPC(string lspc)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.ChiTietSanPhams.Select(x => new ChiTietSanPhamModel()
            {
                MaCTSP = x.MaCTSP,
                ChiNhanh = x.ChiNhanh.Ten,
                Ten = x.SanPham.Ten,
                Size = x.Size,
                Gia = x.SanPham.Gia,
                SoLuong = x.SoLuong,
                LoaiSanPhamCha = x.SanPham.LoaiSanPham.LoaiSanPhamCha.Ten,
                LoaiSanPham = x.SanPham.LoaiSanPham.Ten
            }).Where(x=>x.LoaiSanPhamCha==lspc).OrderBy(x => x.Ten).ToList();
        }
        public static List<ChiTietSanPhamModel> GetSanPhamByLSP(string lsp)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.ChiTietSanPhams.Select(x => new ChiTietSanPhamModel()
            {
                MaCTSP = x.MaCTSP,
                ChiNhanh = x.ChiNhanh.Ten,
                Ten = x.SanPham.Ten,
                Size = x.Size,
                Gia = x.SanPham.Gia,
                SoLuong = x.SoLuong,
                LoaiSanPhamCha = x.SanPham.LoaiSanPham.LoaiSanPhamCha.Ten,
                LoaiSanPham = x.SanPham.LoaiSanPham.Ten
            }).OrderBy(x => x.Ten).Where(x => x.LoaiSanPham == lsp).ToList();
        }
        
    }
}
