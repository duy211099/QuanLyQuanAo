using CSDLPT_Nhom1.Controller;
using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Services
{
    public class LoginService : CrudService<Login>, IAuthenticateService
    {
        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        // LoginModel
        public Login GetLoginInfo(string loginName)
        {
            return _unitOfWork.SprocQuery<Login>("sp_GetLoginInfoo", new object[] { loginName }).FirstOrDefault();
        }
    }
}
