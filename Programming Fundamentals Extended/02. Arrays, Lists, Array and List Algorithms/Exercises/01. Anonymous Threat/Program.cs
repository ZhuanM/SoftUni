using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0 || startIndex > elements.Count - 1)
                {
                    startIndex = 0;
                }

                if (endIndex < 0 || endIndex > elements.Count - 1)
                {
                    endIndex = elements.Count - 1;
                }

                switch (command)
                {
                    case "merge":
                        var concatElem = string.Join("", elements.Skip(startIndex).Take(endIndex + 1).ToArray());

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }

                        elements.Insert(startIndex, concatElem);

                        break;                
                    case "divide":
                        int wordToDivide = int.Parse(commands[1]);
                        int partitionsCount = int.Parse(commands[2]);

                        DivideEqual(elements[wordToDivide], partitionsCount);

                        break;
                }

                input = Console.ReadLine();
            }
        }

        static List<string> DivideEqual(string word, int partitions)
        {
            List<string> result = new List<string>();

            int partitionsCount = word.Length / partitions;

            while (word.Length >= partitionsCount)
            {
                result.Add(word.Substring(0, partitionsCount));
                word = word.Substring(partitionsCount);
            }

            return result;
        }
    }
}