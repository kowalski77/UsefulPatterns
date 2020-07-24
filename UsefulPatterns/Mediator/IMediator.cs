using System;

namespace UsefulPatterns.Mediator
{
    public interface IMediator
    {
        void Register(IParticipant participant);
        void Send<TMessage>(TMessage message, Type type) where TMessage : IMessage;
    }
}