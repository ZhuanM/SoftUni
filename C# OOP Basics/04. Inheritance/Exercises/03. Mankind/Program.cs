using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] studentArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string studentFirstName = studentArr[0];
            string studentLastName = studentArr[1];
            string studentFacultyNumber = studentArr[2];

            Student student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            string[] workerArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string workerFirstName = workerArr[0];
            string workerLastName = workerArr[1];
            double workerSalary = double.Parse(workerArr[2]);
            double workerWorkHours = double.Parse(workerArr[3]);

            Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerWorkHours);

            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }       
    }
}