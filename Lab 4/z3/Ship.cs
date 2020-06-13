using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Ship
    {
        protected string name;
        protected string purpose;
        protected double vodoton;
        protected double engine;
        protected string fuel;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }

        public double Vodoton
        {
            get { return vodoton; }
            set { if (value >= 0) vodoton = value; }
        }

        public double Engine
        {
            get { return engine; }
            set { if (value >= 0) engine = value; }
        }

        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public Ship()
        {
            name = String.Empty;
            purpose = String.Empty;
            vodoton = 0;
            engine = 0;
            fuel = String.Empty;

        }

        public Ship(string name, string purpose, double vodoton, double engine, string fuel)
        {
            this.name = name;
            this.purpose = purpose;
            this.vodoton = vodoton;
            this.engine = engine;
            this.fuel = fuel;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Purpose: " + purpose);
            Console.WriteLine("Vodoton: " + vodoton);
            Console.WriteLine("Engine: " + engine);
            Console.WriteLine("Fuel: " + fuel);
        }
    }
}
