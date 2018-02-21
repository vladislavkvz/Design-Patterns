namespace Prototype.Entities
{
    using Interface;

    public class Person : IPrototype
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public IPrototype Clone()
        {
            return new Person(this.Name);
        }

        public override string ToString()
        {
            return "This person name is "+this.Name;
        }
    }
}