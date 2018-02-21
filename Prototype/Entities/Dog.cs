namespace Prototype.Entities
{
    using Interface;

    public class Dog: IPrototype
    {
        public Dog(string sound)
        {
            this.Sound = sound;
        }
        public string Sound { get; set; }

        public IPrototype Clone()
        {
            return new Dog(this.Sound);
        }

        public override string ToString()
        {
            return "This dog says " + this.Sound;
        }
    }
}