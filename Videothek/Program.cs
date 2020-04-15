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
                }


            } while (userInput != "4");
        }

    }

}