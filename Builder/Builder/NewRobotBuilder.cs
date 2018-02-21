namespace Builder.Builder
{
    using Entities;
    using Interface;

    public class NewRobotBuilder : IRobotBuilder
    {
        public NewRobotBuilder()
        {
            robot = new Robot();
        }
        private Robot robot;

        public void BuildHead()
        {
            this.robot.Head = "Clear Vision.";
        }

        public void BuildBody()
        {
            this.robot.Body = "Faster Software.";
        }

        public void BuildFoot()
        {
            this.robot.Foot = "Faster Walking";
        }

        public void BuildArms()
        {
            this.robot.Arm = "Better mechanisms";
        }

        public Robot MakeRobot()
        {
            return this.robot;
        }
    }
}