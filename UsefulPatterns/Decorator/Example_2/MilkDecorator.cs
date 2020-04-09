namespace UsefulPatterns.Decorator.Example_2
{
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            this.Name = "Milk";
            this.Price = 0.19;
        }
    }
}