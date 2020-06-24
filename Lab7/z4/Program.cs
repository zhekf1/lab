/*Вирішити з використанням колекції Стек. Дано файл, в якому записаний набір чисел.
Переписати в інший файл всі числа в зворотньому порядку.*/

using System;
using System.Collections;
using System.IO;


namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Numbers.txt")) //відкриаємо поток для читання
                {
                    //виконуємо читання з файлу та запис в строку
                    String nums_string = sr.ReadLine();
                    Console.WriteLine("File Reading\n");
                    String[] nums_array = nums_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //розділяємо строку в масив 
                    
                    foreach (string item in nums_array)
                    {
                        Console.Write(item + "  ");
                    }

                    //створюємо стек для запису елементів
                    Stack numbers = new Stack();
                    foreach(string item in nums_array)
                    {
                        int k = Int32.Parse(item); // парсимо елементи string в int для того щоб правильно заповнити стек
                        numbers.Push(k);
                    }

                    sr.Close();

                    Console.WriteLine("\n\nStack:");
                    
                    using (StreamWriter sw = new StreamWriter("New_numbers.txt", false, System.Text.Encoding.Default))
                    {
                        while (numbers.Count != 0)
                        {
                            object k = numbers.Pop();
                            sw.Write(k + "  ");
                            Console.Write(k + "  ");
                        }
                        Console.WriteLine("\n\nResult is in file New_numbers.txt");
                        sw.Close();
                    }
                }
            }
            catch(Exception ex) //обробка виключень, наприклад якщо файла Numbers.txt не існує або в файлі введений невірний формат даних
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
