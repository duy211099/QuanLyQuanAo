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
    public partial class ThongKeForm : Form
    {
        string batdau;
        string ketthuc;
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            dtpBegin.Value = new DateTime(2019, 1, 1);
            dtpEnd.Value = new DateTime(2022, 1, 1);
            batdau = dtpBegin.Value.ToString("yyyy-MM-dd");
            ketthuc = dtpEnd.Value.ToString("yyyy-MM-dd");

            var list = DemoService.Run_SP<SanPhamBanChay>("sp_SpBanChay", batdau, ketthuc);
            showThongKe(list);

            InitCbbTongDetail();
            InitCbbNVDetail();
            InitCbbDetail();
        }
            private void InitCbbDetail()
        {
            cbbDetail.Items.Clear();

            cbbDetail.DisplayMember = "Text";
            cbbDetail.ValueMember = "Value";

                cbbDetail.Items.Add(new { Text = "Sản phẩm bán chạy", Value = "sp_SpBanChay"});
            cbbDetail.Items.Add(new { Text = "Sản phẩm doanh thu", Value = "sp_SanPhamDoanhThu" });
            cbbDetail.Items.Add(new { Text = "Sản phẩm chưa bán được", Value = "sp_SpChuaBanDuoc" });

            cbbDetail.SelectedIndex = 0;

        }

        private void InitCbbNVDetail()
        {
            cbbDetailNV.Items.Clear();

            cbbDetailNV.DisplayMember = "Text";
            cbbDetailNV.ValueMember = "Value";

            cbbDetailNV.Items.Add(new { Text = "Đơn hàng của nhân viên", Value = "sp_SpBanChay" });
            cbbDetailNV.Items.Add(new { Text = "Doanh thu của nhân viên", Value = "sp_SanPhamDoanhThu" });
            cbbDetailNV.Items.Add(new { Text = "Nhân viên không bán được hàng", Value = "sp_SpChuaBanDuoc" });

            cbbDetailNV.SelectedIndex = 0;

        }

        private void InitCbbTongDetail()
        {
            cbbTong.Items.Clear();

            cbbTong.DisplayMember = "Text";
            cbbTong.ValueMember = "Value";

            cbbTong.Items.Add(new { Text = "Tổng doanh thu", Value = "sp_SpBanChay" });

            cbbTong.SelectedIndex = 0;
        }

        private void showThongKe<T>(List<T> list)
        {
            lvwThongKe.Items.Clear();
            lvwThongKe.Columns.Clear();

            if (list.Count <= 0)
            {
                return;
            }
            string[] temp = list[0].ToString().Split('|');
            string properties = temp[0];
            string[] propertiesArr = properties.Split(',');
            Console.WriteLine(temp[0]);

            foreach (var property in propertiesArr)
            {

                lvwThongKe.Columns.Add(property);
            }
            foreach (var row in list)
            {
                temp = row.ToString().Split('|');
                string values = temp[1];

                Console.WriteLine(temp[1]);
                string[] valuesArr = values.Split(',');

                ListViewItem item = new ListViewItem(valuesArr[0]);
                for (int i = 1; i < valuesArr.Length; i++)
                {
                    item.SubItems.Add(valuesArr[i]);
                }
                lvwThongKe.Items.Add(item);
            }

            for (int i = 0; i < propertiesArr.Length; i++)
            {

                lvwThongKe.Columns[i].Width = -2;
            }
        }

        private void LoadThongKeSanPham()
        {

            if (cbbDetail.SelectedIndex == 0)
            {
                var list = DemoService.Run_SP<SanPhamBanChay>("sp_SpBanChay", batdau, ketthuc);
                showThongKe(list);
            }
            if (cbbDetail.SelectedIndex == 1)
            {
                var list = DemoService.Run_SP<SanPhamDoanhThu>("sp_SanPhamDoanhThu", batdau, ketthuc);
                showThongKe(list);
            }

            if (cbbDetail.SelectedIndex == 2)
            {
                var list = DemoService.Run_SP<SanPhamChuaBan>("sp_SpChuaBanDuoc", batdau, ketthuc);
                showThongKe(list);
            }
        }

        private void LoadThongKeNhanVien()
        {

            if (cbbDetailNV.SelectedIndex == 0)
            {
                var list = DemoService.Run_SP<ThongKeNhanVienDonHang>("sp_NVNhieuDonHang", batdau, ketthuc);
                showThongKe(list);
            }
            if (cbbDetailNV.SelectedIndex == 1)
            {
                var list = DemoService.Run_SP<ThongKeNhanVienDoanhThu>("sp_NVDoanhThu", batdau, ketthuc);
                showThongKe(list);
            }

            if (cbbDetailNV.SelectedIndex == 2)
            {
                var list = DemoService.Run_SP<ThongKeNhanVienKoBan>("sp_NVKoBanHang", batdau, ketthuc);
                showThongKe(list);
            }
        }

        private void LoadThongKeTong()
        {
            if (cbbTong.SelectedIndex == 0)
            {
                var list = DemoService.Run_SP<TongDoanhThu>("sp_TongDoanhThu", batdau, ketthuc);
                showThongKe(list);
            }
        }
        private void cbbDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongKeSanPham();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbbDetailNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongKeNhanVien();
        }

        private void dtpBegin_ValueChanged_1(object sender, EventArgs e)
        {
            batdau = dtpBegin.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEnd_ValueChanged_1(object sender, EventArgs e)
        {
            ketthuc = dtpEnd.Value.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadThongKeSanPham();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadThongKeNhanVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadThongKeTong();
        }

        private void cbbTong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongKeTong();
        }
    }
}
