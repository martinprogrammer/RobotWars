using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.ConsoleApp.Logic
{
    public class RobotMoveByOne: IRobotMove
    {
        public void Execute(IRobot robot)
        {

            if (robot.facing == enumFacing.N.ToString())
            {
                robot.locY += 1;
            }
            else if (robot.facing == enumFacing.E.ToString())
            {
                robot.locX += 1;
            }
            else if (robot.facing == enumFacing.S.ToString())
            {
                robot.locY -= 1;
            }
            else if (robot.facing == enumFacing.W.ToString())
            {
                robot.locX -= 1;
            }
           
        }
    }
}
