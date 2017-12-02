using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {           
            string input = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                .Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([A-Za-z]+)(.*)(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);

            int count = 0;
            foreach (Match m in matches)
            {
                string newValue = m.Groups[1] + placeholders[count++] + m.Groups[3];

                input = input.Replace(m.Value, newValue);
            }

            Console.WriteLine(input);
        }
    }
}