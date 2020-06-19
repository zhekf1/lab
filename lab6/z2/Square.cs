using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Square: IMeasurable, ICircumcircleIncircle, IComparable<Square>
    {
        private double a;

        public Square()
        {
            a = 0;
        }

        public Square(double a)
        {
            this.a = a;
        }

        public double A
        {
            get { return a; }
            set
            {
                if (a > 0) a = value;
                else Console.WriteLine("a < 0");
            }
        }

        public double Perimetr()
        {
            return a * 4;
        }
        public double Area()
        {
            return a * a;
        }

        public double R
        {
            get { return a / Math.Sqrt(2); }
        }

        public double r
        {
            get { return a / 2; }
        }

        public int CompareTo(Square s1)
        {
            //return this.Perimetr().CompareTo(s1.Perimetr());
            if(this.Perimetr() == s1.Perimetr())
            {
                return 0;
            }
            else if(this.Perimetr() > s1.Perimetr())
            {
                return 1;
            }
            else
            {
                return - 1;
            }
        }

        public void Print()
        {
            Console.WriteLine("Square: a = {0}, P = {1}, S = {2}, R = {3}, r = {4};", a, Perimetr(), Area(), R, r);
        }
    }
}
