namespace UsefulPatterns.ChainOfResponsibility
{
    public class Label
    {
        private Label(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static Label FizzBuzz => new Label("FizzBuzz");

        public static Label Fizz => new Label("Fizz");

        public static Label Buzz => new Label("Buzz");

        public static Label Empty => new Label(string.Empty);
    }
}