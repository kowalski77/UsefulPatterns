using UsefulPatterns.ChainOfResponsibility;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var display = new Display();
            //var handler = new FizzBuzzHandler();
            //handler
            //    .UseFizz()
            //    .UseBuzz()
            //    .Run();

            var handler = new FizzBuzzHandler();
            handler
                .Next(new FizzHandler())
                .Next(new BuzzHandler())
                .Next(new NoFizzBuzzHandler());

            var fizzBuzzer = new FizzBuzzer(display, handler);
            fizzBuzzer.Run();
        }
    }
}
