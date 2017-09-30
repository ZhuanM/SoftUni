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
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            gender = gender.ToLower();

            if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
