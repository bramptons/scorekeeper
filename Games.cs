using System;

namespace scorekeeper
{
    public class Games
    {
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public int winningScore = 15;
        public string playerOne;
        public string playerTwo;
        static public string gameType;
        public string gameTitle;
        public bool status;
        bool clrPoints;

        public Games(string gameTypeSet){
            switch(gameTypeSet){
                case "Squash":
                Console.WriteLine("What's the winning score?");      
                winningScore = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Win by two clear points?");
                char confirm = Convert.ToChar(Console.ReadLine());
                if(confirm == 'Y')
                clrPoints = true;
                else
                clrPoints = false;
                break;
            }            
        }
        //create separate methods for textual ackonlwedgement of score informing in a human manner
        public void WinPoint(string won)
        {
            if(won == playerOne)
            {
                playerOneScore++;
                ClearPoints();
            }
            else{
                playerTwoScore++;                
                ClearPoints();
            }
        }
        
        public void LosePoint(string lost)
        {
            if(lost == playerOne)
            {
                playerOneScore--;
            }
            else{
                playerTwoScore--;
            }
        }
        private void ClearPoints()
        {
            string winner = "{0} Wins with {1} to {2}, better luck neXt time {3}";

            if(clrPoints)
            {
                if((playerOneScore >= winningScore)||(playerTwoScore >= winningScore))
                {
                    if(playerOneScore > playerTwoScore+1)
                    {
                        status = true;
                        Console.WriteLine(string.Format(winner, playerOne, playerOneScore, playerTwoScore, playerTwo));                        
                    }
                    else
                    {
                        if(playerTwoScore > playerOneScore+1)
                        {
                            status = true;                            
                            Console.WriteLine(string.Format(winner, playerTwo, playerTwoScore, playerOneScore, playerOne));
                        }
                        else                        
                            Console.WriteLine("You have to win by two clear points, keep it up!");                        
                    }
                }                
            }
            else
            {
                //stanard first to 15 score logic goes here
                if((playerOneScore == winningScore)||(playerTwoScore == winningScore))
                {
                    status = true;
                    if(playerOneScore == winningScore)
                    Console.WriteLine(playerOne + "Wins!");
                    else
                    Console.WriteLine(playerTwo + "Wins!");
                }                
            }            
        }
        public void LosePoint(string lose)
        {
            if(lose == playerOne)
            {
                playerOneScore--;
            }
            else{
                playerTwoScore--;
            }
        }

        public void AddLeaderboard()
        {
            //write to cloud
            Console.WriteLine("sending your data to the cloud");

        }
    }
}