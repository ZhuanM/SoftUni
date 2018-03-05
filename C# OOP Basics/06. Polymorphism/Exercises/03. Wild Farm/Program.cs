using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            Animal animal = AnimalFactory.Create(command.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries));
            animals.Add(animal);
            Console.WriteLine(animal.ProduceSound());
            Food food = FoodFactory.Create(Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries));

            try
            {
                animal.EatFood(food);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}