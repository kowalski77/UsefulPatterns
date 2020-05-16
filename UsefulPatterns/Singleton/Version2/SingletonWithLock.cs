namespace UsefulPatterns.Singleton.Version2
{
    //Better code
    public sealed class SingletonWithLock
    {
        private static SingletonWithLock instance;
        private static readonly object PadLock = new object();

        private SingletonWithLock() { }

        public static SingletonWithLock Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }

                lock (PadLock)
                {
                    instance = new SingletonWithLock();
                }

                return instance;
            }
        }
    }
}