using System;
using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class ComponentOne : IVisitableComponent
    {
        public ComponentOne(IVisitorService visitorService)
        {
            visitorService.Subscribe<VisitorOne>(this);
        }

        public void Receive(IComponentVisitor visitor)
        {
            if (visitor is VisitorOne visitorOne)
            {
                Console.WriteLine($"Visitor with name {visitorOne.Name} has visited the component: {nameof(ComponentOne)}");
            }
        }
    }
}