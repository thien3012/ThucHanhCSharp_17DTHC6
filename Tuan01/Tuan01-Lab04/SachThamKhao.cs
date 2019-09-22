using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_Lab04
{
    class SachThamKhao : Sach
    {
        private int thue;

        public int Thue
        {
            get
            {
                return thue;
            }

            set
            {
                thue = value;
            }
        }

        public SachThamKhao() { }

        public SachThamKhao(int thue)
        {
            this.Thue = thue;
        }

        public override void NhapSach()
        {
            base.NhapSach();
            Console.WriteLine("Thue: ");
            Thue = int.Parse(Console.ReadLine());
        }

        public override void XuatSach()
        {
            base.XuatSach();
            Console.WriteLine("Thue: " + this.Thue);
        }

        public override float tinhThanhTien()
        {
            float thanhTien = (float)(SoLuong * DonGia + Thue);
            return thanhTien;
        }
    }
}
