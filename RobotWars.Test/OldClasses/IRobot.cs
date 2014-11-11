using System;
namespace RobotWars.Test.RobotTests
{
    public interface IRobot
    {
        string _name { get; set; }
        string facing { get; set; }
        int locX { get; set; }
        int locY { get; set; }
        void Move(IRobotMove moveAlgo);
        string ReturnLocation();
    }
}
