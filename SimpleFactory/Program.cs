namespace SimpleFactory
{
    using Entities;
    using Enums;
    using Factory;

    class Program
    {
        static void Main(string[] args)
        {
            ICustomerFactory factory = new CustomerFactory();
            Customer customer = factory.CreateCustomer(TypeCustomer.LoyalCustomer);
            customer.Description();
        }
    }
}