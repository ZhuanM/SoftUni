using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateMessageRegex = @"^(\d+) <-> (\w+)$";
            string broadcastRegex = @"^(\D+) <-> (\w+)$";

            List<string> messages = new List<string>();
            List<string> broadcast = new List<string>();

            while (input != "Hornet is Green")
            {
                var privateMessageMatch = Regex.Match(input, privateMessageRegex);
                var broadcastMatch = Regex.Match(input, broadcastRegex);

                if (privateMessageMatch.Success)
                {
                    string recipientCode = privateMessageMatch.Groups[1].Value;
                    recipientCode = string.Join("", recipientCode.Reverse());
                    messages.Add(recipientCode + " -> " + privateMessageMatch.Groups[2].Value);
                }

                if (broadcastMatch.Success)
                {
                    string frequency = broadcastMatch.Groups[2].Value;
                    string frequencyResult = "";

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                    }

                    broadcast.Add(frequencyResult + " -> " + broadcastMatch.Groups[1].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
                Console.WriteLine("None");
            else
                broadcast.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
                Console.WriteLine("None");
            else
                messages.ForEach(e => Console.WriteLine(e));
        }
    }
}