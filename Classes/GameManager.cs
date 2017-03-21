using System;
using System.Threading;


namespace DiceShooter
{
    class GameManager
    {
        public static  string pName;

        public static void showTitleScreen()
        {
            /* Show the title screen */
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tBack Alley Dice Shooter");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
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
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tBack Alley Dice Shooter");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Created by Eric Trotchie");
            Thread.Sleep(3);
        }


        public static void startGame(){
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

        public static bool checkLose(){
            /* Check for the game loose */
            if (Player.getMoney() <= 0) {
                return true;
            }
            return false;
        }

        /* Apply rules */
    }
}