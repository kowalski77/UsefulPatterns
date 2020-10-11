﻿using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class SimpleVisitorStarter
    {
        public void Run()
        {
            var visitorService = new VisitorService();

            var componentTwo = new ComponentTwo();
            visitorService.Register(componentTwo);
            var visitorOne = new VisitorOne();
            var visitorTwo = new VisitorTwo();

            visitorService.Visit<ComponentTwo>(visitorTwo);
        }
    }
}