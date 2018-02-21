namespace Visitor
{
    using Entities;
    using Interfaces;

    class Program
    {
        static void Main()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}