namespace UsefulPatterns.AbstractFactory.Example_2
{
    public class VehicleFactory : AbstractVehicleFactory
    {
        private readonly IVehicleFactory vehicleFactory;
        private readonly VehicleRequirements requirements;

        public VehicleFactory(VehicleRequirements requirements)
        {
            this.requirements = requirements;
            this.vehicleFactory =
                requirements.HasEngine ? 
                    (IVehicleFactory) new CycleFactory() : 
                    new MotorVehicleFactory();
        }

        public override IVehicle Create()
        {
            return this.vehicleFactory.Create(this.requirements);
        }
    }
}