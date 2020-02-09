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
        
        public static void PrintByTitle(List<Media> booksList)
        {
            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("Select a title");
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

                string partialTitle = Validation.GetUserInput("Select an author");
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
        public static void SelectToCheckout(List<Media> booksList)
        {
            Console.WriteLine("Choose a book");
            bool validInput = false;
            while (!validInput)
            {
                string title = Console.ReadLine();
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
                            Console.WriteLine($"This book is now checked out and due back in 14 days on {DateTime.Now.AddDays(14)}");
                            booksList[i].Status = "Checked Out";
                            booksList[i].DueDate = DateTime.Now.AddDays(14);
                        }
                        validInput = true;
                    }
                }
                if (validInput == true)
                {
                    break;
                }
                Console.WriteLine("Invalid input, please select another title");
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
        public static void DisplayAll(List<Media> books)
        {
            foreach (Media book in books)
            {
                book.DisplayContent();
            }
        }
    }
}
