using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHP = int.Parse(Console.ReadLine());
            int maximumHP = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());



            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHP), new string('.', maximumHP - currentHP));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maximumEnergy - currentEnergy));
        }
    }
}