using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Movies : Media
    {
        
        public string Genre { get; set; }
        public Movies(string title, string genre, DateTime dueDate, string status)
        {
            Title = title;
            Genre = genre;
            DueDate = dueDate;
            Status = status;
        }

        //methods
        public static void PrintByTitle(List<Movies> movieList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("select a book");
                for (int i = 0; i < movieList.Count; i++)
                {
                    if (movieList[i].Title.Contains(partialTitle))
                    {
                        Console.WriteLine(movieList[i].Title);
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
        public static void PrintByAuthor(List<Movies> movieList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("What movie are you looking for?");
                for (int i = 0; i < movieList.Count; i++)
                {
                    if (movieList[i].Author.Contains(partialTitle))
                    {
                        Console.WriteLine(movieList[i].Title);
                        nothing = false;
                    }

                }
                if (nothing)
                {
                    Console.WriteLine("Sorry, we don't have that movie on file.");
                }
            }
            while (nothing);

        }
        public static void SelectToCheckout(List<Movies> movieList, string title)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (title == movieList[i].Title)
                {
                    if (movieList[i].Status == "Checked Out")
                    {
                        Console.WriteLine("Sorry, this movie is checked out.");
                    }
                    else
                    {
                        movieList[i].Status = "Checked Out";
                        movieList[i].DueDate = DateTime.Now.AddDays(14);
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
        public static void DisplayAll(List<Media> books)
        {
            foreach (Media book in books)
            {
                book.DisplayContent();
            }
        }
    }
}
