using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Calculator
    {
        public double CalculateSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double CalculateLength(double r)
        {
            return 2 * Math.PI * r;
        }

        public double CalculateVolume(double r)
        {
            return (4 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
