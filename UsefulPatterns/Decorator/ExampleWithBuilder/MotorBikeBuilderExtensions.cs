using System;
using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public static class MotorBikeBuilderExtensions
    {
        public static MotorBikeBuilderOld CreateMotorBike(IMotorBike motorBike)
        {
            var builder = new MotorBikeBuilderOld(motorBike);

            return builder;
        }

        public static MotorBikeBuilderOld AddExtra<TDecorator>(
            this MotorBikeBuilderOld motorBikeBuilder) where TDecorator : MotorBikeDecorator
        {
            var motorBikeExtra = Activator.CreateInstance(
                    typeof(TDecorator),
                    motorBikeBuilder.MotorBike) as MotorBikeDecorator;

            motorBikeBuilder.UpdateMotorBike(motorBikeExtra);

            return motorBikeBuilder;
        }
    }
}