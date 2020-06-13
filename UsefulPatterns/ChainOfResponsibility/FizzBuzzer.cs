using System.Linq;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzer
    {
        private readonly Display display;
        private readonly IRuleHandler<PositiveNumber, Label> handler;

        public FizzBuzzer(
            Display display, 
            IRuleHandler<PositiveNumber, Label> handler)
        {
            this.display = display;
            this.handler = handler;
        }

        public void Run()
        {
            var range = Enumerable.Range(1, 100);
            foreach (var number in range)
            {
                var fizzBuzz = PositiveNumber.Create(number);

                var value = this.handler.Run(fizzBuzz);

                this.display.Print(number, value);
            }
        }
    }
}