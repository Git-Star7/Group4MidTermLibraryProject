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



        //methods
        public static void DisplayAll(List<Media> book)
        {
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"\t{book[i].Title}");
                Console.WriteLine($"\t{book[i].Author}");
                Console.WriteLine($"\t{book[i].DueDate}");
                Console.WriteLine($"\t{book[i].Status}");
                Console.WriteLine();
            }
        }
        public void PrintMediaByTitle(List<Book> booksList, string partialTitle) //print movies by category selected with string (unused)
        {
            List<Book> listOfBooksOfThatTitle = new List<Book>();
            int num = 0;
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i].Title.Contains(partialTitle))
                {
                    listOfBooksOfThatTitle.Add(booksList[i]);
                }
            }
            listOfBooksOfThatTitle.Sort();
            foreach (Book book in listOfBooksOfThatTitle)
            {
                num++;
                Console.WriteLine($"{book.Title}");
            }
        }
        public void SelectMediaToCheckout()
        {

        }
        public void ReturnMedia()
        {
            Status = "On Shelf";
        }
    }

   
  

  
}