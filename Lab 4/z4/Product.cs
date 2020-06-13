using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Product
    {
        protected string name;
        protected string data;
        protected double price;
        protected double amount;
        protected string manufacturer;

        public Product()
        {
            name = String.Empty;
            data = String.Empty;
            price = 0;
            amount = 0;
            manufacturer = String.Empty;
        }

        public Product(string name, string data, double price, double amount, string manufacturer)
        {
            try
            {
                this.name = name;
                this.data = data;
                if (price > 0)
                {
                    this.price = price;
                }
                if (amount > 0)
                {
                    this.amount = amount;
                }
                this.manufacturer = manufacturer;
            }
            catch(FormatException) // невірний формат вводу даних
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0) price = value;
            }
        }

        public double Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0) amount = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public void Print()
        {
            Console.WriteLine("Name of product: " + name);
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Manufacturer: " + manufacturer);
        }
    }
}
