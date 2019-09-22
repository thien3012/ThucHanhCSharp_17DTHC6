using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_Lab04
{
    //bài này chưa cải tiến được chổ dùng try-catch bắt lỗi chia cho 0 và lỗi người dùng nhập vào, để vô hỏi thầy! ^-^
    class SachMain
    {
        static List<Sach> dssach = new List<Sach>();

        //xuất toàn bộ danh sách bao gồm sách giáo khoa và sách tham khảo
        static void XuatToanBoDanhSach()
        {
            Console.WriteLine("--------------Danh sach toan bo Sach la:-----------------");
            foreach (var item in dssach)
            {
                item.XuatSach();
            }
        }

        ////chuyển qua sài thư viện LINQ
        static void TongThanhTienCuaTungLoaiSach()
        {
            var listSGK = dssach.Where(p => (p is SachGiaoKhoa)).ToList();   
            float tongSGK = 0;
            foreach(var item1 in listSGK)
            {
                //chổ này có thể gọp thành 1 dòng code tongSGk = tongSGK + tinhThanhTien();
                float kq1 = item1.tinhThanhTien();
                tongSGK = tongSGK + kq1;
            }
            var listSTK = dssach.Where(p => (p is SachThamKhao)).ToList();
            float tongSTK = 0;
            foreach (var item2 in listSTK)
            {
                float kq2 = item2.tinhThanhTien();
                tongSTK = tongSTK + kq2;
            }
            Console.WriteLine("Tong thanh tien cua sach giao khoa: "+tongSGK);
            Console.WriteLine("Tong thanh tien cua sach tham khao: "+tongSTK);
        }

        static float TrungBinhCongDonGiaSachThamKhao()
        {
            float kq = 0;
            var tbc = dssach.Sum(p => (p as SachThamKhao).DonGia);
            var dem = dssach.Count(p => (p as SachThamKhao).DonGia > 0);
            kq = (float)tbc / dem;
            return kq;
        }
        static void XuatSGKNhaXuatBanX(String nxb)
        {
            var listNXB = dssach.Where(p => (p is SachGiaoKhoa) && (p as SachGiaoKhoa).Nxb.Equals(nxb)).ToList();      
            foreach (var item in listNXB)
            {
                item.XuatSach();
            }
        }
        static float XuatTongThanhTienTheoMaSach(int maSach)
        {
            var dsMaSach = dssach.Where(p => p.MaSach == maSach).ToList();
            float tong = 0;
            foreach(var item in dsMaSach)
            {
                tong = tong + item.tinhThanhTien();
            }
            return tong;
        }
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("---------------------------------MENU----------------------------------");
                Console.WriteLine("\t\t1. Them sach giao khoa vao danh sach.");
                Console.WriteLine("\t\t2. Them sach tham khao vao danh sach.");
                Console.WriteLine("\t\t3. Xuat toan bo danh sach.");
                Console.WriteLine("\t\t4. Tinh tong tien cua tung loai sach.");
                Console.WriteLine("\t\t5. Tinh trung binh cong don gia cua sach tham khao.");
                Console.WriteLine("\t\t6. Xuat sach giao khoa theo ten nha san xuat.");
                Console.WriteLine("\t\t7. Nhap ma sach - xuat tong thanh tien.");
                Console.WriteLine("\t\t0. Nhan phim 0 de thoat khoi chuong trinh.");
                Console.WriteLine("----------------------------********************-----------------\n");
                Console.WriteLine("Moi nhap su lua chon cua ban: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Sach sgk = new SachGiaoKhoa();
                        sgk.NhapSach();
                        dssach.Add(sgk);
                        break;
                    case 2:
                        Sach stk = new SachThamKhao();
                        stk.NhapSach();
                        dssach.Add(stk);
                        break;
                    case 3:
                        XuatToanBoDanhSach();
                        Console.ReadKey();
                        break;
                    case 4:
                        TongThanhTienCuaTungLoaiSach();
                        Console.ReadKey();
                        break;
                    case 5:
                        float tbc = TrungBinhCongDonGiaSachThamKhao();
                        Console.WriteLine("Trung binh cong don gia cua sach tham khao la: " + tbc);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Moi nhap vao ten nha xuat ban can tim: ");
                        String nxb = Console.ReadLine();
                        XuatSGKNhaXuatBanX(nxb);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Moi nhap vao ma sach ban can tim: ");
                        int maSach = int.Parse(Console.ReadLine());
                        float tongThanhTien = XuatTongThanhTienTheoMaSach(maSach);
                        Console.WriteLine("Tong thanh tien cua theo ma sach la: " + tongThanhTien);
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
