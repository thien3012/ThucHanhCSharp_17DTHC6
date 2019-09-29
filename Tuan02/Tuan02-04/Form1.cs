using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LisB1_SelectedIndexChanged(object sender, EventArgs e)
        {                  
        }

        private void CxbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {    
            string chon = cxbChuyenNganh.Text;
            switch (chon)
            {
                case "He Thong Thong Tin":
                    lisB1.Items.Add("Phan tich thiet ke HTTT");
                    lisB1.Items.Add("Co so du lieu NC");
                    lisB1.Items.Add("Co so du lieu");
                    break;
                case "Cong Nghe Phan Mem":
                    lisB1.Items.Add("Lap Trinh Java");
                    lisB1.Items.Add("Kiem thu phan mem");
                    lisB1.Items.Add("Co so du lieu");
                    break;
                case "An Toan Thong Tin":
                    lisB1.Items.Add("Ma hoa thong tin");
                    lisB1.Items.Add("An thong tin tren du lieu so");
                    lisB1.Items.Add("Co so du lieu");
                    break;    
            }            
        }

        private void BtnLuuThongTin_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string tenSV = txtHoTen.Text;
            string nganh = cxbChuyenNganh.Text;
            string gioiTinh = null;
            if(cxbNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            if (cxbNu.Checked == true)
            {
                gioiTinh = "Nu";
            }
            int tongSoMon = lisB2.Items.Count;
            dgvSinhVien.Rows.Add(maSV, tenSV, nganh, gioiTinh, tongSoMon);
            txtHoTen.Text = "";
            txtMaSV.Text = "";
            lisB1.Items.Clear();
            lisB2.Items.Clear();
        }

        private void CxbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(cxbNam.Checked == true)
            {
                cxbNu.Checked = false;
            }
            if (cxbNu.Checked == true)
            {
                cxbNam.Checked = false;
            }
        }

        private void BtnSangPhai_Click(object sender, EventArgs e)
        {
            string curItem = lisB1.SelectedItem.ToString();
            lisB2.Items.Add(curItem);
            lisB1.Items.Remove(curItem);
        }

        private void BtnSangTrai_Click(object sender, EventArgs e)
        {
            string curItem = lisB2.SelectedItem.ToString();
            lisB1.Items.Add(curItem);
            lisB2.Items.Remove(curItem);
        }

        private void DgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvSinhVien.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMaSV.Text = row.Cells["MSSV"].Value.ToString();
                txtHoTen.Text = row.Cells["Ho Ten"].Value.ToString();
                cxbChuyenNganh.Text = row.Cells[3].Value.ToString();               
                if(row.Cells[4].Value.ToString() == "Nam")
                {
                    cxbNam.Checked = true;
                }
                if (row.Cells[4].Value.ToString() == "Nu")
                {
                    cxbNu.Checked = true;
                }

            }
        }

        private void BtnXoaChon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvSinhVien.SelectedRows)
            {
                dgvSinhVien.Rows.RemoveAt(item.Index);
            }
        }

        private void DgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvSinhVien.Rows[index];
            txtMaSV.Text = selectedRow.Cells[0].Value.ToString();
            txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
            cxbChuyenNganh.Text = selectedRow.Cells[2].Value.ToString();
            if (selectedRow.Cells[4].Value.ToString() == "Nam")
            {
                cxbNam.Checked = true;
                cxbNu.Checked = false;
            }
            if (selectedRow.Cells[4].Value.ToString() == "Nu")
            {
                cxbNu.Checked = true;
                cxbNam.Checked = false;
            }
        }
    }
}
