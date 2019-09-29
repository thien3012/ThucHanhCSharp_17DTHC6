namespace Tuan02_04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cxbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cxbNam = new System.Windows.Forms.CheckBox();
            this.cxbNu = new System.Windows.Forms.CheckBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lisB1 = new System.Windows.Forms.ListBox();
            this.lisB2 = new System.Windows.Forms.ListBox();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnSangTrai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma sinh vien";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ho Ten";
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyen Nganh";
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gioi Tinh";
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chon cac mon hoc tham gia";
            this.label5.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(174, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(247, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(174, 36);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(247, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // cxbChuyenNganh
            // 
            this.cxbChuyenNganh.AccessibleDescription = "";
            this.cxbChuyenNganh.FormattingEnabled = true;
            this.cxbChuyenNganh.Items.AddRange(new object[] {
            "He Thong Thong Tin",
            "Cong Nghe Phan Mem",
            "An Toan Thong Tin"});
            this.cxbChuyenNganh.Location = new System.Drawing.Point(174, 108);
            this.cxbChuyenNganh.Name = "cxbChuyenNganh";
            this.cxbChuyenNganh.Size = new System.Drawing.Size(247, 21);
            this.cxbChuyenNganh.TabIndex = 2;
            this.cxbChuyenNganh.Text = "Hệ Thống Thông Tin";
            this.cxbChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.CxbChuyenNganh_SelectedIndexChanged);
            // 
            // cxbNam
            // 
            this.cxbNam.AutoSize = true;
            this.cxbNam.Location = new System.Drawing.Point(174, 149);
            this.cxbNam.Name = "cxbNam";
            this.cxbNam.Size = new System.Drawing.Size(48, 17);
            this.cxbNam.TabIndex = 3;
            this.cxbNam.Text = "Nam";
            this.cxbNam.UseVisualStyleBackColor = true;
            this.cxbNam.CheckedChanged += new System.EventHandler(this.CxbNam_CheckedChanged);
            // 
            // cxbNu
            // 
            this.cxbNu.AutoSize = true;
            this.cxbNu.Location = new System.Drawing.Point(257, 149);
            this.cxbNu.Name = "cxbNu";
            this.cxbNu.Size = new System.Drawing.Size(40, 17);
            this.cxbNu.TabIndex = 3;
            this.cxbNu.Text = "Nu";
            this.cxbNu.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.ChuyenNganh,
            this.GioiTinh,
            this.SoMon});
            this.dgvSinhVien.Location = new System.Drawing.Point(64, 349);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(545, 150);
            this.dgvSinhVien.TabIndex = 4;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSinhVien_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSinhVien_CellContentClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Ho Ten";
            this.HoTen.Name = "HoTen";
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.HeaderText = "Chuyen Nganh";
            this.ChuyenNganh.Name = "ChuyenNganh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Gioi Tinh";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SoMon
            // 
            this.SoMon.HeaderText = "So Mon";
            this.SoMon.Name = "SoMon";
            // 
            // lisB1
            // 
            this.lisB1.FormattingEnabled = true;
            this.lisB1.Location = new System.Drawing.Point(99, 204);
            this.lisB1.Name = "lisB1";
            this.lisB1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lisB1.Size = new System.Drawing.Size(155, 69);
            this.lisB1.TabIndex = 5;
            this.lisB1.SelectedIndexChanged += new System.EventHandler(this.LisB1_SelectedIndexChanged);
            // 
            // lisB2
            // 
            this.lisB2.FormattingEnabled = true;
            this.lisB2.Location = new System.Drawing.Point(357, 204);
            this.lisB2.Name = "lisB2";
            this.lisB2.Size = new System.Drawing.Size(155, 69);
            this.lisB2.TabIndex = 5;
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Location = new System.Drawing.Point(158, 293);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(109, 34);
            this.btnLuuThongTin.TabIndex = 6;
            this.btnLuuThongTin.Text = "Luu Thong Tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            this.btnLuuThongTin.Click += new System.EventHandler(this.BtnLuuThongTin_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(336, 293);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(98, 34);
            this.btnXoaChon.TabIndex = 6;
            this.btnXoaChon.Text = "Xoa Chon";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.BtnXoaChon_Click);
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Location = new System.Drawing.Point(283, 204);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(40, 23);
            this.btnSangPhai.TabIndex = 7;
            this.btnSangPhai.Text = ">";
            this.btnSangPhai.UseVisualStyleBackColor = true;
            this.btnSangPhai.Click += new System.EventHandler(this.BtnSangPhai_Click);
            // 
            // btnSangTrai
            // 
            this.btnSangTrai.Location = new System.Drawing.Point(283, 250);
            this.btnSangTrai.Name = "btnSangTrai";
            this.btnSangTrai.Size = new System.Drawing.Size(40, 23);
            this.btnSangTrai.TabIndex = 8;
            this.btnSangTrai.Text = "<";
            this.btnSangTrai.UseVisualStyleBackColor = true;
            this.btnSangTrai.Click += new System.EventHandler(this.BtnSangTrai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 521);
            this.Controls.Add(this.btnSangTrai);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.lisB2);
            this.Controls.Add(this.lisB1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.cxbNu);
            this.Controls.Add(this.cxbNam);
            this.Controls.Add(this.cxbChuyenNganh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cxbChuyenNganh;
        private System.Windows.Forms.CheckBox cxbNam;
        private System.Windows.Forms.CheckBox cxbNu;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ListBox lisB2;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnSangTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMon;
        public System.Windows.Forms.ListBox lisB1;
    }
}

