namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class MotorBikeDecorator : IMotorBike
    {
        private readonly IMotorBike motorBike;
        protected string Extra = "undefined extra";
        protected double Price = 0.0;

        public MotorBikeDecorator(IMotorBike motorBike)
        {
            this.motorBike = motorBike;
        }

        public string GetExtras()
        {
            return $"{this.motorBike.GetExtras()}, {this.Extra}";
        }

        public double GetCost()
        {
            return this.motorBike.GetCost() + this.Price;
        }
    }
}