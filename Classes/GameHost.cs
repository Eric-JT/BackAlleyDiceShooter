
using System;
using System.Threading;


namespace DiceShooter{

    class GameHost{

        
        
        public static string askPlayerName()
        {
            /* Get the players name */
            Console.WriteLine("CONAN: Hey buddy, what is your name?");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Enter your name: ");
            string pName = Console.ReadLine();
            return pName;
        }

        public static void greetPlayer()
        {
            /* Greet the player */
            Console.WriteLine("CONAN: Hello {0}, I hope you are ready to lose all your money!", Player.getName() );
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("CONAN: *Sinister Laugh*");
            Thread.Sleep(2000);
            Console.Clear();
        }

       
        
        public static void playerLost()
        {
            // tell the player he lost the game
            Console.WriteLine("CONAN: You are broke as a joke.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("CONAN: Goodbye Loser");
            Thread.Sleep(2000);
            Console.Clear();
        }
        

        public static void playerWins()
        {
            // tell the player he won the game
            Console.Clear();
            Console.WriteLine("CONAN: Whoa dude! You have too much money.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("CONAN: You have to leave.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("CONAN: Take your ${0} with you", Player.getMoney());
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void askForBet() {
            // asks for the bet
            Console.Write("CONAN: How much are you betting?");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Enter bet ammount: ");
        }

        public static double getBetAmount(double betAmount) {
            // Pass in input from the user
            // returns a double
            // check if bet is valid

            // check if bet is valid
            while (betAmount < 0 || betAmount > Player.getMoney()) {
                // if bet is not valid inform the player and ask for bet again
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Bet!");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("CONAN: Hey buddy, enter a valid bet.");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(Player.getMoney());
                Console.WriteLine("Bet: ");
                Player.setBet(GameHost.getBetAmount(GameManager.checkIfNumber(Console.ReadLine())));
            }

            Console.Clear();
            Console.WriteLine("CONAN: Thanks for your bet buddy");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("CONAN: Your bet is {0}", betAmount);
            return betAmount;
        }

      
    }
}
