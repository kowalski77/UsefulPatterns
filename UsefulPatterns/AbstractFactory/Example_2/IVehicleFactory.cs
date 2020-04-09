namespace UsefulPatterns.AbstractFactory.Example_2
{
    public interface IVehicleFactory
    {
        IVehicle Create(VehicleRequirements requirements);
    }
}