using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SinhVienIT svIT = new SinhVienIT("Nguyen Van A", "IT", 8, 8 ,10);

            SinhVienBiz svBiz = new SinhVienBiz("Nguyen Van A", "IT", 5, 1);

            svIT.xuat();

            svBiz.xuat();

            Console.ReadLine();
        }
    }
}
