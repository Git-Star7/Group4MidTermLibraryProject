using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Group4MidTermLibraryProject
{
    class Stream
    {

        public static List<Media> MakeBookList()
        {
            List<Media> newBookList = new List<Media>();

            StreamReader reader = new StreamReader("../../../Books.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] slot = line.Split('|');
                newBookList.Add((Media)new Book(slot[0], slot[1], DateTime.Parse(slot[2]), slot[3]));
                line = reader.ReadLine();
            }
            reader.Close();
            return newBookList;
        }
        public static void SetNewBookList(List<Book> list)
        {
            StreamWriter writer = new StreamWriter("../../../MovieCharacters.txt");
            foreach (Book slot in list)
            {
                writer.WriteLine($"{slot.Title}|{slot.Author}|{slot.DueDate}|{slot.Status}");
            }
            writer.Close();
        }

        public static List<Movies> MakeMovieList()
        {
            List<Movies> newMovieList = new List<Movies>();

            StreamReader reader = new StreamReader("../../../Movies.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] slot = line.Split('|');
                newMovieList.Add(new Movies(slot[0], slot[1], DateTime.Parse(slot[2]), slot[3]));
                line = reader.ReadLine();
            }
            reader.Close();
            return newMovieList;

        }
    }
}
