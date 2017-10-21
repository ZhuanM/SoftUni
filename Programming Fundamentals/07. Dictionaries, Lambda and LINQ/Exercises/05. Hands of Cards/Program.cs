using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playerAndCards = new Dictionary<string, List<string>>();
            Dictionary<string, int> playerPoints = new Dictionary<string, int>();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(':').ToList();

                if (command[0] == "JOKER")
                {
                    break;
                }
                else
                {
                    if (playerAndCards.ContainsKey(command[0]))
                    {
                        playerAndCards[command[0]].AddRange(command[1].Split(' ', ',').ToList());
                    }
                    else
                    {
                        playerAndCards[command[0]] = command[1].Split(' ', ',').ToList();
                    }

                    playerAndCards[command[0]] = playerAndCards[command[0]].Distinct().ToList();
                }
            }

            foreach (var kvp in playerAndCards)
            {
                int points = 0;

                foreach (var card in kvp.Value)
                {
                    if (card.StartsWith("2"))
                    {
                        points += 2;
                    }
                    else if (card.StartsWith("3"))
                    {
                        points += 3;
                    }
                    else if (card.StartsWith("4"))
                    {
                        points += 4;
                    }
                    else if (card.StartsWith("5"))
                    {
                        points += 5;
                    }
                    else if (card.StartsWith("6"))
                    {
                        points += 6;
                    }
                    else if (card.StartsWith("7"))
                    {
                        points += 7;
                    }
                    else if (card.StartsWith("8"))
                    {
                        points += 8;
                    }
                    else if (card.StartsWith("9"))
                    {
                        points += 9;
                    }
                    else if (card.StartsWith("10"))
                    {
                        points += 10;
                    }
                    else if (card.StartsWith("J"))
                    {
                        points += 11;
                    }
                    else if (card.StartsWith("Q"))
                    {
                        points += 12;
                    }
                    else if (card.StartsWith("K"))
                    {
                        points += 13;
                    }
                    else if (card.StartsWith("A"))
                    {
                        points += 14;
                    }
                    ////
                    if (card.EndsWith("S"))
                    {
                        points *= 4;
                    }
                    else if (card.EndsWith("H"))
                    {
                        points *= 3;
                    }
                    else if (card.EndsWith("D"))
                    {
                        points *= 2;
                    }
                    else if (card.EndsWith("C"))
                    {
                        points *= 1;
                    }
                    ////
                    if (!playerPoints.ContainsKey(kvp.Key))
                    {
                        playerPoints[kvp.Key] = points;
                    }
                    else
                    {
                        playerPoints[kvp.Key] += points;
                    }

                    points = 0;
                }
            }

            foreach (KeyValuePair<string, int> kvp in playerPoints)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}