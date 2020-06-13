namespace UsefulPatterns.ChainOfResponsibility
{
    public class BuzzHandler : RuleHandler<PositiveNumber, Label>
    {
        public override Label Run(PositiveNumber request) =>
            request.Number.IsDivisibleBy(5) ?
                Label.Buzz :
                base.Run(request);
    }
}