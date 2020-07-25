namespace UsefulPatterns.AdvancedMediator
{
    public interface IMediator
    {
        void Publish<TRequest>(TRequest request) where TRequest : IRequest;
    }
}