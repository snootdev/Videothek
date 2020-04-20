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

            _UI.WelcomeText();
                        
            do
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        _UI.WelcomeText();
                        break;

                    case "1":
                        
                            _Bib.addMovie(_UI.userInput_addMovie());
                            _UI.MovieAddedMsg();
                        
                        break;
                 
                    case "2":
                        
                        foreach (var movie in _Bib.MovieList())
                        {
                            _UI.MovieListOutput(movie.id, movie.Title);
                        }

                        break;

                    case "3":

                            _Bib.delMovie(_UI.userInput_delMovie());                    
                            _UI.MovieDeletedMsg();
                        
                        break;

                    case "4":

                        _Bib.editMovie(_UI.ui_editMovie_id(), _UI.ui_editMovie_title());

                        break;

                    case "5":

                        foreach (var found in _Bib.searchMovie(_UI.ui_searchMovie())) {
                            _UI.MovieListOutput(found.id, found.Title);
                        }


                        break;

                }




            } while (userInput != "6");
        }

    }

}