namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class Basic : IMotorBike
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