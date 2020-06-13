using UsefulPatterns.ChainOfResponsibility;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var fizzBuzzer = new FizzBuzzer(new Display());
            fizzBuzzer.Run();
        }
    }
}
