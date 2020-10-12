using System;
using UsefulPatterns.MediatorSimple.Abstraction;

namespace UsefulPatterns.MediatorSimple
{
    public class ParticipantTwo : IParticipant
    {
        public ParticipantTwo(IMediator mediator)
        {
            mediator.Subscribe<NotificationOne>(this);
            mediator.Subscribe<NotificationTwo>(this);
        }

        public void Receive(INotification notification)
        {
            switch (notification)
            {
                case NotificationOne notificationOne:
                    Console.WriteLine($"Notification with name {notificationOne.Name} has visited the participant: {nameof(ParticipantTwo)}");
                    break;
                case NotificationTwo notificationTwo:
                    Console.WriteLine($"Notification with name {notificationTwo.Name} has visited the participant: {nameof(ParticipantTwo)}");
                    break;
            }
        }
    }
}