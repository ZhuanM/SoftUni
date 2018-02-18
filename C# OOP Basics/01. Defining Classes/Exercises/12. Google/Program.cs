using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string name = inputTokens[0];

            if (!people.Any(p => p.Name == name))
            {
                people.Add(new Person(name));
            }

            Person currentPerson = people.First(p => p.Name == name);

            if (inputTokens[1] == "company")
            {
                string companyName = inputTokens[2];
                string department = inputTokens[3];
                decimal salary = decimal.Parse(inputTokens[4]);

                currentPerson.AddCompany(companyName, department, salary);
            }
            else if (inputTokens[1] == "pokemon")
            {
                string pokemonName = inputTokens[2];
                string pokemonType = inputTokens[3];

                currentPerson.AddPokemon(pokemonName, pokemonType);
            }
            else if (inputTokens[1] == "parents")
            {
                string parentName = inputTokens[2];
                string parentBirthday = inputTokens[3];

                currentPerson.AddParent(new Person(parentName, parentBirthday));
            }
            else if (inputTokens[1] == "children")
            {
                string childName = inputTokens[2];
                string childBirthday = inputTokens[3];

                currentPerson.AddChild(new Person(childName, childBirthday));
            }
            else if (inputTokens[1] == "car")
            {
                string carModel = inputTokens[2];
                int carSpeed = int.Parse(inputTokens[3]);

                currentPerson.AddCar(carModel, carSpeed);
            }
        }

        string inputTargetPerson = Console.ReadLine();

        Person targetPerson = people.First(p => p.Name == inputTargetPerson);

        Console.WriteLine(targetPerson);
    }
}