using CSDLPT_Nhom1.Controller;
using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Services
{
    public class LinkService : CrudService<NhanVien>
    {
        public LinkService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public List<NhanVien> GetAllFromRemote()
        {
            var ngu = _unitOfWork.SprocQuery<NhanVien>("sp_GetAllNV", new object[] { }).ToList();
            return ngu;
        }
        public Login GetLoginInfo(string loginName)
        {
            return _unitOfWork.SprocQuery<Login>("sp_GetLoginInfo", new object[] { "duyp" }).FirstOrDefault();
        }
    }
}
