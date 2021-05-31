using CSDLPT_Nhom1.Controller;
using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Services
{
    public class HoaDonService : CrudService<HoaDon>
    {
        public HoaDonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public List<HoaDon> GetAllHoaDon()
        {
            var ngu = _unitOfWork.SprocQuery<HoaDon>("sp_CRUDHoaDon", new object[] {null, null, null, null, null, null, "selectall"}).ToList();
            return ngu;
        }

        public List<HoaDon> GetAllHoaDonCN()
        {
            var ngu = _unitOfWork.SprocQuery<HoaDon>("GetAllHoaDonCN", new object[] {}).ToList();
            return ngu;
        }
        public List<HoaDon> GetHoaDonByID(string Id)
        {
            var ngu = _unitOfWork.SprocQuery<HoaDon>("sp_NhanVienHoaDon", new object[] { Id }).ToList();
            return ngu;
        }
        public List<ChiTietHoaDon> GetChiTietHoaDonByNVID(string Id)
        {
            var ngu = _unitOfWork.SprocQuery<ChiTietHoaDon>("sp_ChiTietHoaDon", new object[] { Id }).ToList();
            return ngu;
        }
    }
}
