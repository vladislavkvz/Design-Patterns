namespace Builder.Builder
{
    using Entities;
    using Interface;

    public class OldRobotBuilder : IRobotBuilder
    {
        public OldRobotBuilder()
        {
            robot = new Robot();
        }
        private Robot robot;

        public void BuildHead()
        {
            this.robot.Head = "Blurred Vision.";
        }

        public void BuildBody()
        {
            this.robot.Body = "Slow Software.";
        }

        public void BuildFoot()
        {
            this.robot.Foot = "Slow Walking";
        }

        public void BuildArms()
        {
            this.robot.Arm = "Good mechanisms";
        }

        public Robot MakeRobot()
        {
            return this.robot;
        }
    }
}