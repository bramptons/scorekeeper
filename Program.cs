using System;

namespace scorekeeper
{
    class Program
    {
        public static int players;        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Pick a game: \n1 - Squash");
            
            int caseSwitch = Convert.ToInt16(Console.ReadLine()) ;
            switch(caseSwitch){
                case 1: 
                    Console.WriteLine("You have choosen squash.\nGive your game a name");
                    string gameTitle = Console.ReadLine();
                    NewGame("Squash", gameTitle);
                break;
                default:
                break;
            }
        }

        private static void NewGame(string gameType, string title)
        {
            //you need to enter something to switch between game types
            Games game = new Games(gameType);
            //game.gameType = gameType;
            //set the number of players
            players = 2;
            Console.WriteLine("Player one name:");
            game.playerOne = Console.ReadLine();
            Console.WriteLine("Player two name:");
            game.playerTwo = Console.ReadLine();
            game.gameTitle = title;

            Console.WriteLine("Start the game?\nY or n");
            char confirm = Convert.ToChar(Console.ReadLine());

            if(confirm == 'Y'){
                game.status = false;
                RunGame(game);
            }            
        }

        static void RunGame(Games runningGame)
        {
            
            while(runningGame.status == false){
                Console.WriteLine($"Who won the point?\n{runningGame.playerOne} enter: A\n{runningGame.playerTwo} enter: B");
                Console.WriteLine($"Or who lost a point?\n{runningGame.playerOne} enter: C\n{runningGame.playerTwo} enter: D\n");
                
                char pointWon = Convert.ToChar(Console.ReadLine());
                switch(pointWon){
                    case 'A':
                        //add voice control options for point adding
                        runningGame.WinPoint(runningGame.playerOne);
                    break;
                    case 'B':
                        runningGame.WinPoint(runningGame.playerTwo);
                    break;
                    case 'C':
                        runningGame.LosePoint(runningGame.playerOne);
                        break;
                    case 'D':
                        runningGame.LosePoint(runningGame.playerTwo);
                        break;
                    default:
                    break;
                }
                //demonstrating getting the score after each point won.
                Console.WriteLine($"Current score\n{runningGame.playerOne}:\t{runningGame.playerOneScore}\n{runningGame.playerTwo}:\t{runningGame.playerTwoScore}");
            }
            Console.WriteLine("Write your result to the leaderboard?");
            if(Convert.ToChar(Console.ReadLine()) == 'Y')
            runningGame.AddLeaderboard();
            else
            Console.WriteLine("Bye");
        }
    }
}
