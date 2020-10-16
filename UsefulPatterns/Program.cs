using System;
using UsefulPatterns.Adapter;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var adapterStarter = new AdapterStarter();
            adapterStarter.Run();

            Console.ReadKey();
        }
    }
}