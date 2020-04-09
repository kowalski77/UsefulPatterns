using System;

namespace UsefulPatterns.Decorator.Example_1
{
    public class FreshSalad : RestaurantDish
    {
        private readonly string greens;

        public FreshSalad(string greens)
        {
            this.greens = greens;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}", this.greens);
        }
    }
}