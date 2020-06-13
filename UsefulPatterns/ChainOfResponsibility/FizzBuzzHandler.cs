namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) =>
            request.Number.IsDivisibleBy(3) && request.Number.IsDivisibleBy(5) ?
                Label.FizzBuzz :
                base.Run(request);
    }
}