using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine()
                .Split();

            double carFuelQuantity = double.Parse(carArgs[1]);
            double carConsumption = double.Parse(carArgs[2]);

            Car car = new Car(carFuelQuantity, carConsumption);

            string[] truckArgs = Console.ReadLine()
                .Split();

            double truckFuelQuantity = double.Parse(truckArgs[1]);
            double truckConsumption = double.Parse(truckArgs[2]);

            Truck truck = new Truck(truckFuelQuantity, truckConsumption);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split();

                if (commandArgs[1] == "Car")
                {
                    if (commandArgs[0] == "Refuel")
                    {
                        carFuelQuantity += double.Parse(commandArgs[2]);
                    }
                    else if(commandArgs[0] == "Drive")
                    {
                        double distance = double.Parse(commandArgs[2]);
                        double currentConsumption = distance * car.FuelConsuption;

                        if (currentConsumption <= carFuelQuantity)
                        {
                            Console.WriteLine(car.Drive(distance));
                            carFuelQuantity -= currentConsumption;
                        }
                        else
                        {
                            Console.WriteLine(car.Refuel());
                        }
                    }
                
                }
                else if (commandArgs[1] == "Truck")
                {
                    if (commandArgs[0] == "Refuel")
                    {
                        truckFuelQuantity += double.Parse(commandArgs[2]);
                    }
                    else if (commandArgs[0] == "Drive")
                    {
                        double distance = double.Parse(commandArgs[2]);
                        double currentConsumption = distance * truck.FuelConsuption;

                        if (currentConsumption <= truckFuelQuantity)
                        {
                            Console.WriteLine(truck.Drive(distance));
                            truckFuelQuantity -= currentConsumption;
                        }
                        else
                        {
                            Console.WriteLine(truck.Refuel());
                        }
                    }
             
                }
            }

            Console.WriteLine($"Car: {carFuelQuantity:F2}");
            Console.WriteLine($"Truck: {truckFuelQuantity:F2}");

        }
    }
}
