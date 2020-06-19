using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Abiturient : Persona
    {
        protected string faculty;

        public Abiturient(string surname, DateTime birth_date, string faculty) : base(surname, birth_date)
        {
            this.faculty = faculty;
        }

        public override void Show()
        {
            Console.WriteLine("This is Abiturient");
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Date of birth: " + birth_date);
            Age();
            Console.WriteLine("Faculty: " + faculty);
        }
    }
}
