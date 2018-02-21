namespace Observer.Entities
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}