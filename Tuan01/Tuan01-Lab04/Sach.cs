//Nguyễn Ngọc Thủy Tiên 17DTHC6 Khoa CNTT - HUTECH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_Lab04
{
    public abstract class Sach
    {
        protected int maSach;
        protected String ngayThangNam;
        protected int donGia;
        protected int soLuong;
        protected String nxb;

        public int MaSach { get => maSach; set => maSach = value; }
        public string NgayThangNam { get => ngayThangNam; set => ngayThangNam = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Nxb { get => nxb; set => nxb = value; }

        public virtual void NhapSach()
        {
            Console.WriteLine("Mã sach: ");
            MaSach = int.Parse(Console.ReadLine());
            Console.WriteLine("Ngay Thang Nam: ");
            NgayThangNam = Console.ReadLine();
            Console.WriteLine("Don gia: ");
            DonGia = int.Parse(Console.ReadLine());
            Console.WriteLine("So luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nha xuat ban: ");
            Nxb = Console.ReadLine();
        }

        public virtual void XuatSach()
        {
            Console.WriteLine("Ma sach: {0}",MaSach);
            Console.WriteLine("Ngay Thang Nam: {0}",NgayThangNam);
            Console.WriteLine("Don gia: {0}",DonGia);
            Console.WriteLine("So luong: {0}",SoLuong);
            Console.WriteLine("Nha xuat ban: {0}",Nxb);
        }

        public abstract float tinhThanhTien();
    }
}
