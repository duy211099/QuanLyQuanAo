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
using Lab3;
using CSDLPT_Nhom1.Services;

namespace CSDLPT_Nhom1
{
    public partial class MainForm : Form
    {
        HoaDonService hdService;
        public MainForm()
        {
            InitializeComponent();
            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            hdService = new HoaDonService(unitOfWork);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
            //WorkingContext.Instance.CurrentLoginName;
            lblCN.Text =
            WorkingContext.Instance.CurrentBranch;
            lblUserName.Text = WorkingContext.Instance.CurrentLoginName;
            lblNhom.Text = WorkingContext.Instance.CurrentLoginInfo.RoleName;

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
                item.SubItems.Add(sanpham.Ten);
                item.SubItems.Add(sanpham.Size);
                item.SubItems.Add(sanpham.Gia.ToString());
                item.SubItems.Add(sanpham.SoLuong.ToString());
                item.SubItems.Add(sanpham.ChiNhanh);
                //item.SubItems.Add(sanpham.LoaiSanPham);
                //item.SubItems.Add(sanpham.LoaiSanPhamCha);

                lvwSanPham.Items.Add(item);
            }
        }

        private void ShowSanPhamForNode(TreeNode node)
        {
            lvwSanPham.Items.Clear();

            if (node == null) return;

            List<ChiTietSanPhamModel> sanphams = null;

            if (node.Level == 1)
            {
                sanphams = ChiTietSanPhamController.GetSanPhamByLSPC(node.Text);
            }
            else if (node.Level == 2)
            {
                sanphams = ChiTietSanPhamController.GetSanPhamByLSP(node.Text);
            } else
            {
                sanphams = ChiTietSanPhamController.GetSanPham();
            }
            ShowSanPhams(sanphams);
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
            ShowSanPhamForNode(e.Node);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNhom_Click(object sender, EventArgs e)
        {

        }


        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblCN_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForm f = new NhanVienForm();
            f.ShowDialog();
        }

        private void lvwSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonForm f = new HoaDonForm();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrm f = new LoginFrm();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = lvwSanPham.Items.Count - 1; i >= 0; i--)
                {
                    var item = lvwSanPham.Items[i];
                    if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        lvwSanPham.Items.Remove(item);
                    }
                }
                if (lvwSanPham.SelectedItems.Count == 1)
                {
                    lvwSanPham.Focus();
                }
            }
            else
            {
                ShowCategories();
                ShowSanPhams(ChiTietSanPhamController.GetSanPham());
            }
        }
    }
}
