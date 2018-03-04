using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

        int countOfPeople = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfPeople; i++)
        {
            string[] tokens = Console.ReadLine().Split();

            if (tokens.Length == 3) // Rebel
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string group = tokens[2];

                Rebel rebel = new Rebel(name, age, group);

                buyers.Add(name, rebel);
            }
            else if (tokens.Length == 4) // Citizen
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                string birthdate = tokens[3];

                Citizen citizen = new Citizen(name, age, id, birthdate);

                buyers.Add(name, citizen);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if (buyers.ContainsKey(input))
            {
                buyers[input].BuyFood();
            }
        }

        int sumOfFood = buyers.Sum(b => b.Value.Food);
        Console.WriteLine(sumOfFood);
    }
}