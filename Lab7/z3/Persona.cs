using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Persona
    {
        private string surname;
        private string name;
        private string patronymic;
        private int age;
        private double weight;

        public int Age
        {
            get { return age; }
        }

        public Persona()
        {
            surname = String.Empty;
            name = String.Empty;
            patronymic = String.Empty;
            age = 0;
            weight = 0;
        }

        public Persona(string surname, string name, string patronymic, int age, double weight)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.age = age;
            this.weight = weight;
        }

        public override string ToString()
        {
            return surname + " " + name + " " + patronymic + "\nAge: " + age + "\nWeight: " + weight;
        }
    }
}
