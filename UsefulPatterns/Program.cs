using System;
using UsefulPatterns.Builder;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            //var decorator = new DecoratorStarter();
            //decorator.Run();

            //Console.ReadKey();

            ICarBuilder carBuilder = new CityCarBuilder();
            
            var car = carBuilder
                .AddExtraPower()
                .AddExtraPower()
                .ChangeEngine()
                .Build();

            Console.WriteLine($"== Build car == {Environment.NewLine}{car.Debug()}");
        }
    }
}
