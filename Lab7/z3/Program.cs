/*Завдання 3. 
У текстовому файлі записана інформація про людей(прізвище, ім'я, по
батькові, вік, вага через пробіл). Вивести на екран інформацію про людей, відсортовану
за віком. (ArrayList перевантаження методу Compare).*/

using System;
using System.IO;
using System.Collections;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("People.txt"))
                {
                    String person;
                    Console.WriteLine("File Reading\n");

                    ArrayList array = new ArrayList();

                    int temp = 1;
                    while ((person = sr.ReadLine()) != null)
                    {
                        String[] person_string = person.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //розділяємо строку в масив   

                        int age;
                        double weight;

                        if (person_string.Length != 5)
                        {
                            Console.WriteLine("Not all components introduced, line " + temp);
                        }

                        if (Int32.TryParse(person_string[3], out age) && Double.TryParse(person_string[4], out weight))
                        {
                            if (age >= 0 && weight >= 0)
                            {
                                array.Add(new Persona(person_string[0], person_string[1], person_string[2], age, weight));
                            }
                            else
                            {
                                Console.WriteLine("Age or weight is wrong in line" + temp);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid type conversion in line " + temp);
                        }
                    }
                    
                    array.Sort(new AgeCompare());
                    
                    foreach (Persona item in array)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("\n");
                    }
                    sr.Close();
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
