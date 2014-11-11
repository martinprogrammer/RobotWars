using System;
using RobotWars.ConsoleApp.Data;
namespace RobotWars.ConsoleApp.Logic
{
    public interface IRobotMove
    {
        void Execute(IRobot robot);
    }
}
