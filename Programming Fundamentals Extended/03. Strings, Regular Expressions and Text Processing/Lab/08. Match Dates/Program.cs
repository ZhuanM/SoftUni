using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<seperator>[.\-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                var day = m.Groups["day"].Value;
                var month = m.Groups["month"].Value;
                var year = m.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}