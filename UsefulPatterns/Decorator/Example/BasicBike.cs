namespace UsefulPatterns.Decorator.Example
{
    public class BasicBike : IMotorBike
    {
        public string GetExtras() => "Basic";
        public double GetCost() => 10;
    }
}