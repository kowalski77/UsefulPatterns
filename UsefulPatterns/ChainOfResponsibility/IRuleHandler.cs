namespace UsefulPatterns.ChainOfResponsibility
{
    public interface IRuleHandler<TRequest, TResponse>
    {
        IRuleHandler<TRequest, TResponse> Next(IRuleHandler<TRequest, TResponse> handler);
        TResponse Run(TRequest request);
    }
}