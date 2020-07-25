namespace UsefulPatterns.AdvancedMediator
{
    public class MediatorStarter
    {
        public void Run()
        {
            var testRequest = new TestRequest
            {
                Name = "test"
            };

            var mediator = new Mediator();
            mediator.Publish(testRequest);
        }
    }
}