using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RobotWars.ConsoleApp.Validation;

namespace RobotWars.Test.RobotTests
{
    [TestFixture]
    public class InputValidationTests
    {

        [Test]
        public void IsStringArgumentNullOrEmptyTest()
        {
          
            string input = "5 5";
            bool result;
            
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(true, result);

            input = "1 l";
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(false, result);

            input = "1 5 6";
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(false, result);

            input = "1";
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(false, result);

            input = " ";
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(false, result);

            input = "";
            result = ValidationService.IsArenaDimensionValid(false, input);
            Assert.AreEqual(false, result);
        }
        
        [Test]
        public void IsArenaDimensionValidTest()
        {
            string input = "5 5";
            bool result;
            
            result = ValidationService.IsArenaDimensionValid(true, input);
            Assert.AreEqual(true, result);

            input = "5 5f";
            result = ValidationService.IsArenaDimensionValid(true, input);
            Assert.AreEqual(false, result);

            input = "df";
            result = ValidationService.IsArenaDimensionValid(true, input);
            Assert.AreEqual(false, result);

            input = "5 5 5";
            result = ValidationService.IsArenaDimensionValid(true, input);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsInputValidLocationTest()
        {
            
            string input = "1 2 N";
            bool result;

            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(true, result);

            input = "1 1";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "1 w w";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "w w w";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "1 1 1";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "1 1 w 1";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "1 1 w w";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(false, result);

            input = "25 31 s";
            result = ValidationService.IsInputValidLocation(input);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsInputValidMoveInstructionTest()
        {

            string input = "LMLMLMLMM";
            bool result;

            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(true, result);

            input = "LMLMLML1MM";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(false, result);

            input = "";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(false, result);

            input = " ";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(false, result);

            input = "L";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(true, result);

            input = "R";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(true, result);

            input = "M";
            result = ValidationService.IsInputValidMoveInstruction(input);
            Assert.AreEqual(true, result);
        }
      
    }
}
