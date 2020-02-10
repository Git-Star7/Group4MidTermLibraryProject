using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    abstract class Media
    {
        //properties

        public string Title { get; set; }
        
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string MediaType { get; set; }

        public static void PrintByTitle(List<Media> mediaList)
        {
            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("Select a title");
                for (int i = 0; i < mediaList.Count; i++)
                {
                    if (mediaList[i].Title.Contains(partialTitle))
                    {
                        Console.WriteLine(mediaList[i].Title);
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
        public static void SelectToCheckout(List<Media> mediaList)
        {
            Console.WriteLine("Choose an item.");
            bool validInput = false;
            while (!validInput)
            {
                string title = Console.ReadLine();
                for (int i = 0; i < mediaList.Count; i++)
                {
                    if (title == mediaList[i].Title)
                    {
                        if (mediaList[i].Status == "Checked Out")
                        {
                            Console.WriteLine("Sorry, this item is checked out.");
                        }
                        else
                        {
                            Console.WriteLine($"This item is now checked out and due back in 14 days on {DateTime.Now.AddDays(14)}");
                            mediaList[i].Status = "Checked Out";
                            mediaList[i].DueDate = DateTime.Now.AddDays(14);
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
        public static void PrintBy(List<Media> mediaList)
        {
            bool nothing = true;
            do
            {
                string input = Validation.GetUserInput("Select an author or genre");

                foreach (Media item in mediaList)
                {
                    if (item is Book)
                    {
                        PrintBooks(item, input);
                        nothing = false;
                    }
                    if (item is Movies)
                    {
                        PrintMovies(item, input);
                        nothing = false;
                    }
                }
                if (nothing)
                {
                    Console.WriteLine("We do not contain that item");
                }
            }
            while (nothing);

        }
        private static void PrintMovies(Media media, string genreType)
        {
            {
                Movies movie = (Movies)media;
                if (movie.Genre.Contains(genreType))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
        private static void PrintBooks(Media media, string authorName)
        {
            {
                Book book = (Book)media;
                if (book.Author.Contains(authorName))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

    }
}
