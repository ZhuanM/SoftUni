using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            int minLen = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLen; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    foreach (char ch in firstArr)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in secondArr)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
                else if (secondArr[i] < firstArr[i])
                {
                    foreach (char ch in secondArr)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in firstArr)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
            }

            if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(new string(firstArr));
                Console.WriteLine(new string(secondArr));
            }
            else
            {
                Console.WriteLine(new string(secondArr));
                Console.WriteLine(new string(firstArr));
            }
        }
    }
}