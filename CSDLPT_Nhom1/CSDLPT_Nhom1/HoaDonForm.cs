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
                item.SubItems.Add(hoadon.TongTien.ToString());

                lvwHoaDon.Items.Add(item);
            }
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            ShowHoaDons(hdService.GetAllHoaDon());
        }
    }
}
