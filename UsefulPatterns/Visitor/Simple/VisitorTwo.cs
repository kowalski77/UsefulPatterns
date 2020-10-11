using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class VisitorTwo : IComponentVisitor
    {
        public string Name { get; set; } = "Two";
    }
}