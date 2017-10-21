using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while(true)
            {
                string metal = Console.ReadLine();
                if (metal == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(metal))
                {
                    dict.Add(metal, 0);
                }

                dict[metal] += quantity;
            }

            foreach (var resource in dict)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}