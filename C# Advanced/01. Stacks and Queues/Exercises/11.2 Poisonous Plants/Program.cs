using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // This line is useless since we are always given n amount of plants
            int[] plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] days = new int[n]; // n = plants.Length

            Stack<int> indexes = new Stack<int>();
            indexes.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;

                while (indexes.Count > 0 && plants[indexes.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[indexes.Pop()]);
                }

                if (indexes.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                indexes.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}