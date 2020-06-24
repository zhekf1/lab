using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class AgeCompare: IComparer
    {
        public int Compare(Object a, Object b)
        {
            Persona p1 = (Persona)a;
            Persona p2 = (Persona)b;

            if (p1.Age > p2.Age)
                return 1;
            else if (p1.Age < p2.Age)
                return -1;
            else
                return 0;
        }
    }
}
