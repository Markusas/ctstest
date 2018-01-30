﻿using System;
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
            int num1 = 2;
            int num2 = 2;
            string action = "+";
            int expectedResult = 4;
            Arithmetics arithmetic = new Arithmetics();
            //Act
            int actualResult = arithmetic.Calculate(num1, num2, action);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FiveDividedByZeroThrowsException()
        {
            //Arrange
            int num1 = 5;
            int num2 = 0;
            string action = "/";
            Arithmetics arithmetic = new Arithmetics();
            bool isDivisionByZeroExceptionThrown = false;
            //Act
            try
            {
                int actualResult = arithmetic.Calculate(num1, num2, action);
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
            int num1 = 5;
            int num2 = 2;
            string action = "not found";
            Arithmetics arithmetic = new Arithmetics();
            bool isExceptionThrown = false;
            //Act
            try
            {
                int actualResult = arithmetic.Calculate(num1, num2, action);
            }
            catch (Exception ex)
            {
                isExceptionThrown = true;
            }
            //Assert
            Assert.IsTrue(isDivisionByZeroExceptionThrown);
        }
    }
}
