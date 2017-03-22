using System;
using System.Threading;

namespace DiceShooter
{
    class GameCommands
    {

        public static void checkCommands(string command)
        {
            
            switch(command){
                case "quit":
                    Console.Clear();
                    Console.WriteLine("Goodbye {0}", Player.getName());
                    Thread.Sleep(3000);
                    Program.endGame = true;
                    break;
                case "help":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("List of valid commands");
                    Console.WriteLine("----------------------");
                    foreach (string bet in Player.betList) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" {0} ", bet);
                        Console.ResetColor();
                        Console.Write("-");
                    } 
                    Console.ResetColor();
                    break;
                case "big":
                    Player.move = Player.betList[0];
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
    }
}