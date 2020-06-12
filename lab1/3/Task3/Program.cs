﻿using System;
using System.Numerics;

namespace Task3
{
    static class Program
    {
        private static void Exit(String message)
        {
            Console.WriteLine(message);
            Environment.Exit(0);
        }
        private static double pow(double a, double b)
        {
            if (a > 0) return Math.Pow(a, b);
            return -Math.Pow(-a, b);
        }
        public static void Main(string[] args)
        {
            double x, x2, d, res, k, a;
            Console.WriteLine("Input k(double):");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a(double):");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input x Min (double)");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input x Max (double)");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input delta(double): ");
            d = double.Parse(Console.ReadLine());
            if (d < 0)
            {
                Exit("Delta should be > 0");
            }

            for (double i = x; i <= x2; i+= d)
            {
                if (a * i <= 0 || a * i == 1)
                {
                    Console.WriteLine($"for x = {i}, a * x shouldn't be <= 0 or == 1");
                    continue;
                }
                res = pow(Math.Cos(a * i), 1.0 / 3) + k * Math.Cos (a * i) / Math.Log (a * i);
                Console.WriteLine($"for x = {i} , y = {res}");
            }

        }
    }

    class Name
    {
        private static int vare;
        static {
            
        }
    }
}