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
        public static void SetNewList(List<Media> list)
        {
            StreamWriter bookWriter = new StreamWriter("../../../Books.txt");
            StreamWriter movieWriter = new StreamWriter("../../../Movies.txt");
            foreach (Media slot in list)
            {
                if (slot is Book)
                {
                    Book book = (Book)slot;
                    bookWriter.WriteLine($"{book.Title}|{book.Author}|{book.DueDate}|{book.Status}");
                }
                if (slot is Movies)
                {
                    Movies movie = (Movies)slot;
                    movieWriter.WriteLine($"{movie.Title}|{movie.Genre}|{movie.DueDate}|{movie.Status}");
                }
            }
            bookWriter.Close();
            movieWriter.Close();
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
