using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videothek
{
    class UI
    {
        public void WelcomeText()
        {
            Console.WriteLine("Welcome to the administration of your video store");
            Console.WriteLine("You can choose  the following actions:");
            Console.WriteLine("1) Add Movie");
            Console.WriteLine("2) Show All Movies");
            Console.WriteLine("3) Exit");
        }

        public string AskForMovieTitle()
        {
            Console.WriteLine("Whats the Movie Title?");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public void MovieAddedMsg()
        {
            Console.WriteLine("Movie added.");
            Console.WriteLine("------------");
        }

        public void ShowMovie(int id, string Title)
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Movietitle: {0}", Title);
            Console.WriteLine("------------");
            Console.WriteLine(" ");
        }

    }
}
