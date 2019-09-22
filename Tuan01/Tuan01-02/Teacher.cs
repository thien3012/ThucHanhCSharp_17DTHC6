using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_02
{
    class Teacher : Person
    {
        private int maGV;
        private String diaChi;

        public int MaGV
        {
            get
            {
                return maGV;
            }

            set
            {
                maGV = value;
            }
        }

        public String DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public Teacher() { }

        public Teacher(int ma, String diaChi)
        {
            this.MaGV = ma;
            this.DiaChi = diaChi;
        }

        public override void NhapPerson()
        {
         
            Console.WriteLine("Ma giao vien: ");
            MaGV = int.Parse(Console.ReadLine());
            base.NhapPerson();
            Console.WriteLine("Dia chi: ");
            DiaChi = Console.ReadLine();
        }

        public override void XuatPerson()
        {
            Console.WriteLine("Ma giao vien: " + this.MaGV);
            base.XuatPerson();
            // string.Format("Ten sinh vien {0} {1}", this.TenSV, "nnn");
            Console.WriteLine(string.Format("Dia chi {0}", this.DiaChi));
        }
    }


}
