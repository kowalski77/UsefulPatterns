namespace UsefulPatterns.Visitor.Simple.Abstraction
{
    public interface IVisitorService
    {
        void Subscribe<TVisitor>(IVisitableComponent component) where TVisitor : IComponentVisitor;
        void Visit<TVisitor>(TVisitor visitor) where TVisitor : IComponentVisitor;
    }
}