namespace ObjectPool
{
    using Entities;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<MyClass> objPool = new ObjectPool<MyClass>();
            MyClass obj = objPool.Get();
            objPool.Release(obj);
            Console.Read();
        }
    }
}