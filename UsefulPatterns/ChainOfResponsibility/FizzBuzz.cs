using System;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzz
    {
        public int Number { get; }

        private FizzBuzz(int number)
        {
            this.Number = number;
        }

        public static FizzBuzz Create(int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Number must be positive.");
            }

            return new FizzBuzz(number);
        }
    }
}