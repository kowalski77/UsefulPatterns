namespace UsefulPatterns.ChainOfResponsibility
{
    public readonly struct FizzBuzzRange
    {
        public int Min { get; }
        public int Max { get; }

        public FizzBuzzRange(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}