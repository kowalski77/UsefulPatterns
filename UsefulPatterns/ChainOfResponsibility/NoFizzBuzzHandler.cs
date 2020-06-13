namespace UsefulPatterns.ChainOfResponsibility
{
    public class NoFizzBuzzHandler : RuleHandler<PositiveNumber, Label>
    {
        public override Label Run(PositiveNumber request) => Label.Empty;
    }
}