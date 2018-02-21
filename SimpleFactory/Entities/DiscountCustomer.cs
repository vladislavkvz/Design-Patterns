namespace SimpleFactory.Entities
{
    using System;

    public class DiscountCustomer : Customer
    {
        public override void Description()
        {
            Console.WriteLine("Customer with discount!");
        }
    }
}