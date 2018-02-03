using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string currentName = input[0];
                int currentAge = int.Parse(input[1]);

                people.Add(currentName, currentAge);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<KeyValuePair<string, int>, bool> filter = CreateFilter(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            foreach (var person in people) // people.Where(filter).ToList().ForEach(printer); is equivalent to this foreach
            {
                if (filter(person))
                {
                    printer(person);
                }
            }           
        }

        static Func<KeyValuePair<string, int>, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x.Value < age;
            }
            else
            {
                return x => x.Value > age;
            }
        }

        static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    throw new NotImplementedException();
            }
        }
    }
}