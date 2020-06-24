using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class Program
    {
        public static string MySelector(string value)
        {
            return value.ToUpper();
        }
        static void Main(string[] args)
        {
            // масив
            string[] arrNames = new string[] { "Hello", "Good morning", "Bye" };
            // делегат Func
            Func<string, string> selector = MySelector;
            // перетворимо слова
            IEnumerable<string> convertedNames = Enumerable.Select(arrNames, selector);
            // показуємо результат на екрані
            foreach (string str in convertedNames)
                Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
