namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class BasicBike : IMotorBike
    {
        public string GetExtras()
        {
            return "Basic";
        }

        public double GetCost()
        {
            return 10;
        }
    }
}