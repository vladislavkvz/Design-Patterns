namespace Singleton
{
    using System;

    public sealed class MultithreadedSingleton
    {
        private MultithreadedSingleton() { }

        private static volatile MultithreadedSingleton instance;
        private static object syncRoot = new Object();

        public static MultithreadedSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new MultithreadedSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}