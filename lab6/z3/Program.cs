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
            Room[] rooms = new Room[4];
            rooms[0] = new ClassRoom(28.9, 3, "Math");
            rooms[1] = new ClassRoom(34.4, 2, "Art");
            rooms[2] = new MyRoom(10.2, 2, 1);
            rooms[3] = new MyRoom(13.6, 1, 2);

            Console.WriteLine("Rooms:");

            foreach(Room x in rooms)
            {
                x.Print();
            }

            Console.WriteLine("\nIComparable (sort by square)\n");
            Array.Sort(rooms);

            foreach(Room x in rooms)
            {
                x.Print();
                //Console.WriteLine("\n");
            }

            Console.WriteLine("\nIComparer (sort by number of windows)\n");
            Array.Sort(rooms, new RoomComparer());

            foreach (Room x in rooms)
            {
                x.Print();
                //Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
