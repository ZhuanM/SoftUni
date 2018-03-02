using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<IIdentifiable> all = new List<IIdentifiable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();

            if (tokens.Length == 2) // Robot
            {
                string model = tokens[0];
                string id = tokens[1];

                Robot robot = new Robot(model, id);
                all.Add(robot);
            }
            else if (tokens.Length == 3) // Human
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];

                Citizen citizen = new Citizen(name, age, id);
                all.Add(citizen);
            }
        }

        string fakeIdLastDigits = Console.ReadLine();

        foreach (var entity in all)
        {
            if (entity.Id.EndsWith(fakeIdLastDigits))
            {
                Console.WriteLine(entity.Id);
            }
        }
    }
}