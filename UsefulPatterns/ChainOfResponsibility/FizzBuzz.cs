using System;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzz
    {
        private readonly int number;

        private FizzBuzz(int number)
        {
            this.number = number;
        }

        public bool IsFizz => this.Mod(3) == 0;

        public bool IsBuzz => this.Mod(5) == 0;

        public bool IsFizzBuzz => this.IsFizz && this.IsBuzz;

        public static FizzBuzz Create(int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Number must be positive.");
            }

            return new FizzBuzz(number);
        }

        private int Mod(int value) => this.number % value;
    }
}