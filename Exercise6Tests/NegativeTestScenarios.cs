﻿using System.Transactions;
using Calculators;
using NUnit.Framework;

namespace Exercise6Tests
{
    public class NegativeTestScenarios
    {
        private readonly SimpleCalculator _calculator = new();

        [Test]
        public void It_ThrowsOverflowException_WhenAddingMaxDecimalValue()
        {
            // Arrange0
            decimal maxDecimalValue = decimal.MaxValue;
            decimal anotherLargeNumber = 1;

            // Act and Assert
            Assert.That(() => _calculator.Enter(maxDecimalValue).Plus(anotherLargeNumber), Throws.Exception.TypeOf<OverflowException>());
        }

        [Test]
        public void It_ThrowsDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            decimal dividend = 10;
            decimal divisor = 0;

            // Act and Assert
            Assert.That(() => _calculator.Enter(dividend).DivideBy(divisor), Throws.Exception.TypeOf<DivideByZeroException>());
        }
        

        [Test]
        public void It_ThrowsOverflowException_WhenAddingVeryLargeNumber()
        {
            // Arrange
            decimal veryLargeNumber = decimal.MaxValue;
            decimal anotherLargeNumber = 1;

            // Act and Assert
            Assert.That(() => _calculator.Enter(veryLargeNumber).Plus(anotherLargeNumber), Throws.Exception.TypeOf<OverflowException>());
        }
    }
}