using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_Lab04
{
    class SachGiaoKhoa: Sach
    {
        private String tinhTrang;

        public SachGiaoKhoa() { }

        public SachGiaoKhoa(string tinhTrang)
        {
            this.TinhTrang = tinhTrang;
        }
        public string TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public override void NhapSach()
        {
            base.NhapSach();
            Console.WriteLine("Tinh trang sach: ");
            TinhTrang = Console.ReadLine();
        }

        public override void XuatSach()
        {
            base.XuatSach();
            Console.WriteLine("Tinh trang sach: {0}", TinhTrang);
        }

        //hàm này gặp con bug bự về ép kiểu dữ liệu
        public override float tinhThanhTien()
        {
            float ptram = (float)50 / 100;
            float thanhTien = 0;
            if(TinhTrang.Equals("moi"))
            {
                thanhTien = (float)(SoLuong * DonGia);
            }
            if (TinhTrang.Equals("cu"))
            {
                
                thanhTien = SoLuong * DonGia * ptram;
                //Console.WriteLine("----"+thanhTien+"-------"); test bug
            }                 
            return thanhTien;
        }
    }         
}
