using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Book : Media
    {
        //fields+properties
        public string Author { get; set; }

        public Book()
        {

        }
        //constructors
        public Book(string title, string author, DateTime dueDate, string status)
        {
            Title = title;
            Author = author;
            DueDate = dueDate;
            Status = status;
            MediaType = "book";
        }
        public static void DisplayAll(List<Media> books)
        {
            foreach (Media book in books)
            {
                if(book is Book)
                {
                    Book book2 = (Book)book;
                    if (book2.Status == "Checked Out")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Title:\t{book2.Title}");
                        Console.WriteLine($"Author:\t{book2.Author}\t\tShelf Status:\t{book2.Status}");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Title:\t{book2.Title}");
                        Console.WriteLine($"Author:\t{book2.Author}\t\tShelf Status:\t{book2.Status}\t\tDue Back:\t{book2.DueDate.ToShortDateString()}");
                    }
                }
            }
        }
    }
}
