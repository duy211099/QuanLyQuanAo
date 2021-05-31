using CSDLPT_Nhom1.Models;
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
    public partial class ChiTietHoaDonForm : Form
    {
        List<ChiTietHoaDon> cthd;
        public ChiTietHoaDonForm(List<ChiTietHoaDon> cthd)
        {
            InitializeComponent();
            this.cthd = cthd;
        }

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            ShowCTHoaDons(cthd);
        }

        private void ShowCTHoaDons(List<ChiTietHoaDon> cts)
        {
            lvwCTHoaDon.Items.Clear();
            foreach (var ct in cts)
            {
                ListViewItem item = new ListViewItem(ct.MaSP.ToString());
                item.SubItems.Add(ct.Ten.ToString());
                item.SubItems.Add(ct.SoLuong.ToString());
                item.SubItems.Add(ct.Size.ToString());
                item.SubItems.Add(ct.TongTien.ToString());

                lvwCTHoaDon.Items.Add(item);
            }

            for (int i = 0; i < lvwCTHoaDon.Columns.Count; i++)
            {

                lvwCTHoaDon.Columns[i].Width = -2;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
