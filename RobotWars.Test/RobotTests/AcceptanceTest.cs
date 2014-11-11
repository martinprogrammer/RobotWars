using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RobotWars.ConsoleApp.Data;
using RobotWars.ConsoleApp.Converters;

namespace RobotWars.Test.RobotTests
{
    [TestFixture]
    public class AcceptanceTest
    {
        [Test]
        public void TestAcceptanceCriteria()
        {
            string inputArena = "5 5";
            string inputRobot1 = "1 2 N";
            string inputMovementRobot1 = "LMLMLMLMM";
           
            IArena _arena = InputToArena.Execute(inputArena);
            IRobot _robot1 = InputToRobot.Execute(inputRobot1);
            ApplyMoves.Execute(_robot1, inputMovementRobot1);

            Assert.AreEqual("1 3 N", _robot1.ReturnLocation());

            inputRobot1 = "3 3 E";
            inputMovementRobot1 = "MMRMMRMRRM";

            _robot1 = InputToRobot.Execute(inputRobot1);
            ApplyMoves.Execute(_robot1, inputMovementRobot1);

            Assert.AreEqual("5 1 E", _robot1.ReturnLocation());
        }

    }
}
