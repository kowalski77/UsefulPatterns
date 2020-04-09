using System;

namespace UsefulPatterns.AbstractFactory.Example_2
{
    public class VehicleFactoryStarter
    {
        public void Run()
        {
            var vehicleFactory = new VehicleFactory(new VehicleRequirements
            {
                HasEngine = true,
                PeopleNumber = 2
            });

            var vehicle = vehicleFactory.Create();
            var info = vehicle.GetInfo();

            Console.WriteLine($"Info: {info}");
        }
    }
}