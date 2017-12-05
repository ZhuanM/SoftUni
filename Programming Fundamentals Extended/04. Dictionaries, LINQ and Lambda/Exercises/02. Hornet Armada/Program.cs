using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var legionsActivity = new Dictionary<string, long>();
            var legionsInfo = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("=->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionsInfo.ContainsKey(legionName))
                {
                    legionsInfo.Add(legionName, new Dictionary<string, long>());
                    legionsActivity.Add(legionName, lastActivity);
                }

                if (!legionsInfo[legionName].ContainsKey(soldierType))
                {
                    legionsInfo[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionsInfo[legionName][soldierType] += soldierCount;
                }

                if (legionsActivity[legionName] < lastActivity)
                {
                    legionsActivity[legionName] = lastActivity;
                }
            }

            string command = Console.ReadLine();

            if (command.IndexOf('\\') != -1)
            {
                long activity = long.Parse(command.Substring(0, command.IndexOf('\\')));
                string soldier = command.Substring(command.IndexOf('\\') + 1);

                foreach (var item in legionsInfo.Where(e => legionsInfo[e.Key].ContainsKey(soldier)).OrderByDescending(k => k.Value[soldier])) //k.Value[soldier] = soldierCount
                {
                    if (legionsActivity[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[soldier]}");
                    }
                }
            }
            else
            {
                foreach (var item in legionsActivity.OrderByDescending(x => x.Value))
                {
                    if (legionsInfo[item.Key].ContainsKey(command))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}