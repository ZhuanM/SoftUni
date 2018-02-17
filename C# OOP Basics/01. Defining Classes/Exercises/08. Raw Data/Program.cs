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

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string model = inputTokens[0];
            int engineSpeed = int.Parse(inputTokens[1]);
            int enginePower = int.Parse(inputTokens[2]);
            int cargoWeight = int.Parse(inputTokens[3]);
            string cargoType = inputTokens[4];
            double tire1Pressure = double.Parse(inputTokens[5]);
            double tire1Age = double.Parse(inputTokens[6]);
            double tire2Pressure = double.Parse(inputTokens[7]);
            double tire2Age = double.Parse(inputTokens[8]);
            double tire3Pressure = double.Parse(inputTokens[9]);
            double tire3Age = double.Parse(inputTokens[10]);
            double tire4Pressure = double.Parse(inputTokens[11]);
            double tire4Age = double.Parse(inputTokens[12]);

            Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                tire3Pressure, tire3Age, tire4Pressure, tire4Age);

            cars.Add(car);
        }

        string deliveryType = Console.ReadLine();
       
        if (deliveryType == "fragile")
        {
            foreach (var car in cars)
            {
                if (car.Tire1Pressure < 1 || car.Tire2Pressure < 1 ||
                    car.Tire3Pressure < 1 || car.Tire4Pressure < 1)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        else if (deliveryType == "flamable")
        {
            foreach (var car in cars)
            {
                if (car.EnginePower > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}