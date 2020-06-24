using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> op;
            op = Add;
            Operation(10, 6, op);
            op = Substract;
            Operation(10, 6, op);
            Console.ReadKey();
        }
        static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
                op(x1, x2);
        }
        static void Add(int x1, int x2)
        {
            Console.WriteLine("Сума чисел: " + (x1 + x2));
        }
        static void Substract(int x1, int x2)
        {
            Console.WriteLine("Різниця чисел: " + (x1 - x2));
        }
    }
}
