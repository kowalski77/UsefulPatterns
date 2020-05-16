using System;

namespace UsefulPatterns.Singleton.Version4
{
    //Much better code and Lazy
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> Lazy = new Lazy<SingletonLazy>(()=> new SingletonLazy());

        private SingletonLazy() { }

        public static SingletonLazy Instance => Lazy.Value;
    }
}