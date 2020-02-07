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
        public static void DisplayAll(List<Book> book)
        {
            
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"\t{book[i].Title}");
                Console.WriteLine($"\t{book[i].Author}");
                Console.WriteLine($"\t{book[i].DueDate}");
                Console.WriteLine($"\t{book[i].Status}");
            }
        }
        public static void PrintByTitle(List<Book> booksList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("select a book");
                for (int i = 0; i < booksList.Count; i++)
                {
                    if (booksList[i].Title.Contains(partialTitle))
                    {
                        Console.WriteLine(booksList[i].Title);
                        nothing = false;
                    }

                }
                if (nothing)
                {
                    Console.WriteLine("We do not contain that book");
                }
            }
            while (nothing);

        }
        public static void PrintByAuthor(List<Book> booksList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("select a book");
                for (int i = 0; i < booksList.Count; i++)
                {
                    if (booksList[i].Author.Contains(partialTitle))
                    {
                        Console.WriteLine(booksList[i].Title);
                        nothing = false;
                    }

                }
                if (nothing)
                {
                    Console.WriteLine("We do not contain that book");
                }
            }
            while (nothing);

        }
        public static void SelectToCheckout(List<Book> booksList, string title)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (title == booksList[i].Title)
                {
                    if (booksList[i].Status == "Checked Out")
                    {
                        Console.WriteLine("Sorry, this book is checked out.");
                    }
                    else
                    {
                        booksList[i].Status = "Checked Out";
                        booksList[i].DueDate = DateTime.Now.AddDays(14);
                        break;
                    }
                }
            }

        }
    }
}
