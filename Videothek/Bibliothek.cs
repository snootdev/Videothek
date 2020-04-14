using System.Collections.Generic;
using System.Linq;

namespace Videothek
{
    class Bibliothek
    {
        List<Movie> MovieList = new List<Movie>();
        UI _UI = new UI();

        public void showMovieList()
        {
            foreach (var movie in MovieList)
            {
                _UI.ShowMovie(movie.id, movie.Title);
            }
        }

        public void addMovie()
        {
            var userInput = _UI.AskForMovieTitle();
            int id = MovieList.Count() + 1;
            MovieList.Add(new Movie(userInput, id));
            _UI.MovieAddedMsg();
        }

    }
}
