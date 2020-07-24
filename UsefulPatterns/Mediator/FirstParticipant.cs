using System;

namespace UsefulPatterns.Mediator
{
    public class FirstParticipant : IParticipant
    {
        public string Name { get; set; }

        public void Receive(IMessage message)
        {
            Console.WriteLine($"I'm {nameof(FirstParticipant)} with name: {this.Name}, Message received: {message.Value}");
        }
    }
}