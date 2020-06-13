using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship sh1 = new Ship("CV-1", "passanger", 10000, 5000, "petrol");
            Console.WriteLine("Class Ship - object sh1");
            sh1.print();

            Console.WriteLine("\nUsing get/set");
            Console.WriteLine("GetName: " + sh1.Name);
            Console.WriteLine("Purpose: " + sh1.Purpose + "\nSetPurpose: ");
            sh1.Purpose = "trade";
            Console.Write(sh1.Purpose);

            Air airsh1 = new Air("AV-3", "cargo", 30500, 7500, "gas", "passanger", 2);
            Console.WriteLine("\nClass Air - object airsh1");
            airsh1.print();

            Rocket rsh1 = new Rocket("R-334", "cargo", 20900, 4000, "electric", "12-n", 10);
            Console.WriteLine("\nClass Rocket - object rsh1");
            rsh1.print();

            Console.ReadKey();
        }
    }
}
