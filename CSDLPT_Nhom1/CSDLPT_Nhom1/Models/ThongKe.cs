using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class SanPhamBanChay
    {
        public int MaCTSP { get; set; }
        public string LoaiSanPham{ get; set; }
        public string TenSanPham { get; set; }
        public string Size { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongBan { get; set; }
        //public decimal DoanhThu { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã CTSP,";
            rs += "Loại,";
            rs += "Tên,";
            rs += "Size,";
            rs += "Giá,";
            rs += "Số lượng bán|";

            rs += MaCTSP.ToString() + ",";
            rs += LoaiSanPham.ToString() + ",";
            rs += TenSanPham.ToString() + ",";
            rs += Size.ToString() + ",";
            rs += Gia.ToString() + ",";
            rs += SoLuongBan.ToString() + ",";
            //rs += DoanhThu.ToString();


            return rs;
        }
    }

    public class SanPhamDoanhThu
    {
        public int MaCTSP { get; set; }
        public string LoaiSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string Size { get; set; }
        public decimal Gia { get; set; }
        public decimal DoanhThu { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã CTSP,";
            rs += "Loại,";
            rs += "Tên,";
            rs += "Size,";
            rs += "Giá,";
            rs += "Doanh Thu|";

            rs += MaCTSP.ToString() + ",";
            rs += LoaiSanPham.ToString() + ",";
            rs += TenSanPham.ToString() + ",";
            rs += Size.ToString() + ",";
            rs += Gia.ToString() + ",";
            rs += DoanhThu.ToString();


            return rs;
        }
    }

    public class SanPhamChuaBan
    {
        public int MaCTSP { get; set; }
        public string LoaiSanPham { get; set; }
        public string Ten { get; set; }
        public string Size { get; set; }
        public int HangTon { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã sản phẩm,";
            rs += "Loại,";
            rs += "Tên,";
            rs += "Size,";
            rs += "Hàng tồn|";

            rs += MaCTSP.ToString() + ",";
            rs += LoaiSanPham.ToString() + ",";
            rs += Ten.ToString() + ",";
            rs += Size.ToString() + ",";
            rs += HangTon.ToString() ;

            return rs;
        }
    }

    public class Temp
    {
        public int MaCTSP { get; set; }
        public string LoaiSanPham { get; set; }
        public string Ten { get; set; }
        public string Size { get; set; }
        public int HangTon { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã sản phẩm,";
            rs += "Hàng tồn|";

            rs += MaCTSP.ToString() + ",";
            rs += HangTon.ToString();

            return rs;
        }
    }

    public class ThongKeNhanVienDoanhThu
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public decimal TONGTIEN { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã nhân viên,";
            rs += "Tên nhân viên,";
            rs += "Tổng tiền|";

            rs += MaNV.ToString() + ",";
            rs += TenNV.ToString() + ",";
            rs += TONGTIEN.ToString();

            return rs;
        }
    }

    public class ThongKeNhanVienDonHang
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public int SoDonHang { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã nhân viên,";
            rs += "Tên nhân viên,";
            rs += "Số đơn hàng|";

            rs += MaNV.ToString() + ",";
            rs += TenNV.ToString() + ",";
            rs += SoDonHang.ToString();

            return rs;
        }
    }

    public class ThongKeNhanVienKoBan
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Mã nhân viên,";
            rs += "Tên nhân viên|";

            rs += MaNV.ToString() + ",";
            rs += TenNV.ToString() + ",";

            return rs;
        }
    }

    public class TongDoanhThu
    {
        public decimal TONGTIEN { get; set; }
        public int SoDonHang { get; set; }

        override public string ToString()
        {
            string rs = "";
            rs += "Tổng doanh thu,";
            rs += "Số đơn hàng|";

            rs += TONGTIEN.ToString() + ",";
            rs += SoDonHang.ToString();

            return rs;
        }
    }

    public class NhanVienTaiKhoan
    {
        public int MaNV { get; set; }
        public int MaCN { get; set; }
        public string Ten { get; set; }
        public string TenTK { get; set; }
        public string ChucVu { get; set; }
    }

    public class NhanVienKoTaiKhoan
    {
        public int MaNV { get; set; }
        public int MaCN { get; set; }
        public string Ten { get; set; }
        public string ChucVu { get; set; }
    }
}
