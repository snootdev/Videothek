using System;
using System.Collections.Generic;
using System.Linq;


namespace Videothek
{
    class Programm
    {
        static void Main(string[] args)
        {
            UI _UI = new UI();
            Movie _Movie = new Movie("", 0);
            var userInput = "";

            _UI.WelcomeText();
                        
            do
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                            _Movie.addMovie();
                        break;
                 
                    case "2":
                            _Movie.showMovieList();
                       
                        break;
                }


            } while (userInput != "3");
        }

    }

    class UI
    {
        public void WelcomeText()
        {
            Console.WriteLine("Welcome to the administration of your video store");
            Console.WriteLine("You can choose  the following actions:");
            Console.WriteLine("1) Add Movie");
            Console.WriteLine("2) Show All Movies");
            Console.WriteLine("3) Exit");
        }

        public string AskForMovieTitle()
        {
            Console.WriteLine("Whats the Movie Title?");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public void MovieAddedMsg()
        {
            Console.WriteLine("Movie added.");
            Console.WriteLine("------------");
        }

        public void ShowMovie(int id, string MovieTitle)
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Movietitle: {0}", MovieTitle);
            Console.WriteLine("------------");
            Console.WriteLine(" ");
        }

    }

    class Movie
    {
        public int id;
        public string MovieTitle;
        List<Movie> MovieList = new List<Movie>();
        UI _UI = new UI();
        
        public Movie(string MovieTitle, int id)
        {
            this.id = id;
            this.MovieTitle = MovieTitle;
        }
        
        public void addMovie()
        {
            var userInput = _UI.AskForMovieTitle();
            int id = MovieList.Count()+1;
            MovieList.Add(new Movie(userInput, id));
            _UI.MovieAddedMsg();
        }

        public void showMovieList()
        {
           foreach (var movie in MovieList)
            {
                _UI.ShowMovie(movie.id, movie.MovieTitle);
            } 
        }
    }
}
