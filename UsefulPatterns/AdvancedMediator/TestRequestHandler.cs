using System;

namespace UsefulPatterns.AdvancedMediator
{
    public class TestRequestHandler : IRequestHandler<TestRequest>
    {
        public void Handle(TestRequest request)
        {
            Console.WriteLine($"Request received in handler one with name: {request.Name}");
        }
    }
}