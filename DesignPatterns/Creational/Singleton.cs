using System;

namespace DesignPatterns.Creational
{
    sealed class SingletonBasic
    {
        private static SingletonBasic instance = null;
        private static readonly object padlock = new object();

        private SingletonBasic() {}

        public static SingletonBasic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonBasic();
                        }
                    }
                }
                return instance;
            }
        }
    }

    sealed class SingletonNonLazy
    {
        private static readonly SingletonNonLazy instance = new SingletonNonLazy();

        static SingletonNonLazy() { }

        private SingletonNonLazy() { }

        public static SingletonNonLazy Instance
        {
            get
            {
                return instance;
            }
        }
    }

    sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton() { }
    }
}