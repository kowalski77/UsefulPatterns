using System;

namespace UsefulPatterns.AbstractFactory.Example_2
{
    public class MotorVehicleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleRequirements requirements)
        {
            return requirements.PeopleNumber switch
            {
                1 => new MotorBike(),
                2 => new Car(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}