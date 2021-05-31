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
    public partial class TaiKhoanForm : Form
    {
        public TaiKhoanForm()
        {
            InitializeComponent();
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            ShowNhanVien(NhanVienController.GetNhanVien());
            InitCbbCV();
        }


        private void ShowNhanVien(List<NhanVien> nhanviens)
        {
            lvwNhanVien.Items.Clear();
            foreach (var nhanvien in nhanviens)
            {
                ListViewItem item = new ListViewItem(nhanvien.MaNV.ToString());
                item.SubItems.Add(nhanvien.Ten);
                item.SubItems.Add(nhanvien.ChucVu.ToString());
                item.SubItems.Add(nhanvien.MaCN.ToString());;

                lvwNhanVien.Items.Add(item);
            }

            for (int i = 0; i < lvwNhanVien.Columns.Count; i++)
            {

                lvwNhanVien.Columns[i].Width = -2;
            }
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNhanVien.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvwNhanVien.SelectedItems[0];
            txtMa.Text = item.Text;
        }

        private void InitCbbCV()
        {
            cbbCV.Items.Clear();

            cbbCV.DisplayMember = "Text";
            cbbCV.ValueMember = "Value";

            cbbCV.Items.Add(new { Text = "Quản lý Chi Nhánh", Value = "QLCHINHANH" });
            cbbCV.Items.Add(new { Text = "Nhân Viên", Value = "NHANVIEN" });

            cbbCV.SelectedIndex = 0;
            string temp=(cbbCV.SelectedItem as dynamic).Value;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                DemoService.TaoTaiKhoan(txtTen.Text, txtMK.Text, txtMa.Text, (cbbCV.SelectedItem as dynamic).Value);
                MessageBox.Show("Đã tạo thành công\r\n", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Đã tạo thành công\r\n" , "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DemoService.XoaTaiKhoan(txtMa.Text);
                ShowNhanVien(NhanVienController.GetNhanVien());
                MessageBox.Show("Thành công\r\n", "Thông báo", MessageBoxButtons.OK);
                ShowNhanVien(NhanVienController.GetNhanVien());
            }
            catch
            {
                MessageBox.Show("Ngu\r\n", "Thông báo", MessageBoxButtons.OK);
                ShowNhanVien(NhanVienController.GetNhanVien());
            }            
        }
    }
}
