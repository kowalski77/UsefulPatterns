namespace UsefulPatterns.Bridge.After
{
    public interface IMessageSender
    {
        void Send(string subject, string body);
    }
}