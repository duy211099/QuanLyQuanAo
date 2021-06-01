
namespace CSDLPT_Nhom1
{
    partial class TaiKhoanForm
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
            this.lvwNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwNVTK = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwNhanVien
            // 
            this.lvwNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvwNhanVien.HideSelection = false;
            this.lvwNhanVien.Location = new System.Drawing.Point(12, 12);
            this.lvwNhanVien.Name = "lvwNhanVien";
            this.lvwNhanVien.Size = new System.Drawing.Size(454, 229);
            this.lvwNhanVien.TabIndex = 1;
            this.lvwNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvwNhanVien.View = System.Windows.Forms.View.Details;
            this.lvwNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvwNhanVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức Vụ";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Chi Nhánh";
            this.columnHeader5.Width = 90;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(101, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(121, 20);
            this.txtMa.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(101, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(121, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(101, 68);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(121, 20);
            this.txtMK.TabIndex = 4;
            // 
            // cbbCV
            // 
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(101, 94);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(121, 21);
            this.cbbCV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chức Vụ";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(101, 131);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(121, 23);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Tạo tài khoản";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCV);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(472, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lvwNVTK
            // 
            this.lvwNVTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwNVTK.HideSelection = false;
            this.lvwNVTK.Location = new System.Drawing.Point(15, 276);
            this.lvwNVTK.Name = "lvwNVTK";
            this.lvwNVTK.Size = new System.Drawing.Size(583, 229);
            this.lvwNVTK.TabIndex = 14;
            this.lvwNVTK.UseCompatibleStateImageBehavior = false;
            this.lvwNVTK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã NV";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ Tên";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chức Vụ";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Chi Nhánh";
            this.columnHeader8.Width = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhân viên đã có tài khoản:";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên tài khoản";
            this.columnHeader9.Width = 84;
            // 
            // TaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwNVTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwNhanVien);
            this.Name = "TaiKhoanForm";
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwNVTK;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
    }
}