using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Magazines : Media
    {
        
        public string Category { get; set; }

        public Magazines(string title, string category, DateTime dueDate, string status)
        {
            Title = title;
            Category = category;
            DueDate = dueDate;
            Status = status;
            MediaType = "Magazine";
        }

        //methods
       /* public static void DisplayAll(List<Media> magazines)
        {

            foreach (Media mag in magazines)
            {
                mag.DisplayContent();
            }
        }*/
        public static void PrintByTitle(List<Media> magList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("Select a magazine: ");
                for (int i = 0; i < magList.Count; i++)
                {
                    if (magList[i].Title.Contains(partialTitle))
                    {
                        Console.WriteLine(magList[i].Title);
                        nothing = false;
                    }

                }
                if (nothing)
                {
                    Console.WriteLine("We do not have that magazine on file.");
                }
            }
            while (nothing);

        }
        /*public static void PrintByAuthor(List<Media> magList)
        {

            bool nothing = true;
            do
            {

                string partialTitle = Validation.GetUserInput("Select a magazine");
                for (int i = 0; i < magList.Count; i++)
                {
                    if (magList[i].Author.Contains(partialTitle))
                    {
                        Console.WriteLine(magList[i].Title);
                        nothing = false;
                    }

                }
                if (nothing)
                {
                    Console.WriteLine("We do not contain that book");
                }
            }
            while (nothing);

        }*/
        public static void SelectToCheckout(List<Media> magList, string title)
        {
            for (int i = 0; i < magList.Count; i++)
            {
                if (title == magList[i].Title)
                {
                    if (magList[i].Status == "Checked Out")
                    {
                        Console.WriteLine("Sorry, this magazine is checked out.");
                    }
                    else
                    {
                        magList[i].Status = "Checked Out";
                        magList[i].DueDate = DateTime.Now.AddDays(14);
                        break;
                    }
                }
            }

        }

       /* public override void DisplayContent()
        {
            Console.WriteLine();
            Console.WriteLine($"\t{Title}");
            Console.WriteLine($"\t{Category}");
            Console.WriteLine($"\t{DueDate}");
            Console.WriteLine($"\t{Status}");
        }*/
       
    }
}
