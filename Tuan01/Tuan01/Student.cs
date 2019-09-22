using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01
{
    class Student
    {
        private int maSV;
        private String tenSV;
        private float diemTB;
        private String khoa;

        public Student() { }

        public Student(int maSV, string tenSV, float diemTB, string khoa)
        {
            this.MaSV = maSV;
            this.TenSV = tenSV;
            this.DiemTB = diemTB;
            this.Khoa = khoa;
        }

        public int MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return tenSV;
            }

            set
            {
                tenSV = value;
            }
        }

        public float DiemTB
        {
            get
            {
                return diemTB;
            }

            set
            {
                diemTB = value;
            }
        }

        public string Khoa
        {
            get
            {
                return khoa;
            }

            set
            {
                khoa = value;
            }
        }


        public void NhapSinhVien()
        {
            Console.WriteLine("Ma sinh vien: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten sinh vien: ");
            TenSV = Console.ReadLine();
            Console.WriteLine("Diem trung binh: ");
            DiemTB = float.Parse(Console.ReadLine());
            Console.WriteLine("Khoa: ");
            Khoa = Console.ReadLine();
        }

        public void XuatSinhVien()
        {
            Console.WriteLine("Ma sinh vien: " + this.MaSV);
           // string.Format("Ten sinh vien {0} {1}", this.TenSV, "nnn");
            Console.WriteLine(string.Format("Ten sinh vien {0}", this.TenSV));
            Console.WriteLine("Diem trung binh: {0}", this.DiemTB);
            Console.WriteLine("Khoa: "+ this.Khoa);
        }
    }

            
}
