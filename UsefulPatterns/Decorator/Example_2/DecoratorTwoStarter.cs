using System;

namespace UsefulPatterns.Decorator.Example_2
{
    public class DecoratorTwoStarter
    {
        public void Run()
        {
            var decorator = new ChocolateDecorator(new MilkDecorator(new Espresso()));
            var cost = decorator.GetCost();
            var description = decorator.GetDescription();

            Console.WriteLine($"Total cost: {cost} {Environment.NewLine}Full description: {description}");
        }
    }
}