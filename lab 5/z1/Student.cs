using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Student : Abiturient
    {
        protected int course;

        public Student(string surname, DateTime birth_date, string faculty, int course) : base(surname, birth_date, faculty)
        {
            this.course = course;
        }

        public void Show()
        {
            Console.WriteLine("This is Student");
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Date of birth: " + birth_date);
            Age();
            Console.WriteLine("Faculty: " + faculty);
            Console.WriteLine("Course: " + course);
        }
    }
}
