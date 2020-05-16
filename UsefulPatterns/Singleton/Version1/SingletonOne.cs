namespace UsefulPatterns.Singleton.Version1
{
    //Bad code
    public sealed class SingletonOne
    {
        private static SingletonOne instance;

        private SingletonOne() { }

        public static SingletonOne Instance => instance ??= new SingletonOne();
    }
}