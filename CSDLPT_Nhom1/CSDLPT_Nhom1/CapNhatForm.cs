using CSDLPT_Nhom1.Controller;
using CSDLPT_Nhom1.Models;
using CSDLPT_Nhom1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_Nhom1
{
    public partial class CapNhatForm : Form
    {
        public CapNhatForm()
        {
            InitializeComponent();
        }

        private void CapNhatForm_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            ShowNhanVienCN1(NhanVienController.GetNhanVien());
            ShowNhanVienCN2(NhanVienController.GetNhanVienRemote());
        }

        private void ShowNhanVienCN1(List<NhanVien> nhanviens)
        {
            lvwCN1.Items.Clear();
            foreach (var nhanvien in nhanviens)
            {
                ListViewItem item = new ListViewItem(nhanvien.MaNV.ToString());
                item.SubItems.Add(nhanvien.Ten);
                item.SubItems.Add(nhanvien.MaCN.ToString());
                item.SubItems.Add(nhanvien.Luong.ToString());
                item.SubItems.Add(nhanvien.NgaySinh.ToString());
                item.SubItems.Add(nhanvien.SDT);
                item.SubItems.Add(nhanvien.DiaChi);

                lvwCN1.Items.Add(item);
            }

            for (int i = 0; i < lvwCN1.Columns.Count; i++)
            {

                lvwCN1.Columns[i].Width = -2;
            }
        }

        private void ShowNhanVienCN2(List<NhanVien> nhanviens)
        {
            lvwCN2.Items.Clear();
            foreach (var nhanvien in nhanviens)
            {
                ListViewItem item = new ListViewItem(nhanvien.MaNV.ToString());
                item.SubItems.Add(nhanvien.Ten);
                item.SubItems.Add(nhanvien.MaCN.ToString());
                item.SubItems.Add(nhanvien.Luong.ToString());
                item.SubItems.Add(nhanvien.NgaySinh.ToString());
                item.SubItems.Add(nhanvien.SDT);
                item.SubItems.Add(nhanvien.DiaChi);

                lvwCN2.Items.Add(item);
            }

            for (int i = 0; i < lvwCN2.Columns.Count; i++)
            {

                lvwCN2.Columns[i].Width = -2;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            DemoService.ChuyenTaiKhoan(lvwCN1.SelectedItems[0].Text);
            Reload();
        }

        private void lvwCN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCN1.SelectedItems.Count == 0)
            {
                btnChuyen.Enabled = false;
            }
            else
            {
                btnChuyen.Enabled = true;
            }
        }
    }
}
