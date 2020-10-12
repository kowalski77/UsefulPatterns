namespace UsefulPatterns.MediatorSimple.Abstraction
{
    public interface IMediator
    {
        void Subscribe<TNotification>(IParticipant participant) where TNotification : INotification;
        void Send<TNotification>(TNotification notification) where TNotification : INotification;
    }
}