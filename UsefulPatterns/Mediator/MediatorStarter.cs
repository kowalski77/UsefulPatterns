using System;

namespace UsefulPatterns.Mediator
{
    public class MediatorStarter
    {
        public void Run()
        {
            var mediator = new Mediator();
            var firstParticipant1 = new FirstParticipant {Name = "One"};
            var firstParticipant2 = new FirstParticipant {Name = "Two"};
            var secondParticipant = new SecondParticipant();

            mediator.Register(firstParticipant1);
            mediator.Register(firstParticipant2);
            mediator.Register(secondParticipant);

            var message1 = new MessageOne();
            mediator.Send(message1, typeof(FirstParticipant));

            Console.ReadKey();
        }
    }
}