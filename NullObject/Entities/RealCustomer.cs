namespace NullObject.Entities
{
    public class RealCustomer : Customer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}