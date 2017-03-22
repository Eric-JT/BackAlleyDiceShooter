using System;

namespace DiceShooter
{
    class Program
    {
        public static Boolean endGame = false;
        static void Main(string[] args)
        {
            GameManager.showTitleScreen();

            GameManager.startGame();


            while (!endGame) {
                if (GameManager.checkLose()){
                    GameHost.playerLost();
                    GameManager.showEndScreen();
                    endGame = true;
                    break;
                }
                else if (GameManager.checkWin()){
                    GameHost.playerWins();
                    GameManager.showEndScreen();
                    endGame = true;
                    break;
                } else{
                    Console.Write("\nEnter your command: ");
                    GameCommands.checkCommands(Console.ReadLine());
                }
            }
        }
    }
}
