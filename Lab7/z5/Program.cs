/*Завдання 5
Робота з набором ArrayList
 У набір ArrayList помістити випадкові значення типу Int в діапазоні і кількості
відповідно до варіанта(див.Табл. 1) за допомогою методу add.
 Відсортувати набір в порядку зростання.
 Вивести всі елементи набору за допомогою циклу foreach.
 Значення номера варіанту занести в набір на позицію, що дорівнює номеру варіанта.
 Згенерувати нове значення в межах від 0 до номера варіанту +1000 і
перевірити чи існує таке значення в наборі, якщо існує визначити його індекс.
 Видалити елемент набору рівний випадковому значенню, згенерованого в
межах від 0 до максимального індексу набору.
 Видалити всі елементи набору.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 10;
            ArrayList arr = new ArrayList();

            for(int i = 0; i < n; i++)
            {
                arr.Add(random.Next(100, 301));
            }

            Console.Write("Array: ");
            foreach(var item in arr)
            {
                Console.Write(item + "  ");
            }

            arr.Sort();

            Console.Write("\n\nSorted array: ");
            foreach(var item in arr)
            {
                Console.Write(item + "  ");
            }

            arr.Insert(8,8);

            Console.Write("\n\nEntering element 8 with index 8: ");
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }

            int elem = random.Next(0, 1008);

            if (arr.Contains(elem))
            {
                int index1 = arr.IndexOf(elem);
                Console.WriteLine("\n\nElement " + elem + " with index " + index1);
            }
            else Console.WriteLine("\n\nThere are no element " + elem + " in array");

            int index2 = random.Next(0, arr.Count);
            Console.WriteLine("\nDeleting element " + arr[index2] + " with index " + index2);

            arr.RemoveAt(index2);

            Console.WriteLine("\nArray after deleting: ");

            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine("\n\nDeleting all elements of array");
            arr.Clear();

            Console.WriteLine("Count of array is " + arr.Count);

            Console.ReadKey();
        }
    }
}
