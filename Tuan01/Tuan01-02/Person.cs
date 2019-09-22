using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_02
{
    class Person
    {
        protected string ten;
      
        protected string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public virtual void NhapPerson()
        {
            
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine(); 
        }

        public virtual void XuatPerson()
        {
            Console.WriteLine("Nhap ten: "+Ten);
        }
    }
}
