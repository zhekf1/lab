using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class DemoPoint //базовий клас
    {
        protected int x;
        protected int y;
        public virtual void Show() //віртуальний метод
        {
            Console.WriteLine("точка на площині: ({0}, {1})", x, y);
        }
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }
    class DemoShape : DemoPoint // Похідний клас
    {
        protected int z;
        public override void Show() //перевантаження віртуального методу
        {
            Console.WriteLine("точка в просторі: ({0}, {1}, {2})", x, y, z);
        }
        public DemoShape(int x, int y, int z) : base(x, y) //конструктор похідного класу
        {
            this.z = z;
        }
    }
    class DemoLine : DemoPoint //похідний клас
    {
        protected int x2;
        protected int y2;
        public override void Show() //перевантаження віртуального методу
        {
            Console.WriteLine("відрізок на площині: ({0}, {1})-{2},{3})", x, y, x2, y2);
        }
        public DemoLine(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2; this.y2 = y2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoPoint point1 = new DemoPoint(0, 1);
            point1.Show();
            DemoShape pointShape = new DemoShape(2, 3, 4);
            pointShape.Show();
            DemoLine line = new DemoLine(0, 0, 10, 10);
            line.Show();
            Console.WriteLine();
            //використання посилання базового класу на об'єкти похідних класів
            DemoPoint point2 = pointShape;
            point2.Show();
            point2 = line;
            point2.Show();

            Console.ReadKey();

        }
    }
}
