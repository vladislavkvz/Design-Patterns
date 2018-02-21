namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var singleton = Singleton.Instance;
            var multithreadedSingleton = MultithreadedSingleton.Instance;
        }
    }
}