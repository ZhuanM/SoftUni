using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine()) != "Output")
            {
                string[] patientData = input.Split();

                string department = patientData[0];
                string doctor = patientData[1] + " " + patientData[2];
                string patient = patientData[3];

                if (departments.ContainsKey(department) == false)
                {
                    departments.Add(department, new List<string>());
                }
                departments[department].Add(patient);

                if (doctors.ContainsKey(doctor) == false)
                {
                    doctors.Add(doctor, new List<string>());
                }
                doctors[doctor].Add(patient);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitCommand = input.Split();

                if (splitCommand.Length == 1)
                {
                    foreach (var patient in departments[input])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    int roomNumber = 0;
                    if (int.TryParse(splitCommand[1], out roomNumber))
                    {
                        int skip = 3 * (roomNumber - 1);
                        foreach (var patient in departments[splitCommand[0]].Skip(skip).Take(3).OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        foreach (var patient in doctors[input].OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
        }
    }
}