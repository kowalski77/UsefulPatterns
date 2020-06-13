namespace UsefulPatterns.ChainOfResponsibility
{
    public class BuzzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) =>
            request.IsBuzz ?
                Label.Buzz :
                base.Run(request);
    }
}