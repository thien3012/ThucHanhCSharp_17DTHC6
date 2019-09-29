using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan02
{
    public partial class frmDatVeXemPhim : Form
    {
        List<Button> dsChon = new List<Button>();
        List<String> hangDau = new List<string> { "1", "2", "3", "4", "5" };
        List<String> hangHai = new List<string> { "6", "7", "8", "9", "10" };
        List<String> hangCuoi = new List<string> { "11", "12", "13", "14", "15" };
        public frmDatVeXemPhim()
        {
            InitializeComponent();
        }
        private void Choose_Click(object sender, EventArgs e)
        {
            Button btnChonVe = (Button)sender;
            if (btnChonVe.BackColor == Color.White)
            {
                btnChonVe.BackColor = Color.Blue;
                dsChon.Add(btnChonVe);
            }
            else if (btnChonVe.BackColor == Color.Blue)
            {
                btnChonVe.BackColor = Color.White;
                dsChon.Remove(btnChonVe);
            }
            else
            {
                MessageBox.Show("Ve da duoc chon!");
            }
        }
        private void Chon_Click(object sender, EventArgs e)
        {      
            int tongTien = 0;
            foreach (var soGhe in dsChon)
            {
                if (hangDau.Any(s => s.ToString() == soGhe.Text))
                {
                    tongTien += 5000;
                }
                else if (hangHai.Any(s => s.ToString() == soGhe.Text))
                {
                    tongTien += 6500;
                }
                else
                {
                    tongTien += 8000;
                }
                soGhe.BackColor = Color.Yellow;
            }
            txtThanhTien.Text = tongTien.ToString();
            dsChon.Clear();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            foreach (Control soGhe in grbGhe.Controls)
            {
                if (soGhe.BackColor == Color.Blue)
                {
                    soGhe.BackColor = Color.White;       
                }
            }
        }

        private void KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatVeXemPhim_Load(object sender, EventArgs e)
        {

        }
    }

}
