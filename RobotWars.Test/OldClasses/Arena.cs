using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Test.RobotTests
{
    public class Arena : RobotWars.Test.RobotTests.IArena
    {
        public int maxX { get; set; }
        public int maxY{get;set;}
        private IList<IRobot> robots;
        
        public Arena(int x, int y)
        {
            maxX = x;
            maxY = y;
            robots = new List<IRobot>();
        }

        public Arena()
        {
            robots = new List<IRobot>();
        }

        public void Add(IRobot robot)
        {
            robots.Add(robot);
        }

        public string ReturnArenaSize()
        {
            return this.maxX + " " + this.maxY;
        }

        public IRobot ReturnRobotByName(string robotName)
        {
            return robots.SingleOrDefault(p => p._name == robotName);
        }

        public IEnumerable<IRobot> GetRobots()
        {
            return robots;
        }
        
    }
}
