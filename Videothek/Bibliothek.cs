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

        public void AddMovie(string Title)
        {
            Bib.Add(new Movie(++id, Title));

        }

        public void DelMovie(int id)
        {
                //Bib.Remove(Bib.Where(Movie => Movie.id == id).First());
            foreach(var Movie in Bib.ToList())
            {
                if(Movie.id == id)
                {
                    Bib.Remove(Movie);
                }
            }
        }
        public void EditMovie(int id, string newTitle)
        {
            //Bib.First(Movie => Movie.id == id).Title = newTitle;

            foreach (var Movie in Bib.ToList())
            {
                if (Movie.id == id)
                {
                    Movie.Title = newTitle;
                }
            }
        }

        public List<Movie> SearchMovie(string SearchTerm)
        {
            //List<Movie> Results = new List<Movie>(Bib.FindAll(Movie => Movie.Title.Contains(Search)));

            List<Movie> Results = new List<Movie>();

            foreach (var Movie in Bib.ToList())
            {
                if (Movie.Title.Contains(SearchTerm))
                {
                    Results.Add(Movie);
                }
            }

            return Results;
        }

    }
}
