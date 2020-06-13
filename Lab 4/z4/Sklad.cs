using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Sklad
    {
        protected int number;
        protected Product[] tovar;

        public Sklad()
        {
            number = 0;
            tovar = new Product[number];
        }

        public void Add(Product obj)
        {
            int temp = number;
            temp++;
            Product[] new_tovar = new Product[temp];

            for(int i = 0; i < number; i++)
            {
                new_tovar[i] = tovar[i];
            }
            
            new_tovar[temp-1] = obj;

            tovar = new Product[temp];
            number++;

            for(int i = 0; i < number; i++)
            {
                tovar[i] = new_tovar[i];
            }
        }

        public void Output()
        {
            for(int i = 0; i < number; i++)
            {
                tovar[i].Print();
                Console.WriteLine("\n");
            }
        }

        public void NameSort()
        {

            Array.Sort(tovar, 0, number, new CompareName());
            
            for(int i = 0; i < number; i++)
            {
                tovar[i].Print();
                Console.WriteLine("\n");
            }
        }

        public void PriceSort()
        {
            Array.Sort(tovar, 0, number, new ComparePrice());

            for (int i = 0; i < number; i++)
            {
                tovar[i].Print();
                Console.WriteLine("\n");
            }
        }
     
        public void ManufacturerSort()
        {
            Array.Sort(tovar, 0, number, new CompareManufacturer());

            for (int i = 0; i < number; i++)
            {
                tovar[i].Print();
                Console.WriteLine("\n");
            }
        }

        public void Find(string type)
        {
            try
            {
                switch (type)
                {
                    case "data":
                        Console.Write("\nEnter data to find: ");
                        string new_data = Console.ReadLine();

                        int temp1 = 0;
                        for (int i = 0; i < number; i++)
                        {
                            if (new_data == tovar[i].Data)
                            {
                                Console.Write("\n");
                                tovar[i].Print();
                                temp1++;
                            }
                        }

                        if (temp1 == 0)
                        {
                            Console.WriteLine("There are no product with such data");
                        }
                        break;
                    case "price":
                        Console.Write("\nEnter price to find: ");
                        double new_price = double.Parse(Console.ReadLine());

                        if(new_price < 0)
                        {
                            Console.WriteLine("Incorrect value");
                        }

                        int temp2 = 0;
                        for (int i = 0; i < number; i++)
                        {
                            if (new_price == tovar[i].Price)
                            {
                                Console.Write("\n");
                                tovar[i].Print();
                                temp2++;
                            }
                        }
                        if(temp2 == 0)
                        {
                            Console.WriteLine("There are no product with such price");
                        }
                        break;
                    case "amount":
                        Console.Write("\nEnter amount to find (enter with ,): ");
                        double new_amount = double.Parse(Console.ReadLine());

                        if (new_amount < 0)
                        {
                            Console.WriteLine("Incorrect value");
                        }

                        int temp3 = 0;
                        for (int i = 0; i < number; i++)
                        {
                            if (new_amount == tovar[i].Amount)
                            {
                                Console.Write("\n");
                                tovar[i].Print();
                                temp3++;
                            }
                        }

                        if (temp3 == 0)
                        {
                            Console.WriteLine("There are no product with such amount");
                        }
                        break;

                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
            catch (InvalidCastException) //недопустиме перетворення типів
            {
                Console.WriteLine("InvalidCastException");
            }
            catch (FormatException) // невірний формат вводу даних
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch (OverflowException)
            {
                Console.WriteLine("System.OverflowException");
            }
            /*catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }*/
        }

    }
}
