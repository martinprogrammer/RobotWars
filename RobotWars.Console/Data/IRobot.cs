using System;
using RobotWars.ConsoleApp.Logic;
namespace RobotWars.ConsoleApp.Data
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
