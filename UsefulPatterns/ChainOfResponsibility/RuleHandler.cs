namespace UsefulPatterns.ChainOfResponsibility
{
    public abstract class RuleHandler<TRequest, TResponse>
    {
        private RuleHandler<TRequest, TResponse> nextHandler;

        public RuleHandler<TRequest, TResponse> Next(RuleHandler<TRequest, TResponse> handler)
        {
            this.nextHandler = handler;

            return this.nextHandler;
        }

        public virtual TResponse Run(TRequest request) => this.nextHandler.Run(request);
    }
}