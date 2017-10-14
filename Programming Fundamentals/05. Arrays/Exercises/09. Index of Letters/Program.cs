using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArr = input.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine(charArr[i] + " -> " + ((int) charArr[i] - 97));
            }
        }
    }
}