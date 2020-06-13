using System.Linq;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzer
    {
        private readonly Display display;
        private readonly IRuleHandler<PositiveNumber, Label> handler;
        private readonly FizzBuzzRange fizzBuzzRange;

        
        public FizzBuzzer(
            Display display, 
            IRuleHandler<PositiveNumber, Label> handler, 
            FizzBuzzRange fizzBuzzRange)
        {
            this.display = display;
            this.handler = handler;
            this.fizzBuzzRange = fizzBuzzRange;
        }

        public void Run()
        {
            var range = Enumerable.Range(this.fizzBuzzRange.Min, this.fizzBuzzRange.Max);
            foreach (var number in range)
            {
                var fizzBuzz = PositiveNumber.Create(number);

                var value = this.handler.Run(fizzBuzz);

                this.display.Print(number, value);
            }
        }
    }
}