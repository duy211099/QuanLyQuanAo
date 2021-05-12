
namespace CSDLPT_Nhom1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblNhom = new System.Windows.Forms.Label();
            this.lvwSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tvwCategory
            // 
            this.tvwCategory.Location = new System.Drawing.Point(12, 12);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(180, 426);
            this.tvwCategory.TabIndex = 1;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 466);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "lblUsername";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(110, 466);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(32, 13);
            this.lblCN.TabIndex = 3;
            this.lblCN.Text = "lblCN";
            // 
            // lblNhom
            // 
            this.lblNhom.AutoSize = true;
            this.lblNhom.Location = new System.Drawing.Point(223, 466);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Size = new System.Drawing.Size(45, 13);
            this.lblNhom.TabIndex = 4;
            this.lblNhom.Text = "lblNhom";
            this.lblNhom.Click += new System.EventHandler(this.lblNhom_Click);
            // 
            // lvwSanPham
            // 
            this.lvwSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwSanPham.HideSelection = false;
            this.lvwSanPham.Location = new System.Drawing.Point(209, 12);
            this.lvwSanPham.Name = "lvwSanPham";
            this.lvwSanPham.Size = new System.Drawing.Size(579, 426);
            this.lvwSanPham.TabIndex = 0;
            this.lvwSanPham.UseCompatibleStateImageBehavior = false;
            this.lvwSanPham.View = System.Windows.Forms.View.Details;
            this.lvwSanPham.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 179;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 87;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lblNhom);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tvwCategory);
            this.Controls.Add(this.lvwSanPham);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.ListView lvwSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

