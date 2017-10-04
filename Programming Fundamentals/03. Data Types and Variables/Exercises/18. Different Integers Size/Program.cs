﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumber = Console.ReadLine();
            decimal parsedNumber = decimal.Parse(userNumber);

            if (parsedNumber > long.MaxValue || parsedNumber < long.MinValue)
            {
                Console.WriteLine($"{userNumber} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{parsedNumber} can fit in:");
                if (parsedNumber >= sbyte.MinValue && parsedNumber <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (parsedNumber >= byte.MinValue && parsedNumber <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (parsedNumber >= short.MinValue && parsedNumber <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (parsedNumber >= ushort.MinValue && parsedNumber <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (parsedNumber >= int.MinValue && parsedNumber <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (parsedNumber >= uint.MinValue && parsedNumber <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (parsedNumber >= long.MinValue && parsedNumber <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}