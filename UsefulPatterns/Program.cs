using System;
using UsefulPatterns.Decorator.Example;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var decorator = new DecoratorStarter();
            decorator.Run();

            Console.ReadKey();
        }
    }
}
