namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class PowerUpDecorator : MotorBikeDecorator
    {
        public PowerUpDecorator(IMotorBike motorBike) : base(motorBike)
        {
            this.Extra = "Extra power";
            this.Price = 7;
        }
    }
}