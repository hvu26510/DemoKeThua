using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle hinhTron = new Circle();
            hinhTron.setBanKinh(10);

            Console.WriteLine("dien tich hinh tron: " + hinhTron.TinhDienTich());

            Console.ReadLine();
        }
    }
}
