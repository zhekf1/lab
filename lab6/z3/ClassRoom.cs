using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class ClassRoom : Room
    {
        private double square;
        private int numberOfWindows;
        private string subject;
        
        public ClassRoom()
        {
            square = 0;
            numberOfWindows = 0;
            subject = String.Empty;
        }

        public ClassRoom(double square, int numberOfWindows, string subject)
        {
            this.square = square;
            this.numberOfWindows = numberOfWindows;
            this.subject = subject;
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
            Console.WriteLine("Classroom: S = {0}, number of windows = {1}, subject = {2}", square, numberOfWindows, subject);
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
