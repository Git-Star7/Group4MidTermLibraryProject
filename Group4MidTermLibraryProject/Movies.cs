using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Movies : Media
    {
        
        public string Genre { get; set; }
        
      
        //constructors
        public Movies(string title, string genre, DateTime dueDate, string status)
        {
            Title = title;
            Genre = genre;
            DueDate = dueDate;
            Status = status;
            MediaType = "movie";
        }
        public static void DisplayAll(List<Media> mediaList)
        {
            foreach (Media media in mediaList)
            {
                if (media is Movies)
                {
                    Movies movie = (Movies)media;
                    if (movie.Status == "Checked Out")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Title:\t{movie.Title}");
                        Console.WriteLine($"Genre:\t{movie.Genre}\t\tShelf Status:\t{movie.Status}");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Title:\t{movie.Title}");
                        Console.WriteLine($"Genre:\t{movie.Genre}\t\tShelf Status:\t{movie.Status}\t\tDue Back:\t{movie.DueDate.ToShortDateString()}");
                    }
                }
            }
        }
    }
}
