using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Book : Media
    {
        //fields+properties
        

        //constructors
        public Book(string title, string author, string v, DateTime dueDate, string status)
        {
            Title = title;
            Author = author;
            DueDate = dueDate;
            Status = status;
        }

        //methods

    }
}
