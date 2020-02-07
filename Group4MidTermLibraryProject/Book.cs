using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Book : Media
    {
        //fields+properties
        

        //constructors
        public Book(string title, string author, DateTime dueDate, string status)
        {
            Title = title;
            Author = author;
            DueDate = dueDate;
            Status = status;
        }

        //methods
        public static void DisplayAll()
        {
            List<Book> book = new List<Book>();
            book = Stream.MakeBookList();
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"\t{book[i].Title}");
                Console.WriteLine($"\t{book[i].Author}");
                Console.WriteLine($"\t{book[i].DueDate}");
                Console.WriteLine($"\t{book[i].Status}");
                Console.WriteLine();
            }
        }

    }
}
