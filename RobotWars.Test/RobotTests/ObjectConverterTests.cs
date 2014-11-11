using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RobotWars.ConsoleApp;
using RobotWars.ConsoleApp.Converters;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.Test.RobotTests
{
    [TestFixture]
    public class ObjectConverterTests
    {
        [Test]
        public void InputToArenaTest()
        {
            string input;

            input = "3 8";
            IArena result = InputToArena.Execute(input);
            Assert.AreEqual("3 8", result.ReturnArenaSize());
        }

        
        [Test]
        public void InputToRobotTest()
        {
            string input;
            IRobot result;

            input = "1 2 N";
            result = InputToRobot.Execute(input);
            Assert.AreEqual("1 2 N", result.ReturnLocation());

            input = "1 2 w";
            result = InputToRobot.Execute(input);
            Assert.AreEqual("1 2 W", result.ReturnLocation());

            input = "5 6 s";
            result = InputToRobot.Execute(input);
            Assert.AreEqual("5 6 S", result.ReturnLocation());
        }
   
    }
}
