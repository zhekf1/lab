using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class MyRoom: Room
    {
        private double square;
        private int numberOfWindows;
        private int people;

        public MyRoom()
        {
            square = 0;
            numberOfWindows = 0;
            people = 0;
        }

        public MyRoom(double square, int numberOfWindows, int people)
        {
            this.square = square;
            this.numberOfWindows = numberOfWindows;
            this.people = people;
        }

        public double Square
        {
            get { return square; }
            set
            {
                if (value > 0) square = value;
                else
                {
                    Console.WriteLine("square < 0");
                }
            }
        }

        public int NumberOfWindows
        {
            get { return numberOfWindows; }
            set
            {
                if (value >= 0) numberOfWindows = value;
                else
                {
                    Console.WriteLine("numberOfWindows < 0");
                }
            }

        }

        public void Print()
        {
            Console.WriteLine("Myroom: S = {0}, number of windows = {1}, number of people = {2}", square, numberOfWindows, people);
        }

        public int CompareTo(Room x)
        {
            if (this.square == x.Square)
            {
                return 0;
            }
            else if (this.square > x.Square)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
