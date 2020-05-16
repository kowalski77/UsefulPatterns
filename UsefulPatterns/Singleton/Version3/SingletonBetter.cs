namespace UsefulPatterns.Singleton.Version3
{
    //Much better code
    public class SingletonBetter
    {
        private SingletonBetter() { }

        public static SingletonBetter Instance { get; } = new SingletonBetter();
    }
}