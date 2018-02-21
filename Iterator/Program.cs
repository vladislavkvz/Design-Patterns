namespace Iterator
{
    using Interfaces;
    using System;

    class Program
    {
        static void Main()
        {
            NameRepository namesRepository = new NameRepository();

            IIterator iter = namesRepository.GetIterator();
            while (iter.HasNext())
            {
                string name = (string)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}