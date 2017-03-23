using System;
using System.Threading;

namespace DiceShooter
{
    class Game
    {
        // create random object
        static Random randomInt = new Random();

        // store tripple or doubles
        // used to tell which tripple or which double is being bet on
        private static int t;
        private static int d;

        // Getter and Setters for t and d
        public static int getTripple() {
            return t;
        }

        public static int getDouble()
        {
            return d;
        }

        public static void setTripple( int trpl)
        {
            t = trpl;
        }

        public static void setDouble(int dbl)
        {
            d = dbl;
        }


        static int[] diceRoll()
        {
            // roll the dice method
            int[] diceResult = { randomInt.Next(1, 7), randomInt.Next(1, 7), randomInt.Next(1, 7)};
            return diceResult;
        }

        /* Game Bets */
        public static void bigBet()
        {
            // checks for the sum to be between 4 and 10 inclusive
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum >= 11 && resultSum <= 17)
            {
                Player.setMoneyAdd(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you won the big bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the small bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void smallBet()
        {
            // checks for the sum to be between 4 and 10 inclusive
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum >= 4 && resultSum <= 10)
            {
                Player.setMoneyAdd(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you won the small bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the small bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void oddBet()
        {
            // checks for an odd sum
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum % 2 != 0)
            {
                Player.setMoneyAdd(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you won the odd bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the odd bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void evenBet()
        {
            // checks for an even sum
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum % 2 == 0)
            {
                Player.setMoneyAdd(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you won the even bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the even bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void fourOrSeventeenBet()
        {
            // checks for a 4 or an 17
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 4 || resultSum == 17)
            {
                Player.setMoneyAdd(Player.getBet() * 60);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void fiveOrSixteenBet()
        {
            // checks for a 5 or an 16
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 5 || resultSum == 16)
            {
                Player.setMoneyAdd(Player.getBet() * 30);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void sixOrfifteenBet()
        {
            // checks for a 6 or an 15
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 6 || resultSum == 15)
            {
                Player.setMoneyAdd(Player.getBet() * 18);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void sevenOrfourteenBet()
        {
            // checks for a 7 or an 14
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 7 || resultSum == 14)
            {
                Player.setMoneyAdd(Player.getBet() * 12);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void eightOrthirteenBet()
        {
            // checks for a 8 or an 13
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 8 || resultSum == 13)
            {
                Player.setMoneyAdd(Player.getBet() * 8);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void nineOrtwelveBet()
        {
            // checks for a 9 or an 12
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 9 || resultSum == 12)
            {
                Player.setMoneyAdd(Player.getBet() * 7);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void tenOrelevenBet()
        {
            // checks for a 10 or an 11
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
            int resultSum = 0;
            foreach (int result in diceResult) // sum the roll
            {
                resultSum += result;
            }
            Console.Clear();
            Console.WriteLine("the sum of the dice is: {0}", resultSum);
            Thread.Sleep(3000);
            if (resultSum == 10 || resultSum == 11)
            {
                Player.setMoneyAdd(Player.getBet() * 6);
                Console.WriteLine("CONAN: Woah dude! you won the three dice total bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the three dice total bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void specificTrippleBet(int t)
        {
            // Checks for a specific set of tripples. takes an integer refuring to which tripple to check for
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();
           
            Console.Clear();
        
            Thread.Sleep(3000);
            if (diceResult[0] == t && diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoneyAdd(Player.getBet() * 180);
                Console.WriteLine("CONAN: Woah dude! you won the tripple bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the tripples bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void anyTrippleBet()
        {
            // Checks for tripples
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();

            Console.Clear();

            Thread.Sleep(3000);
            if (diceResult[0] == diceResult[1] && diceResult[0] == diceResult[2])
            {
                Player.setMoneyAdd(Player.getBet() * 30);
                Console.WriteLine("CONAN: Woah dude! you won the tripple bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the tripples bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }

        public static void specificDoubleBet(int d)
        {
            // Checks for a specific set of doubles. takes an integer refuring to which double to check for
            /*Rolls the dice. Checks for a win or loose. Informs the player accordingly. Adds or subtracts money from player  */
            int[] diceResult = diceRoll();

            Console.Clear();

            Thread.Sleep(3000);
            if (diceResult[0] == d && diceResult[0] == diceResult[1] || diceResult[0] == d && diceResult[0] == diceResult[2] || diceResult[1] == d && diceResult[1] == diceResult[2])
            {
                Player.setMoneyAdd(Player.getBet() * 10);
                Console.WriteLine("CONAN: Woah dude! you won the doubles bet!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
            else
            {
                Player.setMoneySub(Player.getBet());
                Console.WriteLine("CONAN: Woah dude! you Lost the doubles bet! ahahahahaha");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Your money: {0}", Player.getMoney());
            }
        }




    }
}
