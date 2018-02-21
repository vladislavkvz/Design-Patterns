namespace SimpleFactory.Entities
{
    using System;

    public class LoyalCustomer : Customer
    {
        public override void Description()
        {
            Console.WriteLine("Loyal customer!");
        }
    }
}