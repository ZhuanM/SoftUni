using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Number_Wars
{
    class Program
    {
        const int MaxCounter = 1_000_000; // 1_000_000 = 1000000 = 1 000 000 (but can't use spaces obviously)

        static void Main(string[] args)
        {
            Queue<string> firstAllCards = new Queue<string>(Console.ReadLine().Split());
            Queue<string> secondAllCards = new Queue<string>(Console.ReadLine().Split());

            int turnCounter = 0;
            bool gameOver = false;
            while (turnCounter < MaxCounter && firstAllCards.Count > 0 && secondAllCards.Count > 0 && !gameOver) // 1_000_000 = 1000000
            {
                turnCounter++;

                string firstCard = firstAllCards.Dequeue();
                string secondCard = secondAllCards.Dequeue();

                if (GetNumber(firstCard) > GetNumber(secondCard))
                {
                    firstAllCards.Enqueue(firstCard);
                    firstAllCards.Enqueue(secondCard);
                }
                else if (GetNumber(firstCard) < GetNumber(secondCard))
                {
                    secondAllCards.Enqueue(secondCard);
                    secondAllCards.Enqueue(firstCard);
                }
                else
                {
                    List<string> cardsHand = new List<string> { firstCard, secondCard };
                    while (!gameOver)
                    {
                        if (firstAllCards.Count >= 3 && secondAllCards.Count >= 3)
                        {
                            int firstSum = 0;
                            int secondSum = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                string firstHandCard = firstAllCards.Dequeue();
                                string secondHandCard = secondAllCards.Dequeue();

                                firstSum += GetChar(firstHandCard);
                                secondSum += GetChar(secondHandCard);

                                cardsHand.Add(firstHandCard);
                                cardsHand.Add(secondHandCard);
                            }

                            if (firstSum > secondSum)
                            {
                                AddCardsToWinner(cardsHand, firstAllCards);
                                break;
                            }
                            else if (firstSum < secondSum)
                            {
                                AddCardsToWinner(cardsHand, secondAllCards);
                                break;
                            }

                        }
                        else
                        {
                            gameOver = true;
                        }
                    }
                }
            }

            string result = "";
            if (firstAllCards.Count == secondAllCards.Count)
            {
                result = "Draw";
            }
            else if (firstAllCards.Count > secondAllCards.Count)
            {
                result = "First player wins";
            }
            else
            {
                result = "Second player wins";
            }

            Console.WriteLine($"{result} after {turnCounter} turns");
        }

        private static void AddCardsToWinner(List<string> cardsHand, Queue<string> firstAllCards)
        {
            foreach (var card in cardsHand.OrderByDescending(c => GetNumber(c)).ThenByDescending(c => GetChar(c)))
            {
                firstAllCards.Enqueue(card);
            }
        }

        static int GetNumber(string card)
        {
            return int.Parse(card.Substring(0, card.Length - 1));
        }

        static int GetChar(string card)
        {
            return card[card.Length - 1];
        }
    }
}