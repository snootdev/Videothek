using System;

namespace Videothek
{
    class UI
    {
        public void WelcomeText()
        {
            Console.WriteLine("Welcome to the administration of your video store");
            Console.WriteLine("You can choose the following actions:");
            Console.WriteLine("1) Add Movie");
            Console.WriteLine("2) Show All Movies");
            Console.WriteLine("3) Delete Movie");
            Console.WriteLine("4) Exit");
        }

        public string userInput_addMovie()
        {
            Console.WriteLine("Whats the Movie Title?");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public int userInput_delMovie()
        {
            Console.WriteLine("Whats the Movie's ID you want to delete?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public void MovieAddedMsg()
        {
            Console.WriteLine("Movie added.");
            Console.WriteLine("------------");
        }

        public void MovieDeletedMsg()
        {
            Console.WriteLine("Movie deleted.");
            Console.WriteLine("------------");
        }

        public void MovieListOutput(int id, string Title)
        {
                Console.WriteLine("ID: {0}", id);
                Console.WriteLine("Movietitle: {0}", Title);
                Console.WriteLine("------------");
                Console.WriteLine(" ");           

        }

    }
}
