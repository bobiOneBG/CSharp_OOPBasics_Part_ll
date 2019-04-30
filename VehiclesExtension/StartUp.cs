namespace VehiclesExtension
{
    using System;

   public class StartUp
    {
       public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();

            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandInfo = Console.ReadLine().Split();

                var command = commandInfo[0];

                if (command == "Drive")
                {
                    if (commandInfo[1] == "Car")
                    {
                        car.Drive(double.Parse(commandInfo[2]));
                    }

                    else if (commandInfo[1] == "Truck")
                    {
                        truck.Drive(double.Parse(commandInfo[2]));
                    }
                      
                    else if(commandInfo[1] == "Bus")
                    {
                        bus.ONAirConditioner();
                        bus.Drive(double.Parse(commandInfo[2]));
                        bus.OFFAirConditioner();
                    }
                }

                else if (command == "Refuel")
                {
                    if (commandInfo[1] == "Car")
                    {
                        car.Refuel(double.Parse(commandInfo[2]));
                    }

                    else if (commandInfo[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(commandInfo[2]));
                    }

                    else if (commandInfo[1]=="Bus")
                    {
                        bus.Refuel(double.Parse(commandInfo[2]));
                    }
                }

                else if (command== "DriveEmpty")
                {
                    bus.Drive(double.Parse(commandInfo[2]));
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
