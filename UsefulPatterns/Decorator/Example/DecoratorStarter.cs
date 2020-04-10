using System;

namespace UsefulPatterns.Decorator.Example
{
    public class DecoratorStarter
    {
        public void Run()
        {
            var decorator = new PowerUpDecorator(
                new ExtraWheelDecorator(
                    new BasicBike()));

            var extras = decorator.GetExtras();
            var cost = decorator.GetCost();

            Console.WriteLine($"Extras: {extras}");
            Console.WriteLine($"Cost: {cost}");
        }
    }
}