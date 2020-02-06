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

        //methods
        
    }
}
