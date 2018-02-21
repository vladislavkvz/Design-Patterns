namespace State.Entities
{
    using Interface;
    using System;

    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);
        }
        public string toString()
        {
            return "Stop State";
        }
    }
}