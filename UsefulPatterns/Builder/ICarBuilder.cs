namespace UsefulPatterns.Builder
{
    public interface ICarBuilder
    {
        ICarBuilder AddExtraPower();
        ICarBuilder ChangeEngine();
        ICar Build();
    }
}