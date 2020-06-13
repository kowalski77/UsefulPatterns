using System.Linq;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzer
    {
        private readonly Display display;
        private readonly IRuleHandler<FizzBuzz, Label> handler;

        public FizzBuzzer(Display display, IRuleHandler<FizzBuzz, Label> handler)
        {
            this.display = display;
            this.handler = handler;
        }

        public void Run()
        {
            var range = Enumerable.Range(1, 100);
            foreach (var number in range)
            {
                var fizzBuzz = FizzBuzz.Create(number);

                var value = this.handler.Run(fizzBuzz);

                this.display.Print(number, value);
            }
        }
    }
}