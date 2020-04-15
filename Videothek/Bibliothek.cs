using System.Collections.Generic;
using System.Linq;
using System;

namespace Videothek
{
    class Bibliothek
    {
        public List<Movie> MovieList = new List<Movie>();

        public void addMovie(string Title)
        {
            var lastItem = MovieList.LastOrDefault();
            int id;

            if (lastItem != null)
            {
                id = MovieList.LastOrDefault().id;
            }else
            {
                id = 0;
            }

            id++;
            
            MovieList.Add(new Movie(id, Title));

        }

        public void delMovie(int id)
        {
                MovieList.Remove(MovieList.Where(Movie => Movie.id == id).First());
        }

    }
}
