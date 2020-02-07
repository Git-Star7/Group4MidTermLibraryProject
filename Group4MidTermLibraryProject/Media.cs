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
        public static void PrintMediaByTitle(List<Book> booksList, string partialTitle)
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
        public static void SelectMediaToCheckout(List<Book> booksList, string title)
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
                    }
                }
            }
        }
        public void ReturnMedia(List<Book> booksList, string title)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (title == booksList[i].Title)
                {
                    Status = "On Shelf";
                    DueDate = DateTime.Now;
                }
            }
        }
    }

   
  

  
}