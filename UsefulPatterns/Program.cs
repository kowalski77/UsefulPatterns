using System;
using UsefulPatterns.Decorator.Example_2;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var decoratorTwo = new DecoratorTwoStarter();
            decoratorTwo.Run();

            Console.ReadKey();
        }
    }
}
