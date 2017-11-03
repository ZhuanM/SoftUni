using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\D+)(\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder result = new StringBuilder();

            foreach (Match m in matches)
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }                
            }

            int countInResult = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {countInResult}");
            Console.WriteLine(result);
        }
    }
}