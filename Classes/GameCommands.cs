using System;
using System.Threading;

namespace DiceShooter
{
    class GameCommands
    {
        // list of commands the player can use
        public static string[] betList = {
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
            "10 or 11",
            "clear",
            "view money"
            };

        public static void checkCommands(string command)
        {
            // takes a string as input
            // checks which command was used

            switch(command){
                case "quit": // quit the game
                    Console.Clear();
                    Console.WriteLine("Goodbye {0}", Player.getName());
                    Thread.Sleep(3000);
                    Program.endGame = true;
                    break;
                case "help": // show player the list of commands
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
                case "big": // big bet
                    Player.setMove(betList[2]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "small":
                    Player.setMove(betList[3]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "odd": // odd bet
                    Player.setMove(betList[4]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "even": // even bet
                    Player.setMove(betList[5]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 1":
                case "all 1s": // tripple bet
                    Game.setTripple(1);
                    Player.setMove(betList[6]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 2":
                case "all 2s": // tripple bet
                    Game.setTripple(2);
                    Player.setMove(betList[7]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 3":
                case "all 3s": // tripple bet
                    Game.setTripple(3);
                    Player.setMove(betList[8]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 4":
                case "all 4s": // tripple bet
                    Game.setTripple(4);
                    Player.setMove(betList[9]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 5":
                case "all 5s": // tripple bet
                    Game.setTripple(5);
                    Player.setMove(betList[10]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "all 6":
                case "all 6s": // tripple bet 
                    Game.setTripple(6);
                    Player.setMove(betList[11]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 1":
                case "double 1s": // double bet
                    Game.setDouble(1);
                    Player.setMove(betList[12]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 2":
                case "double 2s": // double bet
                    Game.setDouble(2);
                    Player.setMove(betList[13]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 3":
                case "double 3s": // double bet
                    Game.setDouble(3);
                    Player.setMove(betList[14]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 4":
                case "double 4s": // double bet
                    Game.setDouble(4);
                    Player.setMove(betList[15]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 5":
                case "double 5s": // double bet
                    Game.setDouble(5);
                    Player.setMove(betList[16]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "double 6":
                case "double 6s": // double bet
                    Game.setDouble(6);
                    Player.setMove(betList[17]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "triple":
                case "triples":
                case "any triples": // tripple bet
                    Player.setMove(betList[18]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "4":
                case "17":
                case "4 or 17": // sum 4 or 17
                    Player.setMove(betList[19]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "5":
                case "16":
                case "5 or 16": // sum 5 or 16
                    Player.setMove(betList[20]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "6":
                case "15":
                case "6 or 15": // sum 6 or 15
                    Player.setMove(betList[21]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "7":
                case "14":
                case "7 or 14": // sum 7 or 14
                    Player.setMove(betList[22]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "8":
                case "13":
                case "8 or 13": // sum 8 or 13
                    Player.setMove(betList[23]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "9":
                case "12":
                case "9 or 12": // sum 9 or 12
                    Player.setMove(betList[24]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "11":
                case "10":
                case "10 or 11": // sum 10 or 11
                    Player.setMove(betList[25]);
                    Console.WriteLine("you chose {0}", Player.getMove());
                    break;
                case "cls":
                case "clear": // clear the screen
                    Console.Clear();
                    break;
                case "balance":
                case "money":
                case "view money": // show balance
                    Console.Clear();
                    double mny = Player.getMoney();
                    Console.WriteLine("Balance: {0}", mny );
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
