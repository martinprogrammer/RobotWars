﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.ConsoleApp.Logic
{
    public class RobotTurnLeft : IRobotMove
    {
        public void Execute(IRobot robot)
        {
            enumFacing resultEnum = new enumFacing();
            
            foreach(enumFacing x in Enum.GetValues(typeof(enumFacing)))
            {
                if (robot.facing == x.ToString())
                {
                    if ((int)x == 0)
                    {
                        resultEnum= enumFacing.W;
                    }
                    else
                    {
                        resultEnum = (enumFacing)Enum.Parse(typeof(enumFacing), ((int)x-1).ToString());
                    }
                }
            }

            robot.facing = resultEnum.ToString();
        }
    }
}
