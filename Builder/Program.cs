namespace Builder
{
    using Builder;
    using Entities;
    using System;

    class Program
    {
        static void Main()
        {
            Director director = new Director();
            Robot robot = director.Construct(new NewRobotBuilder());
            Console.WriteLine(robot.Head);
            Console.WriteLine(robot.Body);
            Console.WriteLine(robot.Arm);
            Console.WriteLine(robot.Foot);
        }
    }
}