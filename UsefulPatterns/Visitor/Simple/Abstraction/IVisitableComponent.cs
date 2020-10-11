namespace UsefulPatterns.Visitor.Simple.Abstraction
{
    public interface IVisitableComponent
    {
        void Receive(IComponentVisitor visitor);
    }
}