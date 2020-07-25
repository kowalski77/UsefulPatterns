namespace UsefulPatterns.AdvancedMediator
{
    public interface IRequestHandler<in TRequest> where TRequest : IRequest
    {
        void Handle(TRequest request);
    }
}