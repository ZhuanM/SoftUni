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
        List<Engine> engines = new List<Engine>();

        int enginesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < enginesCount; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string engineModel = inputTokens[0];
            int enginePower = int.Parse(inputTokens[1]);

            if (inputTokens.Length == 2)
            {
                engines.Add(new Engine(engineModel, enginePower));
            }
            else if (inputTokens.Length == 3)
            {
                if (inputTokens[2].All(Char.IsDigit))
                {
                    int displacement = int.Parse(inputTokens[2]);

                    engines.Add(new Engine(engineModel, enginePower, displacement));
                }
                else
                {
                    string efficiency = inputTokens[2];

                    engines.Add(new Engine(engineModel, enginePower, efficiency));
                }
            }
            else if (inputTokens.Length == 4)
            {
                int displacement = int.Parse(inputTokens[2]);
                string efficiency = inputTokens[3];

                engines.Add(new Engine(engineModel, enginePower, displacement, efficiency));
            }
        }

        int carsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsCount; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string carModel = inputTokens[0];
            Engine engineModel = engines.First(e => e.EngineModel == inputTokens[1]);

            if (inputTokens.Length == 2)
            {
                cars.Add(new Car(carModel, engineModel));
            }
            else if (inputTokens.Length == 3)
            {
                if (inputTokens[2].All(Char.IsDigit))
                {
                    int weight = int.Parse(inputTokens[2]);

                    cars.Add(new Car(carModel, engineModel, weight));
                }
                else
                {
                    string color = inputTokens[2];

                    cars.Add(new Car(carModel, engineModel, color));
                }
            }
            else if (inputTokens.Length == 4)
            {
                int weight = int.Parse(inputTokens[2]);
                string color = inputTokens[3];

                cars.Add(new Car(carModel, engineModel, weight, color));
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.CarModel}:");
            Console.WriteLine($"  {car.EngineModel.EngineModel}:");
            Console.WriteLine($"    Power: {car.EngineModel.EnginePower}");

            if (car.EngineModel.Displacement == null)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {car.EngineModel.Displacement}");
            }

            if (car.EngineModel.Efficiency == null)
            {
                Console.WriteLine($"    Efficiency: n/a");
            }
            else
            {
                Console.WriteLine($"    Efficiency: {car.EngineModel.Efficiency}");
            }


            if (car.Weight == null)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }

            if (car.Color == null)
            {
                Console.WriteLine($"  Color: n/a");
            }
            else
            {
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}