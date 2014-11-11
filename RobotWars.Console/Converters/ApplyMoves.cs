using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;
using RobotWars.ConsoleApp.Logic;

namespace RobotWars.ConsoleApp.Converters
{
    public static class ApplyMoves
    {
        public static void Execute (IRobot newRobot, string input)
        {
            IList<char> moveList = input.ToList<char>();

            foreach (char ch in moveList)
            {
                IRobotMove makeMove = null;

                if (ch.ToString().ToUpper() == enumMoves.L.ToString())
                {
                    makeMove = new RobotTurnLeft();
                }
                else if (ch.ToString().ToUpper() == enumMoves.R.ToString())
                {
                    makeMove = new RobotTurnRight();
                }
                else if (ch.ToString().ToUpper() == enumMoves.M.ToString())
                {
                    makeMove = new RobotMoveByOne();
                }

                newRobot.Move(makeMove);
            }

        }
    
    }


}
