using System;

namespace ConsoleApp
{
    class Program
    {
        private static void exit(String message)
        {
            Console.WriteLine(message);
            Environment.Exit(0);
        }
        
        public static void Main(string[] args)
        {
            double x, x2, d, res, c;
            Console.WriteLine("Input parameters for calculating");
            Console.WriteLine("Input parameter с");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Input x min (double)");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input x max(double)");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input delta (double)");
            d = double.Parse(Console.ReadLine());
            if (delta < 0) {
                exit ("y should be > 0");
            }

            for (double i = x; i <= x2; i+= d)
            {
                res = Math.Pow(c * c * i * i + 2, (double) 1 / 3) + Math.Log(i * i + 1) / (2 * Math.PI);
                Console.WriteLine("для x = " + i + ", y = " + res);
            }

        }
    }
}