using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.Test.RobotTests
{
    class InputToRobot
    {
        public IRobot Execute(string input)
        {
            IRobot _robot;
            int id = 0;

            try
            {
                string[] newString = input.Split(' ');
                _robot = new Robot();

                if (!int.TryParse(newString[0], out id))
                {
                    throw new InvalidCastException("not an integer");
                }
                else
                {
                    _robot.locX = Convert.ToInt32(newString[0]);
                }

                if (!int.TryParse(newString[1], out id))
                {
                    throw new InvalidCastException("not an integer");
                }
                else
                {
                    _robot.locY = Convert.ToInt32(newString[1]);
                }

                if (!Enum.IsDefined(typeof(enumFacing), newString[2].ToUpper()))
                {
                    throw new InvalidCastException("not a valid compass point");
                }
                else
                {
                    _robot.facing = newString[2].ToUpper();
                }

                return _robot;
            }
            catch
            {
                throw new Exception("InputToRobot creation not successful");
            }
   
        }
    }
}
