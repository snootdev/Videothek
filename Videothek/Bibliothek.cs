using System.Collections.Generic;
using System.Linq;

namespace Videothek
{
    class Bibliothek
    {
        public List<Movie> MovieList = new List<Movie>();

        public bool addMovie(string Title)
        {
            int id = MovieList.Count() + 1;
            MovieList.Add(new Movie(id, Title));
            return true;
        }

    }
}
