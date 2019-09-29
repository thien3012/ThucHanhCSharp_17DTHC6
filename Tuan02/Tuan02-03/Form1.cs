using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Text = "Huy";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String stk = txtSoTaiKhoan.Text;
            String ten = txtTenKH.Text;
            String diaChi = txtDaiChiKH.Text;
            String sotien = txtSoTien.Text;
            int index = lisQuanLyTaiKhoan.Items.Count;
            index++;
            string[] row = { index.ToString(), stk, ten, diaChi, sotien };
            ListViewItem lv = new ListViewItem(row);
            lisQuanLyTaiKhoan.Items.Add(lv);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lisQuanLyTaiKhoan.SelectedItems)
            {
                lisQuanLyTaiKhoan.Items.Remove(eachItem);
            }
        }

        private void LisQuanLyTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
