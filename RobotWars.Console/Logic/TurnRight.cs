using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.ConsoleApp.Logic
{
    public class TurnRight
    {

        public string Execute(string facing)
        {

            enumFacing resultEnum = new enumFacing();
            string result;

            foreach (enumFacing x in Enum.GetValues(typeof(enumFacing)))
            {
                if (facing == x.ToString())
                {
                    if ((int)x == 3)
                    {
                        resultEnum = enumFacing.N;
                        break;
                    }
                    else
                    {
                        resultEnum = (enumFacing)Enum.Parse(typeof(enumFacing), ((int)x + 1).ToString());
                        break;
                    }
                }

            }

            result = resultEnum.ToString();
            return result;



        }
    }
}
