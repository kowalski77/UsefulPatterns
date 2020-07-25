namespace UsefulPatterns.Mediator
{
    public interface IMediator
    {
        void Register(IParticipant participant);
        void Send<TType>(IMessage message) where TType : IParticipant;
    }
}