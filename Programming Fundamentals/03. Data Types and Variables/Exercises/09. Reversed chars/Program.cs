using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            string concatChar = $"{char1}{char2}{char3}";
            char[] myChar = concatChar.ToCharArray();
            Array.Reverse(myChar);
            string output = new string(myChar);
            Console.WriteLine(output);
        }
    }
}