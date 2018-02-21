using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var team = new Team("my team");
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();

            var person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                decimal.Parse(cmdArgs[3]));

            team.AddPlayer(person);

        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}