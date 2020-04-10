using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class MotorBikeBuilder
    {
        public IMotorBike MotorBike { get; private set; }

        public MotorBikeBuilder(IMotorBike motorBike)
        {
            this.MotorBike = motorBike;
        }

        public void UpdateMotorBike(IMotorBike motorBike)
        {
            this.MotorBike = motorBike;
        }

        public IMotorBike Build() => this.MotorBike;
    }
}