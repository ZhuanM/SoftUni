﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool boolean = Convert.ToBoolean(text);

            if (boolean == true)
            {
                Console.WriteLine("Yes");
            }
            else if (boolean == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
