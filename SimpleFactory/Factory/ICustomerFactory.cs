namespace SimpleFactory.Factory
{
    using Entities;
    using Enums;

    interface ICustomerFactory
    {
        Customer CreateCustomer(TypeCustomer customerType);
    }
}