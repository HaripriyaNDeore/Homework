using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class Book
    {
        public int BookId;
        public String BookName, BookAuthor, BookPublication;
       
        
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            Console.WriteLine("Enter BookId ");
            Console.WriteLine("Enter BookName ");
            Console.WriteLine("Enter BookAuthor ");
            Console.WriteLine("Enter BookPublication ");

            b1.BookId = Convert.ToInt32(Console.ReadLine());
            b1.BookName = Console.ReadLine();
            b1.BookAuthor = Console.ReadLine();
            b1.BookPublication = Console.ReadLine();

            Console.WriteLine("Book Id "+b1.BookId+ " Book Name " + b1.BookName+ " Book Author " + b1.BookAuthor+ " Book Publication " + b1.BookPublication);
            Console.WriteLine("");
            Console.WriteLine("");
            b2.BookId=1;
            b2.BookName = "Shamchi Aai";
            b2.BookAuthor = "Sane Guruji";
            b2.BookPublication = "xyz";

            Console.WriteLine("Book Id " + b2.BookId + " Book Name " + b2.BookName + " Book Author " + b2.BookAuthor + " Book Publication " + b2.BookPublication);


            Console.Read();

        }
    }
}
