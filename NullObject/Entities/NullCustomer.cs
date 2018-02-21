namespace NullObject.Entities
{
    public class NullCustomer : Customer
    {
        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}