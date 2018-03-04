using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split();

            string name = tokens[0];
            string country = tokens[1];
            int age = int.Parse(tokens[2]);

            Citizen citizen = new Citizen(name, country, age);

            Console.WriteLine(citizen.GetName());
            Console.WriteLine(((IResident)citizen).GetName());
        }
    }
}