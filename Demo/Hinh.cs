using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    abstract internal class Hinh
    {
        protected double cv;
        public abstract double TinhDienTich();
    }

    class Circle : Hinh
    {
        private double bk;

        public void setBanKinh(double banKinh)
        {
            this.bk = banKinh;
        }
        public override double TinhDienTich()
        {
            return bk * bk * Math.PI;
        }
    }
}
