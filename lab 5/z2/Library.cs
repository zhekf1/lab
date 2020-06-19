using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Library
    {
        protected List<Book> book_array = new List<Book>();

        public void Add(Book b)
        {
            book_array.Add(b);
        }

        public void CompareAuthor(Book book1, Book book2)
        {
            if (book_array.Count <= 0)
            {
                Console.WriteLine("There are no books in library");

            }
            else
            {
                Console.WriteLine("\nСomparison of books by author:\n");
                string st1 = book1.ToString();
                string st2 = book2.ToString();
                Console.WriteLine(st1 + "\n\n" + st2 + "\nResult: ");

                if (book1.Author == book2.Author)
                {
                    Console.WriteLine("Books have same author");
                }
                else
                {
                    Console.WriteLine("Books have different authors");
                }
            }
        }

        public void CompareCode(Book book1, Book book2)
        {
            if (book_array.Count <= 0)
            {
                Console.WriteLine("There are no books in library");

            }

            else
            {
                Console.WriteLine("\nСomparison of books by codes:\n");
                string st1 = book1.ToString();
                string st2 = book2.ToString();
                Console.WriteLine(st1 + "\n\n" + st2 + "\nResult: ");

                if (book1.Code == book2.Code)
                {
                    Console.WriteLine("This is same book");
                }
                else
                {
                    Console.WriteLine("Books have different codes");
                }
            }
        }

        public void CompareYear(Book book1, Book book2)
        {
            if (book_array.Count <= 0)
            {
                Console.WriteLine("There are no books in library");

            }
            else
            {
                Console.WriteLine("\nСomparison of books by year:\n");
                string st1 = book1.ToString();
                string st2 = book2.ToString();
                Console.WriteLine(st1 + "\n\n" + st2 + "\nResult: ");

                if (book1.Year == book2.Year)
                {
                    Console.WriteLine("Books were published in one year");
                }
                else
                {
                    Console.WriteLine("Books were published in different year");
                }
            }
        }

        public void ComparePages(Book book1, Book book2)
        {
            if (book_array.Count <= 0)
            {
                Console.WriteLine("There are no books in library");

            }
            else
            {
                Console.WriteLine("\nСomparison of books by pages:\n");
                string st1 = book1.ToString();
                string st2 = book2.ToString();
                Console.WriteLine(st1 + "\n\n" + st2 + "\nResult: ");

                if (book1.Pages == book2.Pages)
                {
                    Console.WriteLine("Books have the same number of pages");
                }
                else
                {
                    Console.WriteLine("Books were published in different year");
                }
            }

        }

        public int Find()
        {
            Console.WriteLine("Finding:");
            if (book_array.Count <= 0)
            {
                Console.WriteLine("There are no books in library");
                return 1;
            }

            else
            {
                string searchingCode;
                Console.Write("Enter code: ");
                searchingCode = Console.ReadLine();

                foreach (Book item in book_array)
                {
                    if (searchingCode == item.Code)
                    {
                        string st = item.ToString();
                        Console.WriteLine(st);
                        return 0;
                    }
                }

                Console.WriteLine("There are NO book with this code");
                return 0;
            }

        }

    }
}
