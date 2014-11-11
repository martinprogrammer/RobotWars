using System;
using System.Collections.Generic;

namespace RobotWars.ConsoleApp.Data
{
    public interface IArena
    {
        void Add(IRobot robot);
        int maxX { get; set; }
        int maxY { get; set; }
        string ReturnArenaSize();
        IRobot ReturnRobotByName(string robotName);
        IEnumerable<IRobot> GetRobots();
    }
}
