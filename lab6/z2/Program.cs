using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] figures = new Square[4];
            figures[0] = new Square(4);
            figures[1] = new Square(3);
            figures[2] = new Square(2);
            figures[3] = new Square(1);

            Array.Sort(figures);

            foreach(Square i in figures)
            {
                i.Print();
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
