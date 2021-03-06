using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Controller
{
    public class NhanVienController
    {
        public static List<NhanVien> GetNhanVien()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.NhanViens.SqlQuery("SELECT * FROM NhanVien WHERE TrangThai=1").ToList();
        }
        public static List<NhanVien> GetNhanVienRemote()
        {
            var dbContext = WorkingContext.Instance.GetDbContext();

            return dbContext.NhanViens.SqlQuery("SELECT * FROM LINK.CSDLPT1.dbo.NhanVien WHERE TrangThai=1").ToList(); 
        }
    }
}
