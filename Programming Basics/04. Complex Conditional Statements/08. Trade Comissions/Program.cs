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
            string city = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double com = 1;

            if (s >= 0 && s <= 500)
            {
                if (city == "sofia")
                {
                    com = s * .05;
                }
                else if (city == "varna")
                {
                    com = s * .045;
                }
                else if (city == "plovdiv")
                {
                    com = s * .055;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s > 500 && s <= 1000)
            {
                if (city == "sofia")
                {
                    com = s * .07;
                }
                else if (city == "varna")
                {
                    com = s * .075;
                }
                else if (city == "plovdiv")
                {
                    com = s * .08;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s > 1000 && s <= 10000)
            {
                if (city == "sofia")
                {
                    com = s * .08;
                }
                else if (city == "varna")
                {
                    com = s * .1;
                }
                else if (city == "plovdiv")
                {
                    com = s * .12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s > 10000)
            {
                if (city == "sofia")
                {
                    com = s * .12;
                }
                else if (city == "varna")
                {
                    com = s * .13;
                }
                else if (city == "plovdiv")
                {
                    com = s * .145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(com);
        }
    }
}