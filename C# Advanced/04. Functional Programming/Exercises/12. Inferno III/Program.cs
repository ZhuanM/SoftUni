using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inferno_III
{
    class Program
    {
        public static void Main()
        {
            var gems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ExecuteCommands(gems);

            Console.WriteLine(string.Join(" ", gems));
        }

        private static void ExecuteCommands(List<int> gems)
        {
            string[] input = Console.ReadLine().Split(';');
            Queue<KeyValuePair<string, int>> exclusionFilters = new Queue<KeyValuePair<string, int>>();

            while (input[0] != "Forge")
            {
                if (input.Length < 3)
                {
                    input = Console.ReadLine().Split(';');
                    continue;
                }

                // {command;filter type;filter parameter} eg.: Exclude;Sum Left Right;9
                string command = input[0]; // Commands can be: "Exclude", "Reverse" or "Forge".
                string filterType = input[1]; // Filter types are: "Sum Left", "Sum Right" and "Sum Left Right". 
                int filterParamenter = int.Parse(input[2]); // All filter parameters will be an integer. 

                switch (command)
                {
                    case "Exclude":
                        exclusionFilters.Enqueue(new KeyValuePair<string, int>(filterType, filterParamenter));
                        break;
                    case "Reverse":
                        if (exclusionFilters.Count > 0)
                        {
                            exclusionFilters.Dequeue();
                        }
                        break;
                }

                input = Console.ReadLine().Split(';');
            }

            ExecuteExclusions(gems, exclusionFilters);
        }

        private static void ExecuteExclusions(List<int> gems, Queue<KeyValuePair<string, int>> exclusionFilters)
        {
            foreach (var filter in exclusionFilters.Reverse())
            {
                switch (filter.Key)
                {
                    case "Sum Left":
                        FilterLeft(filter.Value, gems); break;
                    case "Sum Right":
                        FilterRight(filter.Value, gems); break;
                    case "Sum Left Right":
                        FilterLeftRight(filter.Value, gems); break;
                }
            }
        }

        private static void FilterLeftRight(int value, List<int> gems)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                int leftGemPower = (i == 0) ? 0 : gems[i - 1];
                int rightGemPower = (i == gems.Count - 1) ? 0 : gems[i + 1];

                if (leftGemPower + gems[i] + rightGemPower == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterRight(int value, List<int> gems)
        {
            while (gems.Count > 0 && gems.Last() == value)
            {
                gems.RemoveAt(gems.Count - 1);
            }

            for (int i = 0; i < gems.Count; i++)
            {
                int rightNum = (i == gems.Count - 1) ? 0 : gems[i + 1];

                if (gems[i] + rightNum == value)
                {
                    gems.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterLeft(int value, List<int> gems)
        {
            while (gems.Count > 0 && gems.First() == value)
            {
                gems.RemoveAt(0);
            }

            for (int i = gems.Count - 1; i >= 0; i--)
            {
                int leftNum = (i > 0) ? gems[i - 1] : 0;

                if (gems[i] + leftNum == value)
                {
                    gems.RemoveAt(i);
                }
            }
        }
    }
}