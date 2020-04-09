using System;

namespace UsefulPatterns.Decorator.ExampleWithBuilder
{
    public static class MotorBikeBuilderExtensions
    {
        public static MotorBikeBuilder CreateMotorBike(IMotorBike motorBike)
        {
            var builder = new MotorBikeBuilder(motorBike);

            return builder;
        }

        public static MotorBikeBuilder AddExtra(
            this MotorBikeBuilder motorBikeBuilder, 
            Type decoratorType)
        {
            var motorBikeExtra = Activator.CreateInstance(decoratorType, motorBikeBuilder.MotorBike) 
                as MotorBikeDecorator;

            motorBikeBuilder.UpdateMotorBike(motorBikeExtra);

            return motorBikeBuilder;
        }
    }
}