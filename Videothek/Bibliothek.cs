using System.Collections.Generic;
using System.Linq;
using System;

namespace Videothek
{
    class Bibliothek
    {
        private List<Movie> Bib = new List<Movie>();

        public List<Movie> MovieList()
        {
            return Bib;
        }

        public void addMovie(string Title)
        {
            var lastItem = Bib.LastOrDefault();
            int id;

            if (lastItem != null)
            {
                id = lastItem.id;
            }else
            {
                id = 0;
            }

            id++;
            
            Bib.Add(new Movie(id, Title));

        }

        public void delMovie(int id)
        {
                Bib.Remove(Bib.Where(Movie => Movie.id == id).First());
        }

    }
}
