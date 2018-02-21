namespace SimpleFactory.Factory
{
    using Entities;
    using Enums;

    public class CustomerFactory : ICustomerFactory
    {
        public Customer CreateCustomer(TypeCustomer customerType)
        {
            switch (customerType)
            {
                case TypeCustomer.DiscountCustomer: return new DiscountCustomer();
                case TypeCustomer.LoyalCustomer: return new LoyalCustomer();
                case TypeCustomer.WonderingCustomer: return new WonderingCustomer();
                default: return null;
            }
        }
    }
}