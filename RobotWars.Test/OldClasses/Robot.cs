using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Test.RobotTests
{
    public class Robot : RobotWars.Test.RobotTests.IRobot
    {
        public string _name { get; set; }
        public int locX { get; set; }
        public int locY { get; set; }
        public string facing { get; set; }
        

        public Robot(string name)
        {
            this._name = name;
        }

        public Robot()
        {
        }

        public void Move(IRobotMove moveAlgo)
        {
            moveAlgo.Execute(this);
        }

        public string ReturnLocation()
        {
            return this.locX + " " + this.locY + " " + this.facing;
        }

    }
}
