using System;
using System.Threading.Tasks;
using UsefulPatterns.AdvancedMediator;

namespace UsefulPatterns
{
    internal class Program
    {
        private static async Task Main()
        {
            var mediator = new AdvancedMediatorStarter();
            await mediator.RunAsync().ConfigureAwait(false);

            Console.ReadKey();
        }
    }
}