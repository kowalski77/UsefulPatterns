namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzHandler : RuleHandler<PositiveNumber, Label>
    {
        public override Label Run(PositiveNumber request) => 
            request.Number.IsDivisibleBy(3) ? 
                Label.Fizz : 
                base.Run(request);
    }
}