using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Rocket : Ship
    {
        private string type;
        private int number;

        public Rocket(): base()
        {
            type = String.Empty;
            number = 0;
        }

        public Rocket(string name, string purpose, double vodoton, double engine, string fuel, string type, int number) : base(name, purpose, vodoton, engine, fuel)
        {
            this.type = type;
            if (number >= 0)
            {
                this.number = number;
            }
            else this.number = 0;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Number
        {
            get { return number; }
            set { if (value >= 0) number = value; }
        }

        public new void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Purpose: " + purpose);
            Console.WriteLine("Vodoton: " + vodoton);
            Console.WriteLine("Engine: " + engine);
            Console.WriteLine("Fuel: " + fuel);
            Console.WriteLine("Type of rockets: " + type);
            Console.WriteLine("Number of rockets: " + number);
        }
    }
}
