namespace Prototype
{
    using Entities;
    using System;

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Vladislav");
            Console.WriteLine("Person 1: " + person1);
            Person person2 = (Person)person1.Clone();
            Console.WriteLine("Person 2: " + person2);

            Dog dog1 = new Dog("Woof");
            Console.WriteLine("Dog 1: " + dog1);
            Dog dog2 = (Dog)dog1.Clone();
            Console.WriteLine("Dog 2: " + dog2);
        }
    }
}