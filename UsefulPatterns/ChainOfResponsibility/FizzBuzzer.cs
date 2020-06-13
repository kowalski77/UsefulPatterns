using System.Linq;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzer
    {
        private readonly Display display;
        private readonly IRuleHandler<PositiveNumber, Label> handler;
        private readonly int minNumber;
        private readonly int maxNumber;
        
        public FizzBuzzer(
            Display display, 
            IRuleHandler<PositiveNumber, Label> handler, 
            int minNumber, 
            int maxNumber)
        {
            this.display = display;
            this.handler = handler;
            this.minNumber = minNumber;
            this.maxNumber = maxNumber;
        }

        public void Run()
        {
            var range = Enumerable.Range(this.minNumber, this.maxNumber);
            foreach (var number in range)
            {
                var fizzBuzz = PositiveNumber.Create(number);

                var value = this.handler.Run(fizzBuzz);

                this.display.Print(number, value);
            }
        }
    }
}