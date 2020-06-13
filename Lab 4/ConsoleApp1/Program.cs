using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            int result;
            result = x.C();
            Console.WriteLine("Result of function Abs(a + b):");
            Console.WriteLine("a = " + x.A);
            Console.WriteLine("b = " + x.B);
            Console.WriteLine("x = " + result);

            Console.ReadKey();
        }
    }
}
