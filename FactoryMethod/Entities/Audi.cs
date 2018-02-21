namespace FactoryMethod.Entities
{
    using System;

    public class Audi : ICar
    {
        public void MakeSound()
        {
            Console.WriteLine("Tiiiiiiiiiit");
        }
    }
}