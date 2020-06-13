namespace UsefulPatterns.ChainOfResponsibility
{
    public static class FizzBuzzHandlerExtensions
    {
        public static RuleHandler<FizzBuzz, Label> UseFizz(this RuleHandler<FizzBuzz, Label> handler)
        {
            handler.Next(new FizzHandler());

            return handler;
        }

        public static RuleHandler<FizzBuzz, Label> UseBuzz(this RuleHandler<FizzBuzz, Label> handler)
        {
            handler.Next(new BuzzHandler());

            return handler;
        }

        public static RuleHandler<FizzBuzz, Label> Run(this RuleHandler<FizzBuzz, Label> handler)
        {
            handler.Next(new NoFizzBuzzHandler());

            return handler;
        }
    }
}