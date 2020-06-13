namespace UsefulPatterns.ChainOfResponsibility
{
    public abstract class RuleHandler<TRequest, TResponse> : IRuleHandler<TRequest, TResponse>
    {
        private IRuleHandler<TRequest, TResponse> nextHandler;

        public IRuleHandler<TRequest, TResponse> Next(IRuleHandler<TRequest, TResponse> handler)
        {
            this.nextHandler = handler;

            return this.nextHandler;
        }

        public virtual TResponse Run(TRequest request) => this.nextHandler.Run(request);
    }
}