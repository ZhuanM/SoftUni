using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Department> departments = new List<Department>();

        int employeeCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeCount; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string name = inputTokens[0];
            decimal salary = decimal.Parse(inputTokens[1]);
            string position = inputTokens[2];
            string departmentName = inputTokens[3];
            string email = "n/a";
            int age = -1;

            if (inputTokens.Length == 6)
            {
                email = inputTokens[4];
                age = int.Parse(inputTokens[5]);
            }
            else if (inputTokens.Length == 5)
            {
                bool isAge = int.TryParse(inputTokens[4], out age);
                if (!isAge)
                {
                    email = inputTokens[4];
                    age = -1;
                }
            }

            if (!departments.Any(d => d.Name == departmentName))
            {
                Department dep = new Department(departmentName);
                departments.Add(dep);
            }

            Department department = departments.FirstOrDefault(d => d.Name == departmentName);

            Employee employee = new Employee(name, position, salary, age, email);
            department.AddEmployee(employee);
        }

        Department highestAvgDep = departments.OrderByDescending(d => d.AverageSalary).First();

        // OUTPUT
        Console.WriteLine($"Highest Average Salary: {highestAvgDep.Name}");
        foreach (var emp in highestAvgDep.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }
}