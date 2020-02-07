using System;
using System.Collections.Generic;

namespace Group4MidTermLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Media> bookList = new List<Media>(Stream.MakeBookList());

           // Media.DisplayAll(bookList);
            while (true)
            {
                Console.WriteLine("Wecome to the Grand Circus library.");
                double bookmenu = Validation.GetUserNumber("please select the type of media you would like to check out.");
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
                        Stream.SetNewBookList(bookList);
                        break;
                }
            }
        }
    }
}
