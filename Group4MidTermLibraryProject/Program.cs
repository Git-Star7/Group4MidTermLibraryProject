using System;
using System.Collections.Generic;

namespace Group4MidTermLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Media> bookList = new List<Media>(Stream.MakeBookList());
            List<Media> MovieList = new List<Media>(Stream.MakeMovieList());
            List<Media> mediaList = new List<Media>();
            foreach (Media m in bookList)
            {
                mediaList.Add(m);
            }
            foreach (Media m in MovieList)
            {
                mediaList.Add(m);
            }
            Console.WriteLine("Wecome to the Grand Circus library.");

            bool continueLoop = true;
            while (continueLoop == true)
            {
                Console.WriteLine(" 1: Display all media\n 2: Search items by author or genre\n 3: Search books by title\n 4: Select an item to checkout\n");

                double bookmenu = Validation.GetUserNumber("Please select an option from the menu.");
                
                switch (bookmenu)
                {
                    case 1:
                        Book.DisplayAll(bookList);
                        Movies.DisplayAll(MovieList);
                        break;
                    case 2:
                        Media.PrintBy(mediaList);
                        break;
                    case 3:
                        Media.PrintByTitle(mediaList);
                        break;
                    case 4:
                        Media.SelectToCheckout(mediaList);
                        Stream.SetNewList(mediaList);
                        break;

                }

                Validation.AskUserContinue("Would you like to continue? y/n ", "y", "n");
            }
        }
    }
}
