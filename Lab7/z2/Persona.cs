using System;

namespace z2
{
    class Persona
    {
        private string surname;
        private string name;
        private string patronymic;
        private int age;
        private double weight;

        public Persona()
        {
            surname = String.Empty;
            name = String.Empty;
            patronymic = String.Empty;
            age = 0;
            weight = 0;
        }

        public Persona(string surname, string name, string patronymic,int age, double weight)
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
