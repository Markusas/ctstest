using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopCalculator.Tests
{
    [TestClass]
    public class ArithmeticsTests
    {
        [TestMethod]
        public void TwoPlusTwoIsFour()
        {
            //Arrange
            double num1 = 2;
            double num2 = 2;
            string action = "+";
            double expectedResult = 4;
            Arithmetics arithmetic = new Arithmetics();
            //Act
            double actualResult = arithmetic.Calculate(num1, num2, action);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FiveDividedByZeroThrowsException()
        {
            //Arrange
            double num1 = 5;
            double num2 = 0;
            string action = "/";
            Arithmetics arithmetic = new Arithmetics();
            bool isDivisionByZeroExceptionThrown = false;
            //Act
            try
            {
                double actualResult = arithmetic.Calculate(num1, num2, action);
            }
            catch (DivideByZeroException ex)
            {
                isDivisionByZeroExceptionThrown = true;
            }
            //Assert
            Assert.IsTrue(isDivisionByZeroExceptionThrown);
        }

        [TestMethod]
        public void NonExistingActionThrowsException()
        {
            //Arrange
            double num1 = 5;
            double num2 = 2;
            string action = "not found";
            Arithmetics arithmetic = new Arithmetics();
            bool isDivisionByZeroExceptionThrown = false;
            //Act
            try
            {
                double actualResult = arithmetic.Calculate(num1, num2, action);
            }
            catch (Exception ex)
            {
                isDivisionByZeroExceptionThrown = true;
            }
            //Assert
            Assert.IsTrue(isDivisionByZeroExceptionThrown);
        }
    }
}
