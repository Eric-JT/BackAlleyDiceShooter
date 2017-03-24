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


        public static double getBetAmount(string s) {
            // Check that player enterd a valid number
            // if an invalid number is entered all remaining money is bet
            double userInput = 0;

            try {

                // if the input fails to parse to a double jump down to catch
                userInput = double.Parse(s);

                // check if bet is valid
                while (userInput < 0 || userInput > Player.getMoney()) {
                    // if bet is not valid inform the player and ask for bet again
        
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CONAN: Invalid Bet!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("CONAN: Hey buddy, enter a valid bet.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine(Player.getMoney());
                    Console.Write("Bet: ");

                    Player.setBet(GameManager.getBetAmount(Console.ReadLine()));
                    // if the following line is not included the bet amount is reset to 0
                    // a total pain to figure out what was wrong
                    userInput = Player.getBet(); // store the bet amount in a variable to be returned
                    break;
                }
       
            }
            catch {
                // If the Parse fails then turn the string into an array of bytes
                // check bytes values to see if they are numbers or not
                // Penalty the user
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
                        userInput = Player.getMoney(); // bet all the players money
                        break;
                    }
                }
                
            }

            
            return userInput;

        }


        public static string continueGame() {
            string continueGame = "";

            while (continueGame != "y" || continueGame != "n") {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Would you like to conintue?");
                Console.Write("enter \'y\' or \'n\' ");
                Console.ResetColor();
                continueGame = Console.ReadLine();
                if (continueGame == "y" || continueGame == "n") {
                    Player.resetMoney();
                    break;
                }
            }

            return continueGame;
        }
    }
}
