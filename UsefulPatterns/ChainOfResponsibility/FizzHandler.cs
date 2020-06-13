namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) => 
            request.IsFizz ? 
                Label.Fizz : 
                base.Run(request);
    }
}