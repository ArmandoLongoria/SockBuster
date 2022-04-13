using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockBuster
{
    class Program
    {
        Movie[] storeInventory = new Movie[5];
        public int inventorySize = 0;

        static void Main(string[] args)
        {
            Program app = new Program();
            Movie movie = new Movie("Fight Club", "David Fincher", 1999, "Thriller");
            Movie movie2 = new Movie("Soul Plane", "Jessy Terrero", 2004, "Comedy");
            Movie movie3 = new Movie("Hard Ball", "Brian Robbins", 2001, "Drama");
            Movie movie4 = new Movie("Rambo", "Ted Kotcheff", 1982, "Action");
            Movie movie5 = new Movie("V for Vendetta", "James McTeigue", 2005, "Action");
            Movie movie6 = new Movie("Friyay", "F. Gary Gray", 1995, "Comdey");
            app.AddToInventory(movie);
            app.AddToInventory(movie2);
            app.AddToInventory(movie3);
            app.AddToInventory(movie4);
            app.AddToInventory(movie5);
            app.AddToInventory(movie6);
            app.DisplayInventory();
            app.RemoveFromInventory("Hard Ball");
            app.AddToInventory(movie6);
            app.UpdateTItle("Friyay", "Friday");
            app.UpdateGenre("Friday", "Comedy");
            app.Search("genre", "Comedy");
            app.DisplayInventory();
            Console.ReadKey();

        }

        public void AddToInventory(Movie movie)
        {
            if(inventorySize < storeInventory.Length)
            {
                storeInventory[inventorySize++] = movie;
                Console.WriteLine("\n{0} added to inventory.\n", movie.Title);
                return;
            }
            Console.WriteLine("\nInventory full.\n");
        }

        public void RemoveFromInventory(string movie)
        {
            Movie[] tempMovies = new Movie[storeInventory.Length];
            int j = 0;
            for(int i = 0; i < inventorySize; i++)
            {
                if(movie == storeInventory[i].Title)
                {
                    continue;
                }
                tempMovies[j++] = storeInventory[i];
            }

            storeInventory = tempMovies;
            inventorySize--;
            Console.WriteLine("\n{0} removed from inventory.\n", movie);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\nSTORE IVENTORY\n");
            for(int i =0; i < inventorySize; i++)
            {
                Console.WriteLine(storeInventory[i]);
            }
        }

        public void Search(string type, string input)
        {
            Console.WriteLine("\nSEARCH RESULTS\n");
            int s = 0;
            if(type == "title")
            {
                for(int i = 0; i < inventorySize; i++)
                {
                    if(input == storeInventory[i].Title)
                    {
                        Console.WriteLine(storeInventory[i]);
                        s++;
                    }
                }
            }
            else if(type == "genre")
            {
                for(int i = 0; i < inventorySize; i++)
                {
                    if(input == storeInventory[i].Genre)
                    {
                        Console.WriteLine(storeInventory[i]);
                        s++;
                    }
                }
            }
            if(s == 0)
            {
                Console.WriteLine("Could not find match for {0}: {1}", type, input);
            }
        }

        public void UpdateTItle(string title, string newTitle)
        {
            for(int i = 0; i < inventorySize; i++)
            {
                if(title == storeInventory[i].Title)
                {
                    storeInventory[i].Title = newTitle;
                    Console.WriteLine("\nTitle Updated: {0}\n", newTitle);
                }
            }
        }

        public void UpdateDirector(string title, string newDirector)
        {
            for(int i = 0; i < inventorySize; i++)
            {
                if(title == storeInventory[i].Title)
                {
                    storeInventory[i].Director = newDirector;
                    Console.WriteLine("\n{0} director updated: {1}\n", title, newDirector);
                }
            }
        }

        public void UpdateGenre(string title, string newGenre)
        {
            for(int i = 0; i < inventorySize; i++)
            {
                if(title == storeInventory[i].Title)
                {
                    storeInventory[i].Genre = newGenre;
                    Console.WriteLine("\n{0} genre updated: {1}\n", title, newGenre);
                }
            }
        }

        public void UpdateYear(string title, int newYear)
        {
            for(int i = 0; i < inventorySize; i++)
            {
                if(title == storeInventory[i].Title)
                {
                    storeInventory[i].Year = newYear;
                    Console.WriteLine("\n{0} year updated: {1}\n", title, newYear);
                }
            }
        }
    }

}
