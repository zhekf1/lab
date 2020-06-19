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
            Abiturient person1 = new Abiturient("Ivanov", new DateTime(2000, 05, 20), "ElIT");
            person1.Show();
            Console.WriteLine("\n");

            Student person2 = new Student("Petrov", new DateTime(1999, 03, 20), "IFSK", 3);
            person2.Show();
            Console.WriteLine("\n");

            Teacher person3 = new Teacher("Leonova", new DateTime(1985, 01, 24), "FEM", "st. vukladach", 10);
            person3.Show();

            Console.ReadKey();
        }
    }
}
