using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Test.RobotTests
{
    public class RobotMoveByOne: IRobotMove
    {
      
        
        public void Execute(IRobot robot)
        {
            switch (robot.facing)
            {
                case "N":
                    robot.locY += 1;
                    break;

                case "E":
                    robot.locX += 1;
                    break;

                case "S":
                    robot.locY -= 1;
                    break;

                case "W":
                    robot.locX -= 1;
                    break;
            }
           
        }
    }
}
