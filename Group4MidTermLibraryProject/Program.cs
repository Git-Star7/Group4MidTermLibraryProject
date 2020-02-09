using System;
using System.Collections.Generic;

namespace Group4MidTermLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Media> bookList = new List<Media>(Stream.MakeBookList());
            Console.WriteLine("Wecome to the Grand Circus library.");

            bool continueLoop = true;
            while (continueLoop == true)
            {
                Console.WriteLine(" 1: Display all books\n 2: Search books by Author\n 3: Search books by title\n 4: Select a book to chechout\n");

                double bookmenu = Validation.GetUserNumber("please select an option from the menu.");
                
                switch (bookmenu)
                {
                    case 1:
                        Book.DisplayAll(bookList);
                        break;
                    case 2:
                        Book.PrintByAuthor(bookList);
                        break;
                    case 3:
                        Book.PrintByTitle(bookList);
                        break;
                    case 4:
                        Book.SelectToCheckout(bookList);
                        //Stream.SetNewBookList(bookList);
                        break;
                }

                Validation.AskUserContinue("Would you like to continue? y/n ", "y", "n");
            }
        }
    }
}
