using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;
using RobotWars.ConsoleApp.Validation;
using RobotWars.ConsoleApp.Logic;
using RobotWars.ConsoleApp.Converters;

namespace RobotWars.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IArena _arena;
            IRobot newRobot;
            string input;
            
            Console.WriteLine("Please enter the size of the arena X x Y:");

            input = Console.ReadLine();
            while (!ValidationService.IsArenaDimensionValid(false, input))
            {
                Console.WriteLine("ERROR: Please enter valid numerical value separated by a space character!");
                input = Console.ReadLine();
            }
            
            _arena = InputToArena.Execute(input);

            for(int x = 0; x<2; x++)
            {
                Console.WriteLine("Enter robot's co-ordinates and facing separated by a space character");

                input = Console.ReadLine();
                while (!ValidationService.IsInputValidLocation(input))
                {
                    Console.WriteLine("ERROR: Enter robot's co-ordinates and facing separated by a space character");
                    input = Console.ReadLine();
                }

                newRobot = InputToRobot.Execute(input);
                _arena.Add(newRobot);

                Console.WriteLine("Enter robot moves - only valid characters without space");

                input = Console.ReadLine();
                while(!ValidationService.IsInputValidMoveInstruction(input))
                {
                    Console.WriteLine("ERROR: Invalid move entry.  Please try again");
                    input = Console.ReadLine();
                }


                ApplyMoves.Execute(newRobot, input);
            }

            Console.WriteLine("Press any key to see the results");
            Console.Read();
            foreach (IRobot robot in _arena.GetRobots())
            {
                Console.WriteLine(robot.ReturnLocation());
            }

            Console.Read();
            Console.Read();
        }

       
    }
}
