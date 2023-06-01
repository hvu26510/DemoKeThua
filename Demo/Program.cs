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
            ArrayList listSV = new ArrayList();

            SinhVien sv1 = new SinhVien("A", "a@gmail.com", 10);
            SinhVien sv2 = new SinhVien("B", "b@gmail.com", 3);

            // Thêm sinh viên vào ArrayList
            // 
            listSV.Add(sv1);
            listSV.Add(sv2);
            //xóa sinh viên ở vị trí 0 trong ArrayList

            listSV.RemoveAt(0);

            foreach (SinhVien i in listSV)
            {
                Console.WriteLine("Ten: "+ i.Name);
                Console.WriteLine("Email: " + i.Email);
                Console.WriteLine("Diem: " + i.Diem);
                Console.WriteLine("Hoc Luc: " + i.HocLuc());
            }

            Console.ReadLine();



        }
    }
}
