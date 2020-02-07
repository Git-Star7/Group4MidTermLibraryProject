using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Book : Media
    {
        //fields+properties
        public string Author { get; set; }

        //constructors
        public Book(string author)
        {
            Author = author;
        }

        public Book(string title, string author, DateTime dueDate, string status)
        {
            Title = title;
            Author = author;
            DueDate = dueDate;
            Status = status;
        }

        public void DisplayBookByAuthor()
        {

        }
        public override void DisplayAllMedia()
        {

        }

        public override void DisplayMediaByTitle()
        {
            
        }

        public override void SelectMediaToCheckout()
        {
            
        }

        public override void ReturnMedia()
        {
            Status = "On Shelf";
        }

        //methods

    }
}
