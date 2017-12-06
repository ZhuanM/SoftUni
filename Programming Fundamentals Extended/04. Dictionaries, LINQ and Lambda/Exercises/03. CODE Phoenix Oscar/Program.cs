using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CODE_Phoenix_Oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();

            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                string[] data = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string creature = data[0];
                string squadMate = data[1];
                check.Add(squadMate + "" + creature); //reverse the string and Add it to the check List

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }

                if (creature == squadMate || check.Contains(creature + "" + squadMate))
                {
                    creatures[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;

                }

                creatures[creature].Add(squadMate); // Adds a squad mate to the Hash List of the corresponding creature

                input = Console.ReadLine();
            }

            foreach (var item in creatures.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}