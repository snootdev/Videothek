using System;

namespace Videothek
{
    class Programm
    {
        static void Main(string[] args)
        {
            UI _UI = new UI();
            Bibliothek _Bib = new Bibliothek();
            var userInput = "";

            _UI.SayWelcome();
                
            do
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        _UI.SayWelcome();
                        break;

                    case "1":
                        
                            _Bib.AddMovie(_UI.GetAddMovieTitle());
                            _UI.SayMovieAdded();
                        
                        break;
                 
                    case "2":
                        
                        foreach (var movie in _Bib.MovieList())
                        {
                            _UI.SayMovieList(movie.id, movie.Title);
                        }

                        break;

                    case "3":

                            _Bib.DelMovie(_UI.GetDelMovieId());                    
                            _UI.SayMovieDeleted();
                        
                        break;

                    case "4":

                        _Bib.EditMovie(_UI.GetMovieId() , _UI.GetNewMovieTitle());

                        break;

                    case "5":

                        foreach (var found in _Bib.SearchMovie(_UI.SearchMovie())) {
                            _UI.SayMovieList(found.id, found.Title);
                        }


                        break;

                }

            } while (userInput != "6");
        }

    }

}