using UsefulPatterns.Singleton.Version1;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            var sing = SingletonOne.Instance;
        }
    }
}
