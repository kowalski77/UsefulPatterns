namespace UsefulPatterns.Decorator.Example
{
    public abstract class MotorBikeDecorator : IMotorBike
    {
        private readonly IMotorBike motorBike;
        protected string Extra = "undefined extra";
        protected double Price = 0.0;

        protected MotorBikeDecorator(IMotorBike motorBike) => 
            this.motorBike = motorBike;

        public string GetExtras() => 
            $"{this.motorBike.GetExtras()}, {this.Extra}";

        public double GetCost() => 
            this.motorBike.GetCost() + this.Price;
    }
}