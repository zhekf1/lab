/*Завдання 2. 
У текстовому файлі записана інформація про людей(прізвище, ім'я, по
батькові, вік, вага через пробіл). Вивести на екран спочатку інформацію про людей
молодше 40 років, а потім інформацію про всіх інших. (З використанням черги)*/

using System;
using System.Collections;
using System.IO;

namespace z2
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
                  
                    Queue queue_less40 = new Queue();
                    Queue queue_more40 = new Queue();

                    int temp = 1;
                    while ((person = sr.ReadLine()) != null)
                     {
                        String[] person_string = person.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); //розділяємо строку в масив   

                        int age;
                        double weight;

                        if (person_string.Length != 5)
                        {
                            Console.WriteLine("Not all components introduced, line " + temp);
                        }

                        if (Int32.TryParse(person_string[3], out age) && Double.TryParse(person_string[4], out weight))
                        {
                            if(age >= 0 && weight >= 0)
                            {
                                if(age < 40)
                                {
                                    queue_less40.Enqueue(new Persona(person_string[0], person_string[1], person_string[2], age, weight));
                                }
                                else
                                {
                                    queue_more40.Enqueue(new Persona(person_string[0], person_string[1], person_string[2], age, weight));
                                }
                               // Console.WriteLine("fff");
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
                        
                        temp++;
                     }

                    Console.WriteLine("***People under 40***\n");

                    foreach(Persona item in queue_less40)
                    {
                       Console.WriteLine(item);
                       Console.Write("\n");
                    }
                    
                    Console.WriteLine("\n***People over 40***\n");
                    foreach (Persona item in queue_more40)
                    {
                        Console.WriteLine(item);
                        Console.Write("\n");
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
