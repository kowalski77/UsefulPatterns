using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace UsefulPatterns.Visitor.Simple.Abstraction
{
    public class VisitorService : IVisitorService
    {
        private static readonly ConcurrentDictionary<Type, List<IVisitableComponent>> VisitableComponents =
            new ConcurrentDictionary<Type, List<IVisitableComponent>>();

        public void Subscribe<TVisitor>(IVisitableComponent component) where TVisitor : IComponentVisitor
        {
            var type = typeof(TVisitor);
            VisitableComponents.TryAdd(type, new List<IVisitableComponent>());
            VisitableComponents[type].Add(component);
        }

        public void Visit<TVisitor>(TVisitor visitor) where TVisitor : IComponentVisitor
        {
            var existsValue = VisitableComponents.TryGetValue(typeof(TVisitor), out var components);
            if (existsValue)
            {
                foreach (var component in components)
                {
                    component.Receive(visitor);
                }
                return;
            }

            Console.WriteLine($"No visitable component for visitor of type: {typeof(TVisitor).Name}");
        }
    }
}