using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            // More easily to understand version but slightly slower and more memory consuming (according to judge)

            int n = int.Parse(Console.ReadLine()); // This line is useless since we are always given n amount of plants
            int[] plants = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(plants.Reverse());

            int days = 0;
            while (true)
            {
                int initialCountOfPlants = plants.Length;

                for (int i = 0; i < initialCountOfPlants; i++)
                {
                    int currPlant = queue.Dequeue();

                    if (currPlant <= queue.Peek() || i == initialCountOfPlants - 1)
                    {
                        queue.Enqueue(currPlant);
                    }
                }

                if (initialCountOfPlants == plants.Length)
                {
                    break;
                }

                days++;
            }

            Console.WriteLine(days);
        }
    }
}