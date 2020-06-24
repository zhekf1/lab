/*Завдання 1. 
У текстовому файлі міститься математичний вираз. Перевірити баланс
круглих дужок в даному виразі, використовуючи колекції (список/стек/чергу)
Вміст файлу: (1+2)-4*(a-3)/(2-7+6)
Перевірити роботу програми при різному вмісті файлу.*/

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("math.txt")) //відкриаємо поток для читання
                {
                    String expression = sr.ReadLine();
                    Console.WriteLine("File Reading\n");
                    Console.WriteLine("Check:  " + expression);

                    Stack brackets = new Stack();

                    foreach(char item in expression)
                    {
                        if (item == '(' || item == ')') brackets.Push(item);
                        //if (item == '[' || item == ']') brackets.Push(item);
                    }
                    
                    if(brackets.Count % 2 == 0)
                    {
                        Console.WriteLine("\nBalance is maintained");
                    }
                    else
                    {
                        Console.WriteLine("\nBalance is NOT maintained");
                    }
                    sr.Close();

                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
