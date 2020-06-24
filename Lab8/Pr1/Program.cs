using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class Program
    {
        delegate void GetMessage(); // 1.оголошуємо делегат
        static void Main(string[] args)
        {
            GetMessage del; // 2.Створюємо змінну делегата
            if (DateTime.Now.Hour < 12)
            {
                del = GoodMorning; // 3. Надаємо цій змінній адресу методу
            }
            else
            {
                del = GoodEvening;
            }
            del.Invoke(); // 4. викликаємо метод // del ();
            Console.ReadLine();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

 private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
