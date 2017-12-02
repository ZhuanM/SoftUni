﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace X.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"^([^\s_]{3})(\.[^\s_]{3})*$");

            while (input != "ReadMe")
            {
                if (pattern.IsMatch(input))
                {
                    if (isPalindrome(input))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }

        static bool isPalindrome(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}