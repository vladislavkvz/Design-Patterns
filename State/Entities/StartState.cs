namespace State.Entities
{
    using Interface;
    using System;

    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }
        public string toString()
        {
            return "Start State";
        }
    }
}