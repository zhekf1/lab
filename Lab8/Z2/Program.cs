/*Написати статичний метод ReadFiles, що виконує вказані дії над вмістом файлу.
Формальні параметри : файл, задана дія – об'єкт Action/Func.
Використовуючи написаний метод:
 вивести вміст файлу на екран;
 вивести на екран всі числа! (числа складаються с цифр);
 замінити у файлі всі коми/крапки/* /() на пробіли.
Після виклику останньої дії – вивести вміст файлу на екран.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            const String filePath = "Input.txt";
            ReadFiles(filePath,"Чтение и вывод с файла",(Action<String>)PrintText);
            ReadFiles(filePath, "Чтение и выводт чисел с файла", (Action<String>)PrintNumbers);
            ReadFiles(filePath, "Замена символов в файле", ReplaceText);
            ReadFiles(filePath, "Чтение и вывод с файла", (Action<String>)PrintText);
            Console.ReadKey();
        }

        static void ReadFiles(String filePath,String name, Action<String> act)
        {
            Console.WriteLine(name);
            String text = String.Empty;
            try
            {
                text = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Проблемы с доступом к файлу");
                Console.ReadKey();
                Environment.Exit(1);
            }
            act(text);
        }

        static void ReadFiles(String filePath,String name, Func<String, String> act)
        {
            Console.WriteLine(name);
            String text = String.Empty;
            try
            {
                text = File.ReadAllText(filePath);
                File.WriteAllText(filePath, act(text));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Проблемы с доступом к файлу");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }

        static void PrintText(String text)
        {
            Console.WriteLine(text);
        }

        static void PrintNumbers(String text)
        {
            List<String> numbers = new List<String>();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    StringBuilder number = new StringBuilder(text[i].ToString());
                    int j = i + 1;
                    while (j < text.Length && Char.IsDigit(text[j]))
                    {
                        number.Append(text[j]);
                        j++;
                    }
                    i += j - i;
                    numbers.Add(number.ToString());
                }
            }
            numbers.ForEach(number => Console.Write($"{number} "));
            Console.WriteLine();
        }

        static String ReplaceText(String text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);
            for (var i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == '.' || stringBuilder[i] == ',' || stringBuilder[i] == '*' || stringBuilder[i] == '(' || stringBuilder[i] == ')')
                {
                    stringBuilder[i] = ' ';
                }
            }
            return stringBuilder.ToString();
        }

    }
}
