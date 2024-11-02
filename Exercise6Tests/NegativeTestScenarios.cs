using System.Transactions;
using Calculators;
using NUnit.Framework;

namespace Exercise6Tests
{
    /// <summary>
    /// Provides test scenarios for handling exceptions and edge cases in SimpleCalculator operations.
    /// </summary>
    public class NegativeTestScenarios
    {
        private readonly SimpleCalculator _calculator = new();

        /// <summary>
        /// Tests that adding a very large number to the maximum decimal value causes an OverflowException.
        /// </summary>
        [Test]
        public void It_ThrowsOverflowException_WhenAddingMaxDecimalValue()
        {
            // Arrange
            decimal maxDecimalValue = decimal.MaxValue;
            decimal anotherLargeNumber = 1;

            // Act and Assert
            Assert.That(() => _calculator.Enter(maxDecimalValue).Plus(anotherLargeNumber), Throws.Exception.TypeOf<OverflowException>());
        }

        /// <summary>
        /// Tests that dividing by zero throws a DivideByZeroException.
        /// </summary>
        [Test]
        public void It_ThrowsDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            decimal dividend = 10;
            decimal divisor = 0;

            // Act and Assert
            Assert.That(() => _calculator.Enter(dividend).DivideBy(divisor), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        /// <summary>
        /// Tests that adding a very large number that exceeds the maximum decimal value causes an OverflowException.
        /// </summary>
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
