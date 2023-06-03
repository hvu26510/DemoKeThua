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
            AddDemoData(ref listSV);

            foreach (SinhVien item in FindByKhoangDiem(listSV, 5,7))
            {
                item.Show();
            }

        

            Console.ReadLine();
        }

        static void AddDemoData(ref ArrayList list)
        {
            SinhVien sv1 = new SinhVien(1, "Nguyen Van A", "anv@email.com", 10);
            SinhVien sv2 = new SinhVien(2, "Nguyen Van hai", "hainv@email.com", 5);
            SinhVien sv3 = new SinhVien(3, "Nguyen Van ba", "banv@email.com", 7);
            SinhVien sv4 = new SinhVien(4, "Nguyen Van bon", "bonnv@email.com", 8);
            SinhVien sv5 = new SinhVien(5, "Nguyen Van nam", "namnv@email.com", 1);
            SinhVien sv6 = new SinhVien(6, "Nguyen Van sau", "saunv@email.com", 0);

            list.Add(sv1);
            list.Add(sv2);
            list.Add(sv3);
            list.Add(sv4);
            list.Add(sv5);
            list.Add(sv6);
        }

        static ArrayList FindByKhoangDiem(ArrayList list, double min, double max)
        {
            ArrayList listOutPut = new ArrayList();
            foreach (SinhVien sv in list)
            {
                if (sv.Diem>= min && sv.Diem<= max)
                {
                    listOutPut.Add(sv);
                }
            }
            return listOutPut;

        }




    }
}
