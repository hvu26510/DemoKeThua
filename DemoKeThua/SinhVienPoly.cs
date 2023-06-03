using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKeThua
{
    internal abstract class SinhVienPoly
    {
        protected string hoTen;
        protected string nganh;

        protected SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        public abstract double getDiem();

        public string getHL()
        {
            if (this.getDiem() < 5)
            {
                return "Yeu";
            }
            else if (this.getDiem() < 6.5)
            {
                return "Trung Binh";
            }
            else if (this.getDiem() < 7.5)
            {
                return "Trung Binh";
            }
            else if (this.getDiem() < 9)
            {
                return "Gioi";
            }
            else
            {
                return "Xuat Sac";
            }
        }

        public virtual void xuat()
        {
            Console.WriteLine("Ten:" + this.hoTen);
            Console.WriteLine("Nganh:" + this.nganh);
            Console.WriteLine("Diem TB:" + this.getDiem());
            Console.WriteLine("Hoc Luc:" + this.getHL());
        }
    }

    class SinhVienIT : SinhVienPoly
    {
        private double diemJava;
        private double diemCSharp;
        private double diemHTML;

        public SinhVienIT(string hoTen, string nganh, double java, double CSharp, double html)
            : base(hoTen, nganh)
        {
            this.diemJava = java;
            this.diemCSharp = CSharp;
            this.diemHTML = html;
        }

        public override double getDiem()
        {
            return (this.diemJava * 2 + this.diemCSharp + this.diemHTML) / 4;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("java:" + this.diemJava);
            Console.WriteLine("Csharp:" + this.diemCSharp);
            Console.WriteLine("Html:" + this.diemHTML);
        }
    }

    class SinhVienBiz : SinhVienPoly
    {
        private double diemMKT;
        private double diemSale;

        public SinhVienBiz(string hoTen, string nganh, double mkt, double sale)
            : base(hoTen, nganh)
        {
            this.diemMKT = mkt;
            this.diemSale = sale;
        }

        public override double getDiem()
        {
            return (this.diemMKT * 2 + this.diemSale) / 3;
        }
    }


}
