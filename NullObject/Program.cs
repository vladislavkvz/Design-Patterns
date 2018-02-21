namespace NullObject
{
    using Entities;
    using System;

    class Program
    {
        static void Main()
        {
            Customer customer1 = CustomerFactory.GetCustomer("Rob");
            Customer customer2 = CustomerFactory.GetCustomer("Bob");
            Customer customer3 = CustomerFactory.GetCustomer("Julie");
            Customer customer4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers");
            Console.WriteLine(customer1.GetName());
            Console.WriteLine(customer2.GetName());
            Console.WriteLine(customer3.GetName());
            Console.WriteLine(customer4.GetName());
        }
    }
}