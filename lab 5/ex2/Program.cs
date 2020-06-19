using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    abstract class Demo //абстрактний клас
    {
        abstract public void Show(); //абстрактний метод
        abstract public double Dlina(); //абстрактний метод
    }

    class DemoPoint : Demo //похідний клас від абстрактного
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public override void Show() //перевизначення абстрактного методу
        {
            Console.WriteLine("точка на площині: ({0}, {1})", x, y);
        }
        public override double Dlina() //перевизначення абстрактного методу
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
    class DemoShape : DemoPoint //похідний клас
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public override void Show() //перевизначення абстрактного методу

        {
            Console.WriteLine("точка в просторі: ({0}, {1}, {2})", x, y, z);
        }

        public override double Dlina() //перевизначення абстрактного методу
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class DemoLine : DemoPoint //похідний клас
    {
        protected int x2;
        protected int y2;
        public DemoLine(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2; this.y2 = y2;
        }

        public override void Show() //перевизначення абстрактного методу
        {
            Console.WriteLine("відрізок на площині: ({0}, {1})-({2},{3})", x, y, x2, y2);
        }


        public override double Dlina() // Перевизначення абстрактного методу
        {
            return Math.Sqrt((x - x2) * (x - x2) + (y - y2) * (y - y2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo[] Ob = new Demo[5]; //масив посилань
                                     //заповнення масиву посиланнями на об'єкти похідних класів
            Ob[0] = new DemoPoint(1, 1);
            Ob[1] = new DemoShape(1, 1, 1);
            Ob[2] = new DemoLine(0, 3, 4, 0);
            Ob[3] = new DemoLine(2, 1, 2, 10);
            Ob[4] = new DemoPoint(0, 100);
            foreach (Demo a in Ob) //перегляд масиву
            {
                a.Show();
                Console.WriteLine("Довжина: {0:f2}\n", a.Dlina());
            }

            Console.ReadKey();
        }
    }
}
