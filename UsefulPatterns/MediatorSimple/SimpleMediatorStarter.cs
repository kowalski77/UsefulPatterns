using UsefulPatterns.MediatorSimple.Abstraction;

namespace UsefulPatterns.MediatorSimple
{
    public class SimpleMediatorStarter
    {
        public void Run()
        {
            var mediator = new Mediator();
            var componentOne = new ParticipantOne(mediator);
            var componentTwo = new ParticipantTwo(mediator);

            var visitorOne = new NotificationOne();
            mediator.Send(visitorOne);

            var visitorTwo = new NotificationTwo();
            mediator.Send(visitorTwo);
        }
    }
}