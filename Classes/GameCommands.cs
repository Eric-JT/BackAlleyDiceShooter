using System;
using System.Threading;

namespace DiceShooter
{
    static class GameCommands
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("quit - help\n");
                    Console.ResetColor();
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