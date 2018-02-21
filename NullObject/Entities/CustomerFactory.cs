namespace NullObject.Entities
{
    public class CustomerFactory
    {
        public static string[] names = { "Rob", "Joe", "Julie" };

        public static Customer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}