namespace QuanLySanPham
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
			this.chkXemTatCa = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// chkXemTatCa
			// 
			this.chkXemTatCa.AutoSize = true;
			this.chkXemTatCa.Location = new System.Drawing.Point(38, 28);
			this.chkXemTatCa.Name = "chkXemTatCa";
			this.chkXemTatCa.Size = new System.Drawing.Size(147, 17);
			this.chkXemTatCa.TabIndex = 0;
			this.chkXemTatCa.Text = "Xem Tất Cả Trong Tháng";
			this.chkXemTatCa.UseVisualStyleBackColor = true;
			this.chkXemTatCa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thời Gian Giao Hàng";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(203, 118);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(357, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "~";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(414, 117);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(107, 20);
			this.dateTimePicker2.TabIndex = 2;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHD,
            this.NgayDat,
            this.NgayGiao,
            this.ThanhTien});
			this.dgvHoaDon.Location = new System.Drawing.Point(12, 157);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.Size = new System.Drawing.Size(776, 293);
			this.dgvHoaDon.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(526, 465);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tổng";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Location = new System.Drawing.Point(586, 465);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(13, 13);
			this.lblTongTien.TabIndex = 1;
			this.lblTongTien.Text = "0";
			// 
			// STT
			// 
			this.STT.HeaderText = "STT";
			this.STT.Name = "STT";
			// 
			// SoHD
			// 
			this.SoHD.HeaderText = "Số Hóa Đơn";
			this.SoHD.Name = "SoHD";
			// 
			// NgayDat
			// 
			this.NgayDat.HeaderText = "Ngày Đặt";
			this.NgayDat.Name = "NgayDat";
			// 
			// NgayGiao
			// 
			this.NgayGiao.HeaderText = "Ngày Giao";
			this.NgayGiao.Name = "NgayGiao";
			// 
			// ThanhTien
			// 
			this.ThanhTien.HeaderText = "Thành Tiền";
			this.ThanhTien.Name = "ThanhTien";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 487);
			this.Controls.Add(this.dgvHoaDon);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkXemTatCa);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkXemTatCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
	}
}

