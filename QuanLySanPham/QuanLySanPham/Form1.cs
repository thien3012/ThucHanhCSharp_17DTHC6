using QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		public void SetGridViewStyle(DataGridView dgview)
		{
			dgview.BorderStyle = BorderStyle.None;
			dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
			dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
			dgview.BackgroundColor = Color.White;
			dgview.EnableHeadersVisualStyles = false;
			dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
			dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgview.AllowUserToDeleteRows = false;
			dgview.AllowUserToAddRows = false;
			dgview.AllowUserToOrderColumns = true;
			dgview.MultiSelect = false;
			dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		private void BindGrid(List<Invoice> listHoaDon)
		{
			dgvHoaDon.Rows.Clear();
			int id = 1;
			foreach (var item in listHoaDon)
			{
				int index = dgvHoaDon.Rows.Add();
				dgvHoaDon.Rows[index].Cells[0].Value = id++;
				dgvHoaDon.Rows[index].Cells[1].Value = item.InvoiceNo;
				dgvHoaDon.Rows[index].Cells[2].Value = item.OrderDate;
				dgvHoaDon.Rows[index].Cells[3].Value = item.DeliveryDate;
				//chổ này là sum toàn bộ trong chi tiết hóa đơn để load lên lúc ban đầu ctrinh theo từng mã
				List<Order> getOrder = Order.GetOrder(item.InvoiceNo);
				dgvHoaDon.Rows[index].Cells[4].Value = getOrder.Sum(p => p.Price).ToString();
			}
		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
			DateTime tuNgay = dateTimePicker1.Value.Date;
			DateTime denNgay = dateTimePicker2.Value.Date;
			// đây là list hứng nếu có ngày thuộc ngày cần select
			List<Invoice> kq = new List<Invoice>();
			//đây là list lấy tất cả các hóa đơn có trong db để đi so sánh
			List<Invoice> kqTheoNgay = Invoice.GetAll();
			foreach (var item in kqTheoNgay)
			{
				//tự cho ví dụ ra giấy để hiểu đi he
				if(tuNgay <= item.DeliveryDate.Date && denNgay >= item.DeliveryDate.Date)
				{
					kq.Add(item);
				}
			}
			BindGrid(kq);
			//đếm trong cái dgv coi có bao nhiêu dòng để cộng lại, cộng cột thứ 4
			int demDong = dgvHoaDon.Rows.Count;
			long thanhTien = 0;
			for (int i = 0; i < demDong; i++)
			{
				thanhTien += long.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
			}
			lblTongTien.Text = thanhTien.ToString();
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{
			SetGridViewStyle(dgvHoaDon);
			BindGrid(Invoice.GetAll());
			lblTongTien.Text = Order.GetAll().Sum(p => p.Price).ToString();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if(chkXemTatCa.Checked == true)
			{
				string thangHienTai = DateTime.Now.Month.ToString();
				List<Invoice> kq = new List<Invoice>();
				List<Invoice> kqTheoNgay = Invoice.GetAll();
				foreach (var item in kqTheoNgay)
				{
					if (item.DeliveryDate.Month.ToString() == thangHienTai)
					{
						kq.Add(item);
					}
				}
				BindGrid(kq);
			}
			else
			{
				BindGrid(Invoice.GetAll());
			}
		}
	}
}
