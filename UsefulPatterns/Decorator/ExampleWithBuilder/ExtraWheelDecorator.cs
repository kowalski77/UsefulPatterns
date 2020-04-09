namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class ExtraWheelDecorator : MotorBikeDecorator
    {
        public ExtraWheelDecorator(IMotorBike motorBike) : base(motorBike)
        {
            this.Extra = "One extra wheel";
            this.Price = 5;
        }
    }
}