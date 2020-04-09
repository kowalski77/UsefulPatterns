namespace UsefulPatterns.Decorator.Example_2
{
    public class ChocolateDecorator : Decorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            this.Name = "Chocolate";
            this.Price = 0.29;
        }
    }
}