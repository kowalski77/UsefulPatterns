using System;

namespace UsefulPatterns.Decorator.Example_1
{
    public class DecoratorOneStarter
    {
        public void Run()
        {
            var caesarSalad = new FreshSalad("lettuce");
            caesarSalad.Display();

            var pasta = new Pasta("garlic");
            pasta.Display();

            Console.WriteLine("\nMaking these dishes available.");

            var caesarAvailable = new Available(caesarSalad, 3);
            var alfredoAvailable = new Available(pasta, 4);

            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Manush");

            alfredoAvailable.OrderItem("Sally");
            alfredoAvailable.OrderItem("Francis");
            alfredoAvailable.OrderItem("Venkat");
            alfredoAvailable.OrderItem("Diana");
            alfredoAvailable.OrderItem("Dennis"); 

            caesarAvailable.Display();
            alfredoAvailable.Display();

            Console.ReadKey();
        }
    }
}