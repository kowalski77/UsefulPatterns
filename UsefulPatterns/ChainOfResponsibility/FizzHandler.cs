namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) => 
            request.Number.IsDivisibleBy(3) ? 
                Label.Fizz : 
                base.Run(request);
    }
}