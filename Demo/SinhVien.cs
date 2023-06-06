using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SinhVien
    {
        public int MaSV;
        public string Name;
        public string Email;
        public double Diem;

        public SinhVien(int MaSV, string name, string email, double diem)
        {
            this.MaSV = MaSV;
            Name = name;
            Email = email;
            Diem = diem;
        }

        public SinhVien()
        {
        }

        public string HocLuc()
        {
            //string outPut = "";
            if(Diem < 5) 
            {
                return "Y";
            }else if(Diem < 6.5)
            {
                return "TB";
            }
            else if (Diem < 7.5)
            {
                return "K";
            }else if (Diem < 9)
            {
                return "G";
            }
            else
            {
                return "XS";
            }

            //return outPut;
        }

        public void Show()
        {
            Console.WriteLine("MaSV :" + this.MaSV);
            Console.WriteLine("Ten :" + this.Name);
            Console.WriteLine("Email :" + this.Email);
            Console.WriteLine("Diem :" + this.Diem);
            Console.WriteLine("Hoc Luc :" + this.HocLuc());
        }
    }

    interface IDraw
    {
        void Show();
    }
}
