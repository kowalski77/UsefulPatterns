namespace UsefulPatterns.Visitor.Simple.Abstraction
{
    public interface IVisitorService
    {
        void Register(IVisitableComponent component);
    }
}