namespace NullObject.Entities
{
    public abstract class Customer
    {
        protected string name;
        public abstract bool IsNull();
        public abstract string GetName();
    }
}