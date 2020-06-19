using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    abstract class Persona
    {
        protected string surname;
        protected DateTime birth_date;

        public Persona(string surname, DateTime birth_date)
        {
            this.surname = surname;
            this.birth_date = birth_date;

        }

        abstract public void Show(); //абстрактний метод

        public void Age()
        {
            DateTime localDate = DateTime.Now;
            DateTime age = new DateTime(localDate.Ticks - birth_date.Ticks);

            Console.WriteLine("Age: " + (age.Year - 1));

        }
    }
}
