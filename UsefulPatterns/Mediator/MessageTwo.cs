namespace UsefulPatterns.Mediator
{
    public class MessageTwo : IMessage
    {
        public string Value { get; set; } = nameof(MessageTwo);
    }
}