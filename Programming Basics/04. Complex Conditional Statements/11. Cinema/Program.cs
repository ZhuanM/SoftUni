using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int room = r * c;

            if (type == "premiere")
            {
                double a = room * 12;
                Console.WriteLine(Math.Round(a, 2) + " leva");
            }
            else if (type == "normal")
            {
                double a = room * 7.5;
                Console.WriteLine(Math.Round(a, 2) + " leva");
            }
            else if (type == "discount")
            {
                double a = room * 5;
                Console.WriteLine(Math.Round(a, 2) + " leva");
            }
        }
    }
}