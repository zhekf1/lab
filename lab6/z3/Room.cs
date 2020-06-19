using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    interface Room: IComparable<Room>
    {
        double Square { get; set; }
        int NumberOfWindows { get; set; }
        void Print();
    }
}
