using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\[[A-Za-z]+\<(\d+)REGEH(\d+)\>[A-Za-z]+\]";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            List<int> indexes = new List<int>();
            foreach (Match match in regex.Matches(input))
            {
                indexes.Add(int.Parse(match.Groups[1].Value));
                indexes.Add(int.Parse(match.Groups[2].Value));
            }

            int currentIndex = 0;
            foreach (var index in indexes)
            {
                currentIndex += index;
                int charIndex = currentIndex % (input.Length - 1);
                Console.Write(input[charIndex]);
            }
        }
    }
}