using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreenLight = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Queue<string> carsQueue = new Queue<string>();
            int carsThatPassed = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsThatCanPass = Math.Min(carsPerGreenLight, carsQueue.Count);
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsThatPassed++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{carsThatPassed} cars passed the crossroads.");
        }
    }
}