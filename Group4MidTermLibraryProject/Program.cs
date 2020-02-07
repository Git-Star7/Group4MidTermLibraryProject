using System;
using System.Collections.Generic;

namespace Group4MidTermLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to the Grand Circus library.");
            double media = Validation.GetUserNumber("please select the type of media you would like to check out.");
            switch (media)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            Book.DisplayAll();
        }
    }
}
