using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_02
{
    class Student : Person
    {
        private int maSV;
        private float diemTB;
        private String khoa;

        public Student() { }

        public Student(int ma, float diemTB, string khoa)
        {
            this.maSV = ma;
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


        public override void NhapPerson()
        {
            Console.WriteLine("Ma: ");
            MaSV = int.Parse(Console.ReadLine());
            base.NhapPerson();
            Console.WriteLine("Diem trung binh: ");
            DiemTB = float.Parse(Console.ReadLine());
            Console.WriteLine("Khoa: ");
            Khoa = Console.ReadLine();
        }

        public override void XuatPerson()
        {
            Console.WriteLine("Ma sinh vien: " + MaSV);
            base.XuatPerson();
            Console.WriteLine("Diem trung binh: {0}", this.DiemTB);
            Console.WriteLine("Khoa: "+ this.Khoa);
        }
    }

            
}
