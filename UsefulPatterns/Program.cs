using System;
using UsefulPatterns.Mediator;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            //var display = new Display();
            //var handler = new FizzBuzzHandler();
            //var range = new FizzBuzzRange(1, 100);

            //handler
            //    .Next(new FizzHandler())
            //    .Next(new BuzzHandler())
            //    .Next(new NoFizzBuzzHandler());

            //var fizzBuzzer = new FizzBuzzer(display, handler, range);
            //fizzBuzzer.Run();

            var mediatorStarter = new MediatorStarter();
            mediatorStarter.Run();

            Console.ReadKey();
        }
    }
}