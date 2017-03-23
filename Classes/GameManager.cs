using System;
using System.Text;
using System.Threading;


namespace DiceShooter
{
    class GameManager
    {
        public static string pName;

        public static void showTitleScreen()
        {
            /* Show the title screen */
            Console.Clear();
            Console.WriteLine("\t-------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tBack Alley Dice Shooter");
            Console.WriteLine("\t-------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("\nYour host for the evening is Conan O'Brian!");
            Thread.Sleep(3000);
            Console.Clear();
        }


        public static void showEndScreen()
        {
            /* Show the end screen */
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("Thank You for playing");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\t-------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tBack Alley Dice Shooter");
            Console.WriteLine("\t-------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Created by Eric Trotchie");
            Thread.Sleep(3000);
        }


        public static void startGame() {
            /* Start the game */
            pName = GameHost.askPlayerName();
            Player player = new Player(pName);
            GameHost.greetPlayer();
        }

        public static bool checkWin()
        {
            /* Check for game win */
            if (Player.getMoney() >= 100000) {
                return true;
            }
            return false;
        }

        public static bool checkLose() {
            /* Check for the game loose */
            if (Player.getMoney() <= 0) {
                return true;
            }
            return false;
        }


        public static double checkIfNumber(string s) {
            // Check that player enterd a valid number
            // if an invalid number is entered all remaining money is bet
            double userInput = 0;

            try {
                userInput = double.Parse(s);
                
                // fix the input BS

            }
            catch {
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                foreach (char c in bytes) {
                    if (c <= 48 || c >= 57) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("CONAN: That is not a Number!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.Write("CONAN: Just for screwing around your bet is {0}", Player.getMoney());
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ResetColor();
                        Console.WriteLine("CONAN: I am only kidding. Enter a valid bet");
                        Thread.Sleep(2000);
                        break;
                    }
                }
                
            }


            return userInput;

        }
    }
}
