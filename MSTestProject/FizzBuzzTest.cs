using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingFizzBuzz;

namespace MSTestProject
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void IsNumberDivisibleBy3()
        {
            //Green
            //Arrange
            int number = 33;
            //Act
            bool actual = Program.IsDivisibleBy3(number);
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, actual);

            //Red
            //Arrange
            number = 35;
            //Act
            actual = Program.IsDivisibleBy3(number);
            expected = false;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNumberDivisibleBy5()
        {
            //Green
            //Arrange
            int number = 10;
            //Act
            bool actual = Program.IsDivisibleBy5(number);
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, actual);

            //Red
            //Arrange
            number = 77;
            //Act
            actual = Program.IsDivisibleBy5(number);
            expected = false;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
