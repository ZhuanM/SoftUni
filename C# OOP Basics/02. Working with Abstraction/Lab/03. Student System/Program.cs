using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        StudentSystem studentSystem = new StudentSystem();

        string command;
        while ((command = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(command, Console.WriteLine);
        }
    }
}