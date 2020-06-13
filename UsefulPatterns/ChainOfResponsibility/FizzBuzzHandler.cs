namespace UsefulPatterns.ChainOfResponsibility
{
    public class FizzBuzzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) =>
            request.IsFizzBuzz ?
                Label.FizzBuzz :
                base.Run(request);
    }
}