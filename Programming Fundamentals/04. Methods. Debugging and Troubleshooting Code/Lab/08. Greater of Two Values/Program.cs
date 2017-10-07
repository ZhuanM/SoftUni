using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int maxValue = Math.Max(a, b);
            return maxValue;
        }

        static string GetMax(string a, string b)
        {
            string maxValue = string.Empty;
            if (a.CompareTo(b) >= 0)
            {
                maxValue = a;
            }
            else
            {
                maxValue = b;
            }
            return maxValue;
        }

        static char GetMax(char a, char b)
        {
            char maxValue = 'a';
            if (a >= b)
            {
                maxValue = a;
            }
            else
            {
                maxValue = b;
            }
            return maxValue;
        }

        static void Main(string[] args)
        {
            string dataType = Console.ReadLine().ToLower();
            if (dataType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (dataType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
        }
    }
}