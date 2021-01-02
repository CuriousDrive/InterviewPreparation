using NUnit.Framework;
using UnitTestingFizzBuzz;

namespace NUnitTestProjectFizzBuzz
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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

        [Test]
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