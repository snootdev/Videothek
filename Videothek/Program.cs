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
            Bibliothek _Bib = new Bibliothek();
            var userInput = "";

            _UI.WelcomeText();
                        
            do
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                            _Bib.addMovie();
                        break;
                 
                    case "2":
                            _Bib.showMovieList();
                       
                        break;
                }


            } while (userInput != "3");
        }

    }

}
