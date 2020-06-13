namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzHandler : RuleHandler<PositiveNumber, Label>
    {
        public override Label Run(PositiveNumber request) =>
            request.Number.IsDivisibleBy(3) && request.Number.IsDivisibleBy(5) ?
                Label.FizzBuzz :
                base.Run(request);
    }
}