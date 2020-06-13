using System.Linq;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzer
    {
        private readonly Display display;

        public FizzBuzzer(Display display)
        {
            this.display = display;
        }

        public void Run()
        {
            var range = Enumerable.Range(1, 100);

            var handler = new FizzBuzzHandler();
            handler
                .Next(new FizzHandler())
                .Next(new BuzzHandler())
                .Next(new NoFizzBuzzHandler());

            foreach (var number in range)
            {
                var fizzBuzz = FizzBuzz.Create(number);

                var value = handler.Run(fizzBuzz);

                this.display.Print(number, value);
            }
        }
    }
}