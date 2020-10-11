using System;
using System.Collections.Concurrent;

namespace UsefulPatterns.Visitor.Simple.Abstraction
{
    public class VisitorService : IVisitorService
    {
        private static readonly ConcurrentDictionary<Type, IVisitableComponent> VisitableComponents =
            new ConcurrentDictionary<Type, IVisitableComponent>();

        public void Register(IVisitableComponent component)
        {
            var type = component.GetType();
            VisitableComponents.TryAdd(type, component);
        }

        public void Visit<TVisitable>(IComponentVisitor visitor) where TVisitable : IVisitableComponent
        {
            var existsValue = VisitableComponents.TryGetValue(typeof(TVisitable), out var component);
            if (existsValue)
            {
                component.Receive(visitor);
                return;
            }

            Console.WriteLine($"No visitable component for visitor of type: {visitor.GetType().Name}");
        }
    }
}