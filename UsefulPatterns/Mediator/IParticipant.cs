namespace UsefulPatterns.Mediator
{
    public interface IParticipant
    {
        void Receive(IMessage message);
    }
}