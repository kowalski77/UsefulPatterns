using System;
using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class ComponentTwo : IVisitableComponent
    {
        public void Receive(IComponentVisitor visitor)
        {
            if (visitor is VisitorOne visitorOne)
            {
                Console.WriteLine($"Visitor with name: {visitorOne.Name} visited: {nameof(ComponentTwo)}");
            }
        }
    }
}