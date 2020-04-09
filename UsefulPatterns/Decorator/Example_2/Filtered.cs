namespace UsefulPatterns.Decorator.Example_2
{
    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Filtered with care";
        }

        public double GetCost()
        {
            return 1.99;
        }
    }
}