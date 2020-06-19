using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            // створення масиву інтерфейсних посилань
            IDemo[] a = new IDemo[4];
            // заповнення масиву
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);
            // перегляд масиву
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Dlina={0:f2}", x.Dlina());
                Console.WriteLine("x=" + x.X);
                Console.WriteLine("y=" + x.Y);
                x[1] += x[0];
                Console.Write("новые координати - ");
                x.Show();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
