namespace Mediator
{
    using Entities;

    class Program
    {
        static void Main()
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }
}