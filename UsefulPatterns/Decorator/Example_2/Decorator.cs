namespace UsefulPatterns.Decorator.Example_2
{
    public class Decorator : ICoffee
    {
        private readonly ICoffee coffee;
        protected string Name = "undefined condiment";
        protected double Price = 0.0;

        public Decorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public string GetDescription()
        {
            return $"{this.coffee.GetDescription()}, {this.Name}";
        }

        public double GetCost()
        {
            return this.coffee.GetCost() + this.Price;
        }
    }
}