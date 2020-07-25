using System;

namespace UsefulPatterns.AdvancedMediator
{
    public class TestRequestHandlerTwo : IRequestHandler<TestRequest>
    {
        public void Handle(TestRequest request)
        {
            Console.WriteLine($"Request received in handler two with name: {request.Name}");
        }
    }
}