using System;

namespace scorekeeper
{
    public class Games
    {
        static int[,] score = new int[2,15];
        private int x = 0;
        public string playerOne;
        public string playerTwo;
        public string gameTitle;

        public void WinPoint(string won)
        {
            if(won == playerOne)
            {
                score[0,x] = 1;
            }
            else{
                score[1,x] = 1;
            }
            x++;
        }
        public void LosePoint(string lose)
        {
            if(lose == playerOne)
            {
                score[0,x] = 0;
            }
            else{
                score[1,x] = 0;
            }
            x++;
        }

        public void PointTally()
        {
            int x = score.Length;
            int y = 0;
            int z = 0;
            while(z<x){
                int playerOneScore + score[y,z];
            }
        }

        private void AddLeaderboard()
        {
            //write each score to to individual row
            //write two rows to another table - one with win one with loss
        }
    }
}