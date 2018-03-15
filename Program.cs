using System;

namespace scorekeeper
{
    class Program
    {
        public static int players;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }

        private void NewGame(string game, string title)
        {
            //you need to enter something to switch between game types
            Games games = new Games();

            //set the number of players
            players = 2;
            games.playerOne = Console.ReadLine();
            games.playerTwo = Console.ReadLine();
            games.gameTitle = title;
        }
    }
}
