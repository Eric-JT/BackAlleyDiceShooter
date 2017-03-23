using System;

namespace DiceShooter
{
    class Program
    {

        public static Boolean endGame = false;
        static void Main(string[] args)
        {

            // Show the title screen
            GameManager.showTitleScreen();

            // start the game
            GameManager.startGame();


            // main game loop
            while (!endGame) {
                if (GameManager.checkLose()){ // check for a game lose
                    GameHost.playerLost();
                    endGame = true;
                    break;
                }
                else if (GameManager.checkWin()){ // check for a game win
                    GameHost.playerWins();
                    endGame = true;
                    break;
                } else{ // continue the game
                    Console.WriteLine("CONAN: If you need help, just ask ");
                    Console.Write("\nEnter your command: ");
                    GameCommands.checkCommands(Console.ReadLine()); // get the command from the user

                    if (Player.getMove() != GameCommands.betList[0] || Player.getMove() != GameCommands.betList[1]) // check if the command is a bet or not
                    {
                        foreach (string bet in GameCommands.betList)
                            // if the command is a bet check which bet it is and run the game for that bet
                            if (Player.getMove() == bet)
                            {
                                GameHost.askForBet();
                                
                                Player.setBet(GameManager.getBetAmount(Console.ReadLine()));
                                switch (Player.getMove()) {
                                    case "big":
                                        Game.bigBet();
                                        break;
                                   case "small":
                                        Game.smallBet();
                                        break;
                                    case "odd":
                                        Game.oddBet();
                                        break;
                                    case "even":
                                        Game.evenBet();
                                        break;
                                    case "all 1s":
                                    case "all 2s":
                                    case "all 3s":
                                    case "all 4s":
                                    case "all 5s":
                                    case "all 6s":
                                        Game.specificTrippleBet(Game.getTripple());
                                        break;
                                    case "double 1s":
                                    case "double 2s":
                                    case "double 3s":
                                    case "double 4s":
                                    case "double 5s":
                                    case "double 6s":
                                        Game.specificDoubleBet(Game.getDouble());
                                        break;

                                    case "any triples":
                                        Game.anyTrippleBet();
                                        break;
                                    case "4 or 17":
                                        Game.fourOrSeventeenBet();
                                        break;
                                    case "5 or 16":
                                        Game.fiveOrSixteenBet();
                                        break;

                                    case "6 or 15":
                                        Game.sixOrfifteenBet();
                                        break;

                                    case "7 or 14":
                                        Game.sevenOrfourteenBet();
                                        break;
                                    case "8 or 13":
                                        Game.eightOrthirteenBet();
                                        break;
                                    case "9 or 12":
                                        Game.nineOrtwelveBet();
                                        break;
                                    case "10 or 11":
                                        Game.tenOrelevenBet();
                                        break;

                                }
                            }
                    }

                    // reset the player move
                    Player.setMove("");
                    // reset the tripple
                    Game.setTripple(0);
                }
            }
            // show ending credits
            GameManager.showEndScreen();
        }
    }
}
