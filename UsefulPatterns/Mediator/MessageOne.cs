namespace UsefulPatterns.Mediator
{
    public class MessageOne : IMessage
    {
        public string Value { get; set; } = nameof(MessageOne);
    }
}