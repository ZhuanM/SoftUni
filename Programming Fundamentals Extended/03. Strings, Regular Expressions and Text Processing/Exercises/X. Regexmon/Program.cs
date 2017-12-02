using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace X.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bojoRegex = @"([A-Za-z]+\-[A-Za-z]+)";
            string didiRegex = @"[^A-Za-z-]+";

            while (true)
            {               
                var didiMatch = Regex.Match(input, didiRegex);

                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value);
                    input = input.Substring(input.IndexOf(didiMatch.Value) + didiMatch.Value.Length);
                }
                else
                    break;

                var bojoMatch = Regex.Match(input, bojoRegex);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                    input = input.Substring(input.IndexOf(bojoMatch.Value) + bojoMatch.Value.Length);
                }
                else
                    break;
            }
        }
    }
}