using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        int carsToTrackCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carsToTrackCount; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string model = inputTokens[0];
            decimal fuelAmount = decimal.Parse(inputTokens[1]);
            decimal fuelConsumptionPerKm = decimal.Parse(inputTokens[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);

            cars.Add(car);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string model = inputTokens[1];
            decimal amountOfKm = decimal.Parse(inputTokens[2]);

            Car car = cars.First(c => c.Model == model);

            if (!car.CanMoveDistance(amountOfKm))
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}