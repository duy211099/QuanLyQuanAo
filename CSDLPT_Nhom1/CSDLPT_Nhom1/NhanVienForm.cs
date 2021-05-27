using CSDLPT_Nhom1;
using CSDLPT_Nhom1.Controller;
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
	public partial class NhanVienForm : Form
	{
        LinkService linkService;
        HoaDonService hdService;

        public NhanVienForm()
		{			InitializeComponent();

            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            linkService = new LinkService(unitOfWork);
            hdService = new HoaDonService(unitOfWork);
        }

		private void Form3_Load(object sender, EventArgs e)
		{
            cbbCN.SelectedIndex = 0;
            if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC") cbbCN.Enabled = false;
            
        }
        private void ShowNhanVien(List<NhanVien> nhanviens)
        {
            lvwNhanVien.Items.Clear();
            foreach (var nhanvien in nhanviens)
            {
                ListViewItem item = new ListViewItem(nhanvien.MaNV.ToString());
                item.SubItems.Add(nhanvien.Ten);
                item.SubItems.Add(nhanvien.MaCN.ToString());
                item.SubItems.Add(nhanvien.Luong.ToString());
                item.SubItems.Add(nhanvien.NgaySinh.ToString());
                item.SubItems.Add(nhanvien.SDT);
                item.SubItems.Add(nhanvien.DiaChi);

                lvwNhanVien.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCN.SelectedIndex == 0)
            {
                ShowNhanVien(NhanVienController.GetNhanVien());
            }
            else
            {
                try
                {
                    var nhanviens = linkService.GetAllFromRemote();
                    ShowNhanVien(nhanviens);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNhanVien.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvwNhanVien.SelectedItems[0];
            string index = item.Text;
            ShowHoaDons(hdService.GetHoaDonByID(index));
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lvwHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwHoaDon.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvwHoaDon.SelectedItems[0];
            string index = item.Text;
            List<ChiTietHoaDon> cthd=hdService.GetChiTietHoaDonByNVID(index);

            ChiTietHoaDonForm f = new ChiTietHoaDonForm(cthd);
            f.ShowDialog();
        }
    }
}
