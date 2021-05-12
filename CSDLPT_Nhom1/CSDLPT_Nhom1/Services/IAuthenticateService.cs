using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Services
{
    public interface IAuthenticateService
    {
        Login GetLoginInfo(string loginName);
    }
}
