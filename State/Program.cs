namespace State
{
    using Entities;
    using System;

    class Program
    {
        static void Main()
        {
            Context context = new Context();

            StartState startState = new StartState(); startState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());

            StopState stopState = new StopState(); stopState.DoAction(context);
            Console.WriteLine(context.GetState().ToString());
        }
    }
}