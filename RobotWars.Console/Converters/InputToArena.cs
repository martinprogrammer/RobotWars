using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.ConsoleApp.Converters
{
    public static class InputToArena
    {
        public static IArena Execute(string input)
        {
            IArena _arena;
            int id = 0;

            try
            {
                string[] newString = input.Split(' ');
                _arena = new Arena();

                if (!int.TryParse(newString[0], out id))
                {
                    throw new InvalidCastException("not an integer");
                }
                else
                {
                    _arena.maxX = Convert.ToInt32(newString[0]);
                }

                if (!int.TryParse(newString[1], out id))
                {
                    throw new InvalidCastException("not an integer");
                }
                else
                {
                    _arena.maxY = Convert.ToInt32(newString[1]);
                }

                return _arena;
            }
            catch
            {
                throw new Exception("InputToArena creation not successful");
            }
   
        }
    }
}
