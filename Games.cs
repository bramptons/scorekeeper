using System;

namespace scorekeeper
{
    public class Games
    {
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public int winningScore;
        public string playerOne;
        public string playerTwo;
        static public string gameType;
        public string gameTitle;
        public bool status;

        public Games(string gameTypeSet){
            switch(gameTypeSet){
                case "Squash":
                winningScore = 15;
                break;
            }
            
        }

        //create separate methods for textual ackonlwedgement of score informing in a human manner
        public void WinPoint(string won)
        {
            if(won == playerOne)
            {
                playerOneScore++;
                if(playerOneScore == winningScore){
                    status = true;
                    Console.WriteLine(playerOne + " Wins!");
                }
            }
            else{
                playerTwoScore++;
                if(playerTwoScore == winningScore){
                    status = true;
                    Console.WriteLine(playerTwo + " Wins!");
                }
            }
        }
        private void ClearPoints()
        {
            string almostWon = $"Win by two clear points! C'mon {0} don't throw it away";
            if(playerOneScore == winningScore){
                if(playerTwoScore == winningScore-1){
                    Console.WriteLine(string.Format(almostWon, playerOne));
                }
                else{
                    if(playerTwoScore < winningScore-1){
                        status = true;
                        Console.WriteLine(playerOne + " Wins!");
                    }
                }
            }
            else{
                if(playerTwoScore == winningScore){
                    if(playerOneScore == winningScore -1){
                        Console.WriteLine(string.Format(almostWon, playerTwo));
                    }
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