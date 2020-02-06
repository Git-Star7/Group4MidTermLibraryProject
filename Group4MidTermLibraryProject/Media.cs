using System;
using System.Collections.Generic;
using System.Text;

namespace Group4MidTermLibraryProject
{
    abstract class Media
    {
        //properties
        public string MediaType { get; set; }
        public string Title { get; set; }
        public DateTime DueDate {get; set;}
        public string Status { get; set; }


    }
}
