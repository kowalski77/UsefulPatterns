using System;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class PositiveNumber
    {
        public int Number { get; }

        private PositiveNumber(int number)
        {
            this.Number = number;
        }

        public static PositiveNumber Create(int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Number must be positive.");
            }

            return new PositiveNumber(number);
        }
    }
}