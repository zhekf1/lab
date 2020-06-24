using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class GreetingAction
    {
        private delegate void GetGreeting();

        private static Dictionary<int, GetGreeting> timeOfDayDictinary = new Dictionary<int, GetGreeting>() {{4, GoodNight}, {10, GoodMorning}, {17, GoodDay}, {20, GoodEvening}};

        public static void SayGreetings()
        {
            timeOfDayDictinary.First(item => DateTime.Now.Hour <= item.Key).Value();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Доброго ранку!");
        }
        private static void GoodDay()
        {
            Console.WriteLine("Добрий день!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Добрий вечір!");
        }
        private static void GoodNight()
        {
            Console.WriteLine("Доброї ночі!");
        }
    }
}
