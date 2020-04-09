using System;

namespace UsefulPatterns.Decorator.Example_1
{
    public class Pasta : RestaurantDish
    {
        private readonly string sauce;

        public Pasta(string sauce)
        {
            this.sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine(" Sauce: {0}", this.sauce);
        }
    }
}