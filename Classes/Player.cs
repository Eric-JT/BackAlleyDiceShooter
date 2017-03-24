
namespace DiceShooter
{
    class Player
    {
        
        // player money
        private static double playerMoney;
        
        // player name
        private static string playerName;

        // player bet amount
        private static double betAmount;

        // player move
        private static string move = "";


        public Player(string pName, double pMoney = 200000)
        {
            playerName = pName;
            playerMoney = pMoney;
        }

        /* Getter Methods */
        public static string getName()
        {
            return playerName;
        }

        public static double getBet()
        {
            return betAmount;
        }

        public static double getMoney()
        {
            return playerMoney;
        }

        public static string getMove()
        {
            return move;
        }


        /* Setter Methods */
        public static void resetMoney() {
            playerMoney = 200;
        }

        public static void setMoneyAdd(double betAmount) {
            playerMoney += betAmount;
        }

        public static void setMoneySub(double betAmount)
        {
            playerMoney -= betAmount;
        }
        

        public static void setBet(double bet)
        {
            betAmount = bet;
        }

        public static void setMove(string m)
        {
            move = m;
        }

    }  
}

