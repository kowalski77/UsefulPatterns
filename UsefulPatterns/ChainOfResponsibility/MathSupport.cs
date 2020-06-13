namespace UsefulPatterns.ChainOfResponsibility
{
    public static class MathSupport
    {
        public static bool IsDivisibleBy(this int number, int value) => number % value == 0;
    }
}