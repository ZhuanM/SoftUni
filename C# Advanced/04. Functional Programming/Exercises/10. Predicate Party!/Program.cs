﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Predicate_Party_
{
    class Program
    {
        public static void Main()
        {
            List<string> people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "party!")
            {
                if (input[0].ToLower() == "remove")
                {
                    if (input[1].ToLower() == "startswith")
                    {
                        people = people.Where(x => x.IndexOf(input[2]) != 0).ToList();
                    }
                    else if (input[1].ToLower() == "endswith")
                    {
                        people = people.Where(x => x.IndexOf(input[2]) != x.Length - input[2].Length).ToList();
                    }
                    else
                    {
                        people = people.Where(x => x.Length != int.Parse(input[2])).ToList();
                    }
                }
                else if (input[0].ToString().ToLower() == "double")
                {
                    int length;
                    bool isLengthParameter = int.TryParse(input[2], out length);
                    if (isLengthParameter)
                    {
                        List<string> temp = people.Where(x => x.Length == int.Parse(input[2])).ToList();
                        if (temp.Count != 0)
                        {
                            foreach (var item in temp)
                            {
                                people.Insert(0, item);
                            }
                        }
                    }
                    else if (input[1].ToLower() == "startswith")
                    {
                        List<string> index = people.Where(x => x.IndexOf(input[2]) == 0).ToList();
                        if (index.Count != 0)
                        {
                            foreach (var item in index)
                            {
                                people.Insert(0, item);
                            }
                        }
                    }
                    else
                    {
                        List<string> index = people.Where(x => x.IndexOf(input[2]) == x.Length - input[2].Length).ToList();
                        if (index.Count != 0)
                        {
                            foreach (var item in index)
                            {
                                people.Insert(0, item);
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (people.Count != 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}