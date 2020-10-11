using System;
using System.Threading.Tasks;
using UsefulPatterns.Visitor.Simple;

namespace UsefulPatterns
{
    internal class Program
    {
        private static async Task Main()
        {
            var simpleVisitorStarter = new SimpleVisitorStarter();
            simpleVisitorStarter.Run();

            Console.ReadKey();
        }
    }
}