using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_02
{
    class PersonMain
    {
        static List<Person> dsperson = new List<Person>();

        //xuất toàn bộ danh sách bao gồm student và teacher
        static void XuatToanBoDanhSach()
        {
            Console.WriteLine("--------------Danh sach toan bo person la:-----------------");
            foreach (var item in dsperson)
            {
                item.XuatPerson();
            }
        }

        ////chuyen qua sai linq, tìm dssv có điểm trung bình cao nhất thuộc khoa cntt
        static void DssvCoDiemTbCaoNhat()
        {
            Console.WriteLine("*******DSSV co diem trung binh cao nhat thuoc khoa cntt********");
            var listCnttStudent = dsperson.Where(p => (p is Student) && (p as Student).Khoa == "cntt").ToList();
            var maxDiem = listCnttStudent.Max(p => (p as Student).DiemTB);
            var listMaxCnttStudent = listCnttStudent.Where(p => (p as Student).DiemTB == maxDiem);
            
            foreach (var item in listMaxCnttStudent)
            {
                item.XuatPerson();
            }
        }

        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("-------------------------------------MENU----------------------------------");
                Console.WriteLine("\t\t1. Them mot sinh vien vao danh sach.");
                Console.WriteLine("\t\t2. Them mot giang vien vao danh sach.");
                Console.WriteLine("\t\t3. Xuat toan bo danh sach.");
                Console.WriteLine("\t\t4. Xuat danh sach sinh vien co DTB cao nhat va thuoc khoa cntt.");
                Console.WriteLine("\t\t0. Nhan phim 0 de thoat khoi chuong trinh.");
                Console.WriteLine("-------------------------------********************-----------------\n");
                Console.WriteLine("Moi nhap su lua chon cua ban: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Person sv = new Student();
                        sv.NhapPerson();
                        dsperson.Add(sv);
                        break;
                    case 2:
                        Person gv = new Teacher();
                        gv.NhapPerson();
                        dsperson.Add(gv);
                        break;
                    case 3:
                        XuatToanBoDanhSach();
                        Console.ReadKey();
                        break;
                    case 4:
                        DssvCoDiemTbCaoNhat();
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (chon != 0);
        }
    }
}
