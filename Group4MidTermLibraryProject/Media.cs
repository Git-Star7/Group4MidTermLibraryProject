using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    abstract class Media
    { 
        //properties
       
        public string Title { get; set; }

        public string Author { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }

       
        public static void PrintList(List<Media> print)
        {

            for (int i = 0; i < print.Count; i++)
            {
               
                Console.WriteLine();
                Console.WriteLine($"\t{print[i].Title}");
                Console.WriteLine($"\t{print[i].Author}");
                Console.WriteLine($"\t{print[i].DueDate}");
                Console.WriteLine($"{print[i].Status}");
                Console.WriteLine();

            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

    }

   
  

  
}