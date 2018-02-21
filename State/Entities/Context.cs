namespace State.Entities
{
    using Interface;

    public class Context
    {
        private IState state;

        public Context()
        {
            state = null;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return state;
        }
    }
}