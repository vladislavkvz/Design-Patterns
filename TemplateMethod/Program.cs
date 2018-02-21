namespace TemplateMethod
{
    using Entities;

    class Program
    {
        static void Main()
        {
            Generalization algorithm = new Realization();
            algorithm.FindSolution();
        }
    }
}