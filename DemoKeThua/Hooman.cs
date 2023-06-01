using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKeThua
{
    internal class Hooman
    {
        protected string Name;
        protected string Address;
        protected string Email;
        protected string PhoneNumber;

        public Hooman(string name, string address, string email, string phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public virtual void Show()
        {
            Console.WriteLine("Ten: "+ this.Name);
            Console.WriteLine("Dia chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
        }

    }

    class NhanVien : Hooman
    {
        protected string bangCap;

        public NhanVien(string name, string address, string email, string phoneNumber, string bangCap) : 
            base(name, address, email, phoneNumber)
        {
            this.bangCap = bangCap;
        }

        public override void Show()
        {
            Console.WriteLine("Ten: " + this.Name);
            Console.WriteLine("Dia chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
            Console.WriteLine("Bang cap: " + this.bangCap);

        }

    }


    class KeToan : NhanVien
    {
        protected int Luong;
        public KeToan(string name, string address, string email, string phoneNumber, string bangCap, int luong) : base(name, address, email, phoneNumber, bangCap)
        {
            this.Luong = luong;
        }

        public override void Show()
        {
            Console.WriteLine("Ten: " + this.Name);
            Console.WriteLine("Dia chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
            Console.WriteLine("Bang cap: " + this.bangCap);
            Console.WriteLine("Luong: " + this.Luong);

        }
    }
}
