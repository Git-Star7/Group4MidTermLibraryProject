using System;
using System.Collections.Generic;

namespace Group4MidTermLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
