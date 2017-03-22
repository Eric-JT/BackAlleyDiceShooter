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

        // player bet amount
        public static double betAmount;

        // player move
        public static string move = "";

        public static string[] betList = {
            "help",
            "quit",
            "big",
            "small",
            "odd",
            "even",
            "all 1s",
            "all 2s",
            "all 3s",
            "all 4s",
            "all 5s",
            "all 6s",
            "double 1s",
            "double 2s",
            "double 3s",
            "double 4s",
            "double 5s",
            "double 6s",
            "any triples",
            "4 or 17",
            "5 or 16",
            "6 or 15",
            "7 or 14",
            "8 or 13",
            "9 or 12",
            "10 or 11"
            };

        public Player(string pName, double pMoney = 200, int pScore = 0)
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

        public static double getBet(){
            return betAmount;
        }

        public static string getMove(){
            return move;
        }
 
    }  
}

