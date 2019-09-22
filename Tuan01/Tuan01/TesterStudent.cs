using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01
{
    class Tester
    {
        //list main dung chung
        static List<Student> dssv = new List<Student>();
        static void NhapTongSoSV()
        {
            Console.WriteLine("Moi nhap tong so sinh vien can nhap");
            int tongSo = int.Parse(Console.ReadLine());

            for (int i = 0; i < tongSo; i++)
            {
                Student tmp = new Student();
                tmp.NhapSinhVien();
                dssv.Add(tmp);
            }
        }

        static void XuatTongSoSV()
        {
            foreach (var item in dssv)
            {
                item.XuatSinhVien();
            }
        }

        static void XuatSVCntt()
        {
            Console.WriteLine("--------Xuat DSSV khoa CNTT--------");
            int flag = 0;
            foreach (var item in dssv)
            {
                if (item.Khoa == "cntt")
                {
                    item.XuatSinhVien();
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("Khong tim thay sinh vien nao!");
        }

        //chuyen qua sai LinQ
        static void DSSVCoDiemTBCaoNhat()
        {
            Console.WriteLine("**************DSSV Co Diem Trung Binh Cao Nhat***********");
            float diemMax = dssv.Max(p => p.DiemTB);
            List<Student> listStudentCntt = dssv.Where(p => p.Khoa == "cntt").ToList();
            List<Student> listTK = listStudentCntt.Where(p => p.DiemTB == diemMax).ToList();
            foreach (var item in listTK)
            {
                item.XuatSinhVien();
            }
        }

        static void SapXepTangDan()
        {
            Console.WriteLine("**************DSSV Sau Khi Sap Xep Tang Dan***********");
            List<Student> listDiemTangDan = dssv.OrderBy(p => p.DiemTB).ToList();
            foreach (var item in listDiemTangDan)
            {
                item.XuatSinhVien();
            }
        }
        static void Main(string[] args)
        {
            NhapTongSoSV();
            XuatTongSoSV();
            XuatSVCntt();
            DSSVCoDiemTBCaoNhat();
            SapXepTangDan();
            Console.ReadKey();

        }
    }
}
