using CSDLPT_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLPT_Nhom1.Controller;

namespace CSDLPT_Nhom1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
            //WorkingContext.Instance.CurrentLoginName;
            lblCN.Text =
            WorkingContext.Instance.CurrentBranch;
            lblUserName.Text = WorkingContext.Instance.CurrentLoginName;

            ShowCategories();
            ShowSanPhams(ChiTietSanPhamController.GetSanPham());
        }

        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();

            var rootNode = tvwCategory.Nodes.Add("Tất cả");
            var loaiSanPhamChas = LoaiSanPhamChaController.GetLoaiSPChas();
            var loaiSanPhams = LoaiSanPhamController.GetLoaiSPs();

            foreach (var loaiSanPhamCha in loaiSanPhamChas)
            {
                var childNode = rootNode.Nodes.Add(loaiSanPhamCha.MaLSPCha.ToString(), loaiSanPhamCha.Ten);

                foreach (var loaiSanPham in loaiSanPhams)
                {
                    if (loaiSanPham.MaLSPCha != loaiSanPhamCha.MaLSPCha) continue;
                    var granctChildNode = childNode.Nodes.Add(loaiSanPham.MaLSP.ToString(), loaiSanPham.Ten);
                }
            }


            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNode;
        }

        private void ShowSanPhams(List<ChiTietSanPhamModel> sanphams) {
            lvwSanPham.Items.Clear();
            foreach(var sanpham in sanphams)
            {
                ListViewItem item = new ListViewItem (sanpham.MaCTSP.ToString());
                item.SubItems.Add(sanpham.ChiNhanh);
                item.SubItems.Add(sanpham.Ten);
                item.SubItems.Add(sanpham.Size.ToString());
                item.SubItems.Add(sanpham.SoLuong.ToString());
                item.SubItems.Add(sanpham.Gia.ToString());

                lvwSanPham.Items.Add(item);
            }
        }
        static bool TestConnectionString(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    return (conn.State == ConnectionState.Open);
                }
                catch
                {
                    return false;
                }
            }
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNhom_Click(object sender, EventArgs e)
        {

        }
    }
}
