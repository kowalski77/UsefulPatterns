using System;

namespace UsefulPatterns.AbstractFactory.Example_2
{
    public class CycleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleRequirements requirements)
        {
            return requirements.PeopleNumber switch
            {
                1 => new Bicycle(),
                2 => new Tandem(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}