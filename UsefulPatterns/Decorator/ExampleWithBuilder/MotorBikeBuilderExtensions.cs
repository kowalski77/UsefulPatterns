using System;
using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public static class MotorBikeBuilderExtensions
    {
        public static MotorBikeBuilder CreateMotorBike(IMotorBike motorBike)
        {
            var builder = new MotorBikeBuilder(motorBike);

            return builder;
        }

        public static MotorBikeBuilder AddExtra<TDecorator>(
            this MotorBikeBuilder motorBikeBuilder) where TDecorator : MotorBikeDecorator
        {
            var motorBikeExtra = Activator.CreateInstance(
                    typeof(TDecorator),
                    motorBikeBuilder.MotorBike) as MotorBikeDecorator;

            motorBikeBuilder.UpdateMotorBike(motorBikeExtra);

            return motorBikeBuilder;
        }
    }
}