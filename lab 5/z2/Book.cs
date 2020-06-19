using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Book
    {
        protected string author;
        protected string name;
        protected string code;
        protected int year;
        protected int pages;
        protected string genre;
        private string[] genre_arr = { "detectiv", "drama", "for kids", "fantasy", "mystery" };

        public Book()
        {
            author = String.Empty;
            name = String.Empty;
            code = String.Empty;
            year = 0;
            pages = 0;
            genre = String.Empty;
        }

        public Book(string author, string name, string code, int year, int pages, string genre)
        {
            try
            {
                this.author = author;
                this.name = name;
                if (code.Length > 0 && code.Length <= 8)
                {
                    if (code.Count(char.IsPunctuation) > 0)
                    {
                        code = String.Empty;
                        Console.WriteLine("Value of code is Empty");
                    }
                    else
                    {
                        this.code = code;
                    }
                }
                if (year > 0 && year < 2020) this.year = year;
                if (pages > 0) this.pages = pages;

                foreach (var item in genre_arr)
                {
                    if (genre == item)
                    {
                        this.genre = genre;
                    }
                }

            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException"); //генерируется, если в метод для параметра передается некорректное значение
            }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set
            {
                if (code.Length > 0 && code.Length <= 8)
                {
                    if (code.Count(char.IsPunctuation) > 0)
                    {
                        code = String.Empty;
                        Console.WriteLine("Value of code is Empty");
                    }
                    else
                    {
                        code = value;
                    }
                }
                else
                {
                    Console.WriteLine("Value for code is not correct");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 2020 && value > 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Value for year is not correct");
                }
            }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    Console.WriteLine("Value for pages is < 0");
                }
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                foreach (var item in genre_arr)
                {
                    if (genre == item)
                    {
                        genre = value;
                    }
                    else
                    {
                        Console.WriteLine("Value for genre is not correct");
                    }
                }

            }
        }

        public override string ToString()
        {
            return author + " " + name + " (" + year + "), " + pages + "p, genre: " + genre + "; CODE --- " + code;
        }


    }
}
