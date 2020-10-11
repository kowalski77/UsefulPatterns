using System;
using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class ComponentTwo : IVisitableComponent
    {
        public ComponentTwo(IVisitorService visitorService)
        {
            visitorService.Subscribe<VisitorOne>(this);
            visitorService.Subscribe<VisitorTwo>(this);
        }

        public void Receive(IComponentVisitor visitor)
        {
            switch (visitor)
            {
                case VisitorOne visitorOne:
                    Console.WriteLine($"Visitor with name {visitorOne.Name} has visited the component: {nameof(ComponentTwo)}");
                    break;
                case VisitorTwo visitorTwo:
                    Console.WriteLine($"Visitor with name {visitorTwo.Name} has visited the component: {nameof(ComponentTwo)}");
                    break;
            }
        }
    }
}