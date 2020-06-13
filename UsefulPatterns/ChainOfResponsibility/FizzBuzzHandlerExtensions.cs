namespace UsefulPatterns.ChainOfResponsibility
{
    public static class FizzBuzzHandlerExtensions
    {
        public static IRuleHandler<PositiveNumber, Label> UseFizz(this IRuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new FizzHandler());

            return handler;
        }

        public static IRuleHandler<PositiveNumber, Label> UseBuzz(this IRuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new BuzzHandler());

            return handler;
        }

        public static IRuleHandler<PositiveNumber, Label> Build(this IRuleHandler<PositiveNumber, Label> handler)
        {
            handler.Next(new NoFizzBuzzHandler());

            return handler;
        }
    }
}