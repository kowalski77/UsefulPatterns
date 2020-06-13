namespace UsefulPatterns.ChainOfResponsibility
{
    public class NoFizzBuzzHandler : RuleHandler<FizzBuzz, Label>
    {
        public override Label Run(FizzBuzz request) => Label.Empty;
    }
}