using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }

                grades[name].Add(grade);
            }

            foreach (var student in grades)
            {
                //suzdavame go, za da moje output da e v pravilniq format sus F2 a ne s premahvane na nulite
                List<string> gradesAsString = new List<string>();
                foreach (var grade in student.Value)
                {
                    gradesAsString.Add(string.Format("{0:f2}", grade));
                }
                Console.WriteLine($"{student.Key} -> {string.Join(" ", gradesAsString)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}