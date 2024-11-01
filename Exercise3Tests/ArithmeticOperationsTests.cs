using Calculators;

namespace Exercise3Tests;

[QaVerification.Grading]
[TestFixture]

/// <summary>
/// Contains unit tests for various arithmetic operations in the SimpleCalculator class.
/// Inherits from BaseTest to utilize common setup and teardown functionality.
/// </summary>
public class ArithmeticOperationsTests : BaseTest
{
    [Test]
    public void AdditionTest()
    {
        // Act
        var result = calculator.Plus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void SubtractionTest()
    {
        // Act
        var result = calculator.Minus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void MultiplicationTest()
    {
        // Act
        var result = calculator.MultiplyBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void DivisionTest()
    {
        // Act
        var result = calculator.DivideBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
