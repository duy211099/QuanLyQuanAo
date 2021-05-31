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
}
