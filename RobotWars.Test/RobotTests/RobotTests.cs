using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RobotWars.ConsoleApp.Data;
using RobotWars.ConsoleApp.Logic;


namespace RobotWars.Test.RobotTests
{
    [TestFixture]
    public class RobotTests
    {

        IArena _arena;

        [SetUp]
        public void SetupTheArenaAndRobots()
        {
            _arena = new Arena(8, 6);

            var robot1 = new Robot("Peter");
            robot1.locX = 2;
            robot1.locY = 3;
            robot1.facing = "W";

            var robot2 = new Robot("John");

            robot2.locX = 4;
            robot2.locY = 5;
            robot2.facing = "W";

            _arena.Add(robot1);
            _arena.Add(robot2);
        }
        
        [Test]
        public void ReturnArenaSizeTest()
        {
            Assert.AreEqual("8 6", _arena.ReturnArenaSize());
        }

     
        [Test]
        public void ReturnRobotCoordinates()
        {
            Assert.AreEqual("2 3 W", _arena.ReturnRobotByName("Peter").ReturnLocation());
        }

        [Test]
        public void TurnRobotLeftTest()
        {
            IRobotMove turnLeft = new RobotTurnLeft();
            
            _arena.ReturnRobotByName("John").Move(turnLeft);
            Assert.AreEqual("S", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnLeft);
            Assert.AreEqual("E", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnLeft);
            Assert.AreEqual("N", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnLeft);
            Assert.AreEqual("W", _arena.ReturnRobotByName("John").facing);
        }

        [Test]
        public void TurnRobotRightTest()
        {
            IRobotMove turnRight = new RobotTurnRight();
            
            _arena.ReturnRobotByName("John").Move(turnRight);
            Assert.AreEqual("N", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnRight);
            Assert.AreEqual("E", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnRight);
            Assert.AreEqual("S", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnRight);
            Assert.AreEqual("W", _arena.ReturnRobotByName("John").facing);

            _arena.ReturnRobotByName("John").Move(turnRight);
            Assert.AreEqual("N", _arena.ReturnRobotByName("John").facing);
        }

        [Test]
        public void MoveRobotByOne()
        {
            IRobotMove moveByOne = new RobotMoveByOne();
            IRobotMove turnRight = new RobotTurnRight();
            IRobotMove turnLeft = new RobotTurnLeft();

            _arena.ReturnRobotByName("Peter").Move(moveByOne);
            Assert.AreEqual("1 3 W", _arena.ReturnRobotByName("Peter").ReturnLocation());

            _arena.ReturnRobotByName("Peter").Move(turnRight);
            _arena.ReturnRobotByName("Peter").Move(moveByOne);
            Assert.AreEqual("1 4 N", _arena.ReturnRobotByName("Peter").ReturnLocation());

            _arena.ReturnRobotByName("Peter").Move(turnRight);
            _arena.ReturnRobotByName("Peter").Move(moveByOne);
            Assert.AreEqual("2 4 E", _arena.ReturnRobotByName("Peter").ReturnLocation());

            _arena.ReturnRobotByName("Peter").Move(turnLeft);
            _arena.ReturnRobotByName("Peter").Move(moveByOne);
            Assert.AreEqual("2 5 N", _arena.ReturnRobotByName("Peter").ReturnLocation());
        }

        
    }
}
