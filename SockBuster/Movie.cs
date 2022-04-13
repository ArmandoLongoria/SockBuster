using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockBuster
{
    class Movie
    {
        private string title;
        private string director;
        private string genre;
        private int year;

        public Movie(string title, string director, int year, string genre)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.genre = genre;
        }

        public override string ToString()
        {
            return String.Format("\nTitle: {0}\nDirector: {1}\nYear: {2}\nGenre: {3}\n", title, director, year, genre);
        }

        public string Title { get { return title; } set { title = value; } }
        public string Director { get { return director; } set {director = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public int Year { get { return year; } set { year = value; } }

    }
}
