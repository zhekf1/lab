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
            A classA = new A(10, 10);
            B classB1 = new B(10, 10, 20);
            B classB2 = new B(100);

            Console.WriteLine("Object classA");
            classA.output();

            Console.WriteLine("\nObject classB1");
            classB1.output();
            Console.WriteLine("C2: ");
            int result1;
            result1 = classB1.C2();
            Console.WriteLine("result is " + result1);


            Console.WriteLine("\nObject classB2");
            classB2.output();
            Console.WriteLine("C2: ");
            int result2;
            result2 = classB2.C2();
            Console.Write("result is " + result2);

            Console.ReadKey();
        }
    }
}
