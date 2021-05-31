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
            InitCbbDetail();

            var list = DemoService.Run_SP<SanPhamBanChay>("sp_SpBanChay", batdau, ketthuc);
            showThongKe(list);
            dtpBegin.Value = new DateTime(2019, 1, 1);
            dtpEnd.Value = new DateTime(2012, 1, 1);
            batdau = dtpBegin.Value.ToString("yyyy-MM-dd");
            ketthuc= dtpEnd.Value.ToString("yyyy-MM-dd");
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
                for(int i=1; i < valuesArr.Length; i++)
                {
                    item.SubItems.Add(valuesArr[i]);
                }
                lvwThongKe.Items.Add(item);
            }

            for (int i=0;i<propertiesArr.Length;i++)
            {

                lvwThongKe.Columns[i].Width=-2;
            }
        }

        private void cbbDetail_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbbDetailNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpBegin_ValueChanged_1(object sender, EventArgs e)
        {
            batdau = dtpBegin.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEnd_ValueChanged_1(object sender, EventArgs e)
        {
            ketthuc = dtpEnd.Value.ToString("yyyy-MM-dd");
        }
    }
}
