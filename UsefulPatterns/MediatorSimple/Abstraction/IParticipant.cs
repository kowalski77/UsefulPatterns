namespace UsefulPatterns.MediatorSimple.Abstraction
{
    public interface IParticipant
    {
        void Receive(INotification notification);
    }
}