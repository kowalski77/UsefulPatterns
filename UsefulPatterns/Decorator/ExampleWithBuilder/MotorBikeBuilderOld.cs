using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class MotorBikeBuilderOld
    {
        public IMotorBike MotorBike { get; private set; }

        public MotorBikeBuilderOld(IMotorBike motorBike)
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