using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLPT_Nhom1.Controller;
using CSDLPT_Nhom1.Models;

namespace CSDLPT_Nhom1
{
    public sealed class WorkingContext
    {
        private static WorkingContext _instance = null;
        private ShopContext _dbContext = null;
        private IUnitOfWork _unitOfWork;
        private string _currentConnectionString;
        public static WorkingContext Instance => _instance ?? (_instance = new WorkingContext());


        // LoginModel
        public Login CurrentLoginInfo { get; set; }

        public string CurrentBranch { get; set; }

        public string CurrentLoginName { get; set; }

        private WorkingContext()
        {

        }

        public void Initialize(string connectionString)
        {
            _currentConnectionString = connectionString;
            _dbContext = new ShopContext(_currentConnectionString);
            _unitOfWork = new UnitOfWork(_dbContext);
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return _unitOfWork;
        }

        public ShopContext GetDbContext()
        {
            return _dbContext;        
        }
    }
}
