
namespace CSDLPT_Nhom1
{
    partial class ThongKeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDetail = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbDetailNV = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvwThongKe = new System.Windows.Forms.ListView();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 397);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbbDetail);
            this.tabPage1.Controls.Add(this.lvwThongKe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // cbbDetail
            // 
            this.cbbDetail.FormattingEnabled = true;
            this.cbbDetail.Location = new System.Drawing.Point(6, 25);
            this.cbbDetail.Name = "cbbDetail";
            this.cbbDetail.Size = new System.Drawing.Size(244, 21);
            this.cbbDetail.TabIndex = 1;
            this.cbbDetail.SelectedIndexChanged += new System.EventHandler(this.cbbDetail_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbDetailNV);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbDetailNV
            // 
            this.cbbDetailNV.FormattingEnabled = true;
            this.cbbDetailNV.Location = new System.Drawing.Point(6, 15);
            this.cbbDetailNV.Name = "cbbDetailNV";
            this.cbbDetailNV.Size = new System.Drawing.Size(244, 21);
            this.cbbDetailNV.TabIndex = 3;
            this.cbbDetailNV.SelectedIndexChanged += new System.EventHandler(this.cbbDetailNV_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 351);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvwThongKe
            // 
            this.lvwThongKe.HideSelection = false;
            this.lvwThongKe.Location = new System.Drawing.Point(6, 52);
            this.lvwThongKe.Name = "lvwThongKe";
            this.lvwThongKe.Size = new System.Drawing.Size(756, 351);
            this.lvwThongKe.TabIndex = 0;
            this.lvwThongKe.UseCompatibleStateImageBehavior = false;
            this.lvwThongKe.View = System.Windows.Forms.View.Details;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(356, 24);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 7;
            this.dtpBegin.Value = new System.DateTime(2019, 5, 31, 22, 11, 0, 0);
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dtpBegin_ValueChanged_1);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(584, 24);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.Value = new System.DateTime(2022, 5, 31, 22, 11, 0, 0);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged_1);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDetail;
        private System.Windows.Forms.ListView lvwThongKe;
        private System.Windows.Forms.ComboBox cbbDetailNV;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}