/* Information about the player is stored */
using System;

namespace DiceShooter
{
    class Player
    {
        // Player score
        public static int playerScore;
        // player money
        public static double playerMoney;
        // player name
        public static string playerName;

        // player move

        public Player(string pName, double pMoney = 200000, int pScore = 0)
        {
            playerName = pName;
            playerScore = pScore;
            playerMoney = pMoney;
        }

        /* Get Methods */
        public static string getName()
        {
            return playerName;
        }

        public static int getScore()
        {
            return playerScore;
        }

        public static double getMoney()
        {
            return playerMoney;
        }

 
    }  
}

