namespace FactoryMethod.Entities
{
    using System;

    public class Mercedes : ICar
    {
        public void MakeSound()
        {
            Console.WriteLine("Beeeeeep");
        }
    }
}