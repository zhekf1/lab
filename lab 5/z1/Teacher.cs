using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Teacher : Abiturient
    {
        protected string posada;
        protected int staz;

        public Teacher(string surname, DateTime birth_date, string faculty, string posada, int staz) : base(surname, birth_date, faculty)
        {
            this.posada = posada;
            this.staz = staz;
        }

        public void Show()
        {
            Console.WriteLine("This is Teacher");
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Date of birth: " + birth_date);
            Age();
            Console.WriteLine("Faculty: " + faculty);
            Console.WriteLine("Posada: " + posada);
            Console.WriteLine("Staz: " + staz);
        }
    }
}
