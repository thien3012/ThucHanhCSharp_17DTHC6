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
    public partial class frmTinhToanHaiSo : Form
    {
        public frmTinhToanHaiSo()
        {
            InitializeComponent();
        }

        private void Click_Add(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text); ; 
                //float.TryParse(txtNumber1.Text, out number1);

                //if (number1 == 0 && txtNumber1.Text!= "0")
                    //throw new Exception("So thu 1 ban nhap khong hop le");
                //float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                //if(number2 == 0 && txtNumber2.Text != "0")
                    //throw new Exception("So thu 2 ban nhap khong hop le");

                float result = 0;
                Button btnPhepTinh = (Button)sender;
                switch (btnPhepTinh.Name)
                {
                    case "btnCong":
                        result = number1 + number2;
                        break;
                    case "btnTru":
                        result = number1 - number2;
                        break;
                    case "btnNhan":
                        result = number1 * number2;
                        break;
                    case "btnChia":
                        result = number1 / number2;
                        break;
                }
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("so khong hop le!");
            }
        }
    }
}
