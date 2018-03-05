using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] carTokens = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));

        string[] truckTokens = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));

        string[] busTokens = Console.ReadLine().Split();
        Vehicle bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

        int countOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfCommands; i++)
        {
            string[] inputTokens = Console.ReadLine().Split();

            string command = inputTokens[0];
            string type = inputTokens[1];
            double value = double.Parse(inputTokens[2]);

            switch (type)
            {
                case nameof(Car):
                    ExecuteCommand(car, command, value);
                    break;
                case nameof(Truck):
                    ExecuteCommand(truck, command, value);
                    break;
                case nameof(Bus):
                    ExecuteCommand(bus, command, value);
                    break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void ExecuteCommand(Vehicle vehicle, string command, double value)
    {
        switch (command)
        {
            case "Drive":
                Console.WriteLine(vehicle.Drive(value));
                break;
            case "Refuel":
                try
                {
                    vehicle.Refuel(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            case "DriveEmpty":
                ((Bus)vehicle).SwitchOffAirConditioner();
                Console.WriteLine(vehicle.Drive(value));
                ((Bus)vehicle).SwitchOnAirConditioner();
                break;
        }
    }
}