namespace Builder.Builder
{
    using Entities;
    using Interface;

    public class Director
    {
        public Robot Construct(IRobotBuilder builder)
        {
            builder.BuildHead();
            builder.BuildBody();
            builder.BuildArms();
            builder.BuildFoot();
            return builder.MakeRobot();
        }
    }
}