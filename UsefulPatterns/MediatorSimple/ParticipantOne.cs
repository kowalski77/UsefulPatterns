using System;
using UsefulPatterns.MediatorSimple.Abstraction;

namespace UsefulPatterns.MediatorSimple
{
    public class ParticipantOne : IParticipant
    {
        public ParticipantOne(IMediator mediator)
        {
            mediator.Subscribe<NotificationOne>(this);
        }

        public void Receive(INotification notification)
        {
            if (notification is NotificationOne notificationOne)
            {
                Console.WriteLine($"Notification with name {notificationOne.Name} has visited the participant: {nameof(ParticipantOne)}");
            }
        }
    }
}