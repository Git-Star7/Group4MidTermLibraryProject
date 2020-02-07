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
            MediaType = "book";
        }

        //methods
        public static void DisplayAll(List<Media> books)
        {
            
            foreach(Media book in books)
            {
                book.DisplayContent();
            }
        }
        public static void PrintByTitle(List<Media> booksList)
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
        public static void PrintByAuthor(List<Media> booksList)
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
        public static void SelectToCheckout(List<Media> booksList, string title)
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

        public override void DisplayContent()
        {
            Console.WriteLine();
            Console.WriteLine($"\t{Title}");
            Console.WriteLine($"\t{Author}");
            Console.WriteLine($"\t{DueDate}");
            Console.WriteLine($"\t{Status}");
        }
    }
}
