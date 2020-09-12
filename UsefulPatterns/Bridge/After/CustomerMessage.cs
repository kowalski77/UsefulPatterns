namespace UsefulPatterns.Bridge.After
{
    public class CustomerMessage : Message
    {
        public CustomerMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send(string subject, string body)
        {
            this.MessageSender.Send(subject, body);
        }
    }
}
