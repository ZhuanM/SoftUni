using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .ToLower()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in sequence)
            {
                if (words.ContainsKey(word))
                {
                    words[word] += 1; //words[word]++; no za da go razbera po-lesno
                }
                else
                {
                    words[word] = 1;
                }
            }

            List<string> oddCount = new List<string>();
            foreach (var pair in words)
            {
                if (pair.Value % 2 != 0)
                {
                    oddCount.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddCount));
        }
    }
}