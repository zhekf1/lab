using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sklad sklad_product = new Sklad();

                Product pr1 = new Product("Apple", "11.01.2020", 500, 100.3, "Ukraine");
                sklad_product.Add(pr1);
                Product pr2 = new Product("Pear", "20.01.2020", 800, 230.8, "UK");
                sklad_product.Add(pr2);
                Product pr3 = new Product("Potato", "01.03.2020", 245, 560.75, "USA");
                sklad_product.Add(pr3);
                Product pr4 = new Product("Tomato", "04.02.2020", 460, 80.45, "Poland");
                sklad_product.Add(pr4);
                Product pr5 = new Product("Cherry", "11.03.2020", 780, 300, "Ukraine");
                sklad_product.Add(pr5);

                Console.Write("Menu:\n1.Output all products;\n2.Find product;\n3.Sort products;\nEnter number: ");
                int num = Int32.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Output\n");
                        sklad_product.Output();
                        break;
                    case 2:
                        Console.Write("\nEnter value(data, price, amount): ");
                        string type_find = Console.ReadLine();
                        sklad_product.Find(type_find);
                        break;
                    case 3:
                        Console.Write("\nEnter value(name, price, manufacturer): ");
                        string type_sort = Console.ReadLine();

                        if (type_sort == "name")
                        {
                            sklad_product.NameSort();
                        }
                        if (type_sort == "price")
                        {
                            sklad_product.PriceSort();
                        }
                        if (type_sort == "manufacturer")
                        {
                            sklad_product.ManufacturerSort();
                        }
                        if (type_sort != "name" && type_sort != "price" && type_sort != "manufacturer")
                        {
                            Console.WriteLine("Incorrect value");
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Попытка разыменовать указатель на Null объект");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("System.OverflowException");
            }

            Console.ReadKey();
        }
    }
}
