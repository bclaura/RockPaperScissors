using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static int playerAWins = 0;
        static int playerBWins = 0;
        static int roundsPlayed = 0;

        public class NewMethod
        {
            public void StartGame()
            {
                playerAWins = 0;
                playerBWins = 0;
                roundsPlayed = 0;
                var RockPaperScissors = new List<string>() { "rock", "paper", "scissors" };
                var consecutiveWinsA = 0;
                var consecutiveWinsB = 0;
                Console.WriteLine("Enter the number of rounds: ");
                int rounds = int.Parse(Console.ReadLine());
                var roundedNums = (int)((rounds / 2) + 0.5);
                while (rounds % 2 == 0)
                {
                    Console.WriteLine("Wrong number, please enter an odd number: ");
                    rounds = int.Parse(Console.ReadLine());
                }
                Random rnd = new Random();
                while (roundsPlayed < rounds)
                {
                    var playerAChoice = RockPaperScissors[rnd.Next(RockPaperScissors.Count)];
                    Console.Write("*****Player A chooses: " + playerAChoice + "\n");
                    var playerBChoice = RockPaperScissors[rnd.Next(RockPaperScissors.Count)];
                    Console.Write("*****Player B chooses: " + playerBChoice + "\n");
                    if (playerAChoice.ToString() == "rock")
                    {
                        if (playerBChoice.ToString() == "rock")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerBChoice.ToString() == "paper")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                        else if (playerBChoice.ToString() == "scissors")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                    }
                    else if (playerBChoice.ToString() == "rock")
                    {
                        if (playerAChoice.ToString() == "rock")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerAChoice.ToString() == "paper")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                        else if (playerAChoice.ToString() == "scissors")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                    }
                    else if (playerAChoice.ToString() == "paper")
                    {
                        if (playerBChoice.ToString() == "paper")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerBChoice.ToString() == "rock")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                        else if (playerBChoice.ToString() == "scissors")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                    }
                    else if (playerBChoice.ToString() == "paper")
                    {
                        if (playerAChoice.ToString() == "paper")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerAChoice.ToString() == "rock")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                        else if (playerAChoice.ToString() == "scissors")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                    }
                    else if (playerAChoice.ToString() == "scissors")
                    {
                        if (playerBChoice.ToString() == "scissors")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerBChoice.ToString() == "paper")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                        else if (playerBChoice.ToString() == "rock")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                    }
                    else if (playerBChoice.ToString() == "scissors")
                    {
                        if (playerAChoice.ToString() == "scissors")
                        {
                            Console.WriteLine("DRAW");
                        }
                        else if (playerAChoice.ToString() == "rock")
                        {
                            playerAWins++;
                            consecutiveWinsA++;
                            Console.WriteLine("PlayerA wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsA > roundedNums)
                            {
                                Console.WriteLine("PlayerA has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsA = 0;
                            }
                        }
                        else if (playerAChoice.ToString() == "paper")
                        {
                            playerBWins++;
                            consecutiveWinsB++;
                            Console.WriteLine("PlayerB wins this round ");
                            roundsPlayed++;
                            if (consecutiveWinsB > roundedNums)
                            {
                                Console.WriteLine("PlayerB has won the game ");
                                break;
                            }
                            else
                            {
                                consecutiveWinsB = 0;
                            }
                        }
                    }
                }
                if (playerAWins > playerBWins)
                {
                    Console.WriteLine("Game has ended. Player A has won the game");
                }
                if (playerBWins > playerAWins)
                {
                    Console.WriteLine("Game has ended. Player B has won the game");
                }
                if (playerAWins == playerBWins)
                {
                    Console.WriteLine("It's a tie! Play again.");
                }

            }

            public void Score()
            {
                {
                    Console.WriteLine("PlayerA score is: " + playerAWins + "p");
                    Console.WriteLine("PlayerB score is: " + playerBWins + "p");
                }
            }

            static void Main(string[] args)
            {

                var refObj = new NewMethod();
                while (true)
                {
                    Console.WriteLine("Enter 'start' to start a game or 'score' to check the score");
                    string command = Console.ReadLine().ToLower();
                    if (command == "start")
                    {
                        refObj.StartGame();
                    }
                    else if (command == "score")
                    {
                        refObj.Score();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command");
                    }
                }

            }
        }
    }
}
