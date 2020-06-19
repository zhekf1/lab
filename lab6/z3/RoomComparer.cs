using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class RoomComparer: IComparer<Room>
    {
        public int Compare(Room r1, Room r2)
        {
            if (r1.NumberOfWindows > r2.NumberOfWindows) return 1;
            else if (r1.NumberOfWindows < r2.NumberOfWindows) return -1;
            else return 0;
        }
    }
}
