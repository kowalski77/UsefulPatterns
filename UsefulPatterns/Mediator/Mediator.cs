using System;
using System.Collections.Generic;

namespace UsefulPatterns.Mediator
{
    public class Mediator : IMediator
    {
        private readonly IDictionary<Type, IList<IParticipant>> participants
            = new Dictionary<Type, IList<IParticipant>>();

        public void Register(IParticipant participant)
        {
            var type = participant.GetType();
            this.participants.TryAdd(type, new List<IParticipant>());

            this.participants[type].Add(participant);
        }

        public void Send<TType>(IMessage message) where TType : IParticipant
        {
            var existsValue = this.participants.TryGetValue(typeof(TType), out var participantsList);
            if (!existsValue)
            {
                return;
            }

            foreach (var participant in participantsList)
            {
                participant.Receive(message);
            }
        }
    }
}