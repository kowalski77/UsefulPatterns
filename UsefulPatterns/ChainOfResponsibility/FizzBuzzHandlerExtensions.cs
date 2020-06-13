namespace UsefulPatterns.ChainOfResponsibility
{
    public static class FizzBuzzHandlerExtensions
    {
        public static RuleHandler<PositiveNumber, Label> UseFizz(this RuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new FizzHandler());

            return handler;
        }

        public static RuleHandler<PositiveNumber, Label> UseBuzz(this RuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new BuzzHandler());

            return handler;
        }

        public static RuleHandler<PositiveNumber, Label> Run(this RuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new NoFizzBuzzHandler());

            return handler;
        }
    }
}