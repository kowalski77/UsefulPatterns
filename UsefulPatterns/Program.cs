using System;
using UsefulPatterns.Decorator.ExampleWithBuilder;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var decoratorTwo = new DecoratorThreeStarter();
            decoratorTwo.Run();

            Console.ReadKey();
        }
    }
}
