namespace UsefulPatterns.Builder
{
    public interface ICar
    {
        Engine Engine { get; }
        double Power { get; }

        void ChangeEngine(Engine engine);
        void IncreasePower(double value);

        string Debug();
    }
}