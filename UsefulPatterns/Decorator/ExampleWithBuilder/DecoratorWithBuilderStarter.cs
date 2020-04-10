using System;
using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class DecoratorWithBuilderStarter
    {
        public void Run()
        {
            var motorBike = MotorBikeBuilderExtensions
                .CreateMotorBike(new BasicBike())
                .AddExtra<PowerUpDecorator>()
                .AddExtra<ExtraWheelDecorator>()
                .Build();

            var cost = motorBike.GetCost();
            var description = motorBike.GetExtras();

            Console.WriteLine($"Total cost: {cost} {Environment.NewLine}Full description: {description}");
        }
    }
}