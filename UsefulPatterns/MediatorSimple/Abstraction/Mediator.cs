using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace UsefulPatterns.MediatorSimple.Abstraction
{
    public class Mediator : IMediator
    {
        private static readonly ConcurrentDictionary<Type, List<IParticipant>> Participants =
            new ConcurrentDictionary<Type, List<IParticipant>>();

        public void Subscribe<TNotification>(IParticipant participant) where TNotification : INotification
        {
            var type = typeof(TNotification);
            Participants.TryAdd(type, new List<IParticipant>());
            Participants[type].Add(participant);
        }

        public void Send<TNotification>(TNotification notification) where TNotification : INotification
        {
            var existsValue = Participants.TryGetValue(typeof(TNotification), out var participants);
            if (existsValue)
            {
                foreach (var component in participants)
                {
                    component.Receive(notification);
                }
                return;
            }

            Console.WriteLine($"No registered participant for notification of type: {typeof(TNotification).Name}");
        }
    }
}