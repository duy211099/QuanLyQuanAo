using CSDLPT_Nhom1;
using CSDLPT_Nhom1.Models;
using CSDLPT_Nhom1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	public partial class HoaDonForm : Form
    {
        HoaDonService hdService;
        public HoaDonForm()
		{
			InitializeComponent();
            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            hdService = new HoaDonService(unitOfWork);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowHoaDons(List<HoaDon> hoadons)
        {
            lvwHoaDon.Items.Clear();
            foreach (var hoadon in hoadons)
            {
                ListViewItem item = new ListViewItem(hoadon.MaHD.ToString());
                item.SubItems.Add(hoadon.MaNV.ToString());
                item.SubItems.Add(hoadon.TenNV.ToString());
                item.SubItems.Add(hoadon.TenKH.ToString());
                item.SubItems.Add(hoadon.SDT.ToString());
                item.SubItems.Add(hoadon.NgayMua.ToString());

                lvwHoaDon.Items.Add(item);
            }

            for (int i = 0; i < lvwHoaDon.Columns.Count; i++)
            {

                lvwHoaDon.Columns[i].Width = -2;
            }
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            ShowHoaDons(hdService.GetAllHoaDon());

            if (WorkingContext.Instance.CurrentBranch == "Chi Nhánh Bùi Thị Xuân")
            {
                cbbCN.SelectedIndex = 0;
            }
            else
            {
                cbbCN.SelectedIndex = 1;
            }

            if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC") cbbCN.Enabled = false;
        }

        private void cbbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCN.SelectedIndex == 0)
            {
                ShowHoaDons(hdService.GetAllHoaDon());
            }
            else
            {
                try
                {
                    ShowHoaDons(hdService.GetAllHoaDonCN());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
