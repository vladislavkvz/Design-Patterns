namespace Builder.Builder.Interface
{
    using Entities;

    public interface IRobotBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildFoot();
        void BuildArms();
        Robot MakeRobot();
    }
}