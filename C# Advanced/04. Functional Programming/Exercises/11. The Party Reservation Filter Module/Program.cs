﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.The_Party_Reservation_Filter_Module
{
    class Program
    {
        public static void Main()
        {
            List<string> guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] commands = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    guests = guests.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    guests = guests.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    guests = guests.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    guests = guests.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (guests.Any())
            {
                Console.WriteLine(string.Join(" ", guests));
            }
        }
    }
}