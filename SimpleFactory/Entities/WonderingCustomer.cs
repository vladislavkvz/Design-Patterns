namespace SimpleFactory.Entities
{
    using System;

    public class WonderingCustomer : Customer
    {
        public override void Description()
        {
            Console.WriteLine("Customer who doesn't know to buy or not...");
        }
    }
}