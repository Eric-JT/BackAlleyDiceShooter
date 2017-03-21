
using System;
using System.Threading;


namespace DiceShooter{

    class GameHost{

        // store host name
        public string hostName = "Conan";
        
        
        // ask player questions
        
        public static string askPlayerName()
        {
            /* Get the players name */
            Console.WriteLine("CONAN: Hey buddy, what is your name:");
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

        // ask player questions about the game
        
        public static void playerLost()
        {
            // tell the player he lost
            Console.WriteLine("CONAN: You are broke as a joke.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("CONAN: Goodbye Loser");
            Thread.Sleep(2000);
            Console.Clear();
        }
        

        public static void playerWins()
        {
            // tell the player he won
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
        
        // give the player help
    }
}