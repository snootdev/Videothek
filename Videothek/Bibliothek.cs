using System.Collections.Generic;
using System.Linq;
using System;

namespace Videothek
{
    class Bibliothek
    {
        private List<Movie> Bib = new List<Movie>();
        int id;

        public List<Movie> MovieList()
        {
            return Bib;
        }

        public void addMovie(string Title)
        {
            Bib.Add(new Movie(++id, Title));

        }

        public void delMovie(int id)
        {
                Bib.Remove(Bib.Where(Movie => Movie.id == id).First());
        }

        public void editMovie(int id, string newTitle)
        {
               Bib.First(Movie => Movie.id == id).Title = newTitle;
        }

    }
}
