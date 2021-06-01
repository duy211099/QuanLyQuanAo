using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Service
{
    public class DemoService
    {
        public static List<T> Run_SP<T>(string sp_name, string batdau, string ketthuc)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();
            string query = "exec "+ sp_name +
                " @NgayBatDau = '" + batdau + "', " +
                "@NgayKetThuc = '" + ketthuc + "'"; ;
            var ngu = dbContext.Database.SqlQuery<T>(query).ToList();

            return ngu;
        }
        public static void TaoTaiKhoan(string lgname, string pass, string username, string role )
        {
            var dbContext = WorkingContext.Instance.GetDbContext();
            string query = "EXEC sp_TaoTaiKhoan @LGNAME = N'"+lgname+"', @PASS = N'"+pass+"',	@USERNAME = N'"+ username + "', @ROLE = N'"+ role + "' ";

            dbContext.NhanViens.SqlQuery(query).ToList();
        }

        public static void XoaTaiKhoan(string MaNV)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();
            string query = "EXEC sp_XoaNV @MaNV = "+ MaNV ;

            var ngu = dbContext.NhanViens.SqlQuery(query).ToList();
        }
        public static void ChuyenTaiKhoan(string MaNV)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();
            string query = "EXEC sp_ChuyenChiNhanh @MaNV = " + MaNV;

            var ngu = dbContext.Database.ExecuteSqlCommand(query);
        }

        public static List<T> Read_SP<T>(string sp_name)
        {
            var dbContext = WorkingContext.Instance.GetDbContext();
            string query = "EXEC "+ sp_name;

            var ngu = dbContext.Database.SqlQuery<T>(query).ToList();

            return ngu;
        }
    }
}
