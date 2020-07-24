using System;

namespace UsefulPatterns.Mediator
{
    public class SecondParticipant : IParticipant
    {
        public void Receive(IMessage message)
        {
            Console.WriteLine($"I'm {nameof(SecondParticipant)}, Message received: {message.Value}");
        }
    }
}