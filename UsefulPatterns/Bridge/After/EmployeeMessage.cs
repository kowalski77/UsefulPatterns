namespace UsefulPatterns.Bridge.After
{
    public class EmployeeMessage : Message
    {
        public EmployeeMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send(string subject, string body)
        {
            this.MessageSender.Send(subject, body);
        }
    }
}