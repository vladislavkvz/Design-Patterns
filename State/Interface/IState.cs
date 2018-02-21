namespace State.Interface
{
    using Entities;

    public interface IState
    {
        void DoAction(Context context);
    }
}
