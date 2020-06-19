using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("J.R.R. Tolkien", "The Lord of the Rings", "evf45y23", 1954, 350, "fantasy");
            Book b2 = new Book("Sir Arthur Conan Doyle", "A Scandal in Bohemia", "d54hb843", 1891, 150, "detectiv");
            Book b3 = new Book("Louisa May Alcott", "Little Women", "t5eg582s", 1868, 400, "drama");
            Book b4 = new Book("J.K.Rowling", "Harry Potter ang Goblet of Fire", "df65hkfn", 2000, 350, "for kids");
            Book b5 = new Book("Bram Stoker", "Dracula", "4bidnvjs", 1897, 245, "mystery");

            /*string a = b1.ToString();
            Console.WriteLine(a);
            */
            Library library = new Library();
            library.Add(b1);
            library.Add(b2);
            library.Add(b3);
            library.Add(b4);
            library.Add(b5);

            library.Find();

            library.CompareAuthor(b1, b2);
            library.CompareCode(b1, b1);
            library.ComparePages(b1, b4);
            library.CompareYear(b3, b5);

            Console.ReadLine();
        }
    }
}
