using System;
using System.Threading;

namespace DiceShooter
{
    class GameCommands
    {
        static string[] betList = {
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
                    foreach (string bet in betList) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" {0} ", bet);
                        Console.ResetColor();
                        Console.Write("-");
                    } 
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