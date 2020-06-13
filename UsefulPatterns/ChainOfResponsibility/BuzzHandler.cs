namespace UsefulPatterns.ChainOfResponsibility
{
    public class BuzzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) =>
            request.Number.IsDivisibleBy(5) ?
                Label.Buzz :
                base.Run(request);
    }
}