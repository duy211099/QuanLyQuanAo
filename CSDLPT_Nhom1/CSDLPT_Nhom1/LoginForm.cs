using CSDLPT_Nhom1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_Nhom1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string branch, loginName, password;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập");
            }

            if (cbbCN.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh");
                return;
            }

            branch = cbbCN.Text;
            int branchId = cbbCN.SelectedIndex + 1;

            loginName = txtUsername.Text;
            password = txtPassword.Text;

            WorkingContext.Instance.CurrentBranch = branch;
            WorkingContext.Instance.CurrentLoginName = loginName;

            var connectionName = string.Format("CN{0}", branchId);
            var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            connectionString = string.Format(connectionString, loginName, password);
            WorkingContext.Instance.Initialize(connectionString);

            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            var authService = new LoginService(unitOfWork);

            try
            {
                var loginInfo = authService.GetLoginInfo(loginName);
                WorkingContext.Instance.CurrentLoginInfo = loginInfo;

                MainForm f = new MainForm();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbbCN.SelectedIndex = 0;
        }
    }
}
