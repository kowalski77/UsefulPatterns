using UsefulPatterns.Visitor.Simple.Abstraction;

namespace UsefulPatterns.Visitor.Simple
{
    public class SimpleVisitorStarter
    {
        public void Run()
        {
            var visitorService = new VisitorService();
            var componentOne = new ComponentOne(visitorService);
            var componentTwo = new ComponentTwo(visitorService);

            var visitorOne = new VisitorOne();
            visitorService.Visit(visitorOne);

            var visitorTwo = new VisitorTwo();
            visitorService.Visit(visitorTwo);
        }
    }
}