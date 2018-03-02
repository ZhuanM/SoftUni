using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<IBirthable> all = new List<IBirthable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();

            if (tokens[0] == "Citizen")
            {
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                string id = tokens[3];
                string birthdate = tokens[4];

                Citizen citizen = new Citizen(name, age, id, birthdate);
                all.Add(citizen);
            }
            else if (tokens[0] == "Pet")
            {
                string name = tokens[1];
                string birthdate = tokens[2];

                Pet pet = new Pet(name, birthdate);
                all.Add(pet);
            }
            //BELOW IS USELESS TO THE CURRENT TASK
            //else if (tokens[0] == "Robot")
            //{
            //    string model = tokens[1];
            //    string id = tokens[2];
            //
            //   Robot robot = new Robot(model, id);
            //}
        }

        int year = int.Parse(Console.ReadLine());

        foreach (var entity in all)
        {
            if (entity.Birthdate.Year == year)
            {
                Console.WriteLine($"{entity.Birthdate:dd/mm/yyyy}");
            }
        }
    }
}