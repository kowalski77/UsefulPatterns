using System;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public class DecoratorThreeStarter
    {
        public void Run()
        {
            var motorBike = MotorBikeBuilderExtensions
                .CreateMotorBike(new Basic())
                .AddExtra(typeof(PowerUpDecorator))
                .AddExtra(typeof(ExtraWheelDecorator))
                .Build();

            var cost = motorBike.GetCost();
            var description = motorBike.GetExtras();

            Console.WriteLine($"Total cost: {cost} {Environment.NewLine}Full description: {description}");
        }
    }
}