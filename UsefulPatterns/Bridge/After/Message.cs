namespace UsefulPatterns.Bridge.After
{
    public abstract class Message
    {
        protected readonly IMessageSender MessageSender;

        protected Message(IMessageSender messageSender)
        {
            this.MessageSender = messageSender;
        }

        public abstract void Send(string subject, string body);
    }
}