using System;

namespace Videothek
{
    class UI
    {
        /// <summary>
        /// 
        /// Say* Funktionen schreiben in die Console
        /// 
        /// </summary>
        
        public void SayWelcome()
        {
            Console.WriteLine("Welcome to the administration of your video store");
            Console.WriteLine("You can choose the following actions:");
            Console.WriteLine("0) Show this Menu");
            Console.WriteLine("1) Add Movie");
            Console.WriteLine("2) Show All Movies");
            Console.WriteLine("3) Delete Movie");
            Console.WriteLine("4) Edit Movietitle per ID");
            Console.WriteLine("5) Search a Movie");
            Console.WriteLine("6) Exit");
        }

        public void SayMovieAdded()
        {
            Console.WriteLine("Movie added.");
            Console.WriteLine("------------");
        }

        public void SayMovieDeleted()
        {
            Console.WriteLine("Movie deleted.");
            Console.WriteLine("------------");
        }

        public void SayMovieList(int id, string Title)
        {
                Console.WriteLine("ID: {0}", id);
                Console.WriteLine("Movietitle: {0}", Title);
                Console.WriteLine("------------");
                Console.WriteLine(" ");           
        }


        /// <summary>
        /// 
        /// Folgende Funktionen fragen die Eingabe des Benutzers ab und gibt die Eingabe zurück
        /// 
        /// </summary>


        public string GetAddMovieTitle()
        {
            Console.WriteLine("Whats the Movie Title?");
            return GetStringUserInput();
        }

        public int GetDelMovieId()
        {
            Console.WriteLine("Whats the Movie's ID you want to delete?");
            return GetIntUserInput();
        }
        public int GetMovieId()
        {
            Console.WriteLine("Whats the Movie's ID you want to edit?");
            return GetIntUserInput();
        }

        public string GetNewMovieTitle()
        {
            Console.WriteLine("Whats the new Title of the Movie?");
            return GetStringUserInput();
        }

        public string SearchMovie()
        {
            Console.WriteLine("Whats the Title of the Movie?");
            return GetStringUserInput();
        }

        /// <summary>
        /// 
        /// Funktionen um den UserInput abzufragen
        /// 
        /// </summary>

        public int GetIntUserInput()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public string GetStringUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
