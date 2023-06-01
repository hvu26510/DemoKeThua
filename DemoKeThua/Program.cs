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
            KeToan kt = new KeToan("Nguyen van A", "Ha Noi", "anv@gmail.com", "0123456789", "Tai chinh", 15000000);

            kt.Show();

            Console.ReadLine();
        }
    }
}
