using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"(?<=\s|^)([A-Za-z0-9]+[._-]?[A-Za-z0-9]+)+@([A-Za-z]+[._-]?)+\.[A-Za-z]+(?=[.,\s]|\b)";
            string input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match emailMatch in emails)
            {
                Console.WriteLine(emailMatch.Value);
            }
        }
    }
}