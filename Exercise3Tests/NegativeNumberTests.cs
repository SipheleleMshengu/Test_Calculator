/// <summary>
/// Provides unit tests for operations involving negative numbers in the SimpleCalculator.
/// </summary>
public class NegativeNumbersTests : BaseTest
{
    /// <summary>
    /// Tests the addition of a negative number to ensure the calculator handles it correctly.
    /// </summary>
    [Test]
    public void AdditionTest()
    {
        // Act
        var result = calculator.Plus(-2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    /// <summary>
    /// Tests the subtraction of a negative number to confirm the expected result.
    /// </summary>
    [Test]
    public void SubtractionTest()
    {
        // Act
        var result = calculator.Minus(-2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    /// <summary>
    /// Tests the multiplication of a negative number to verify correct calculation of a negative product.
    /// </summary>
    [Test]
    public void MultiplicationTest()
    {
        // Act
        var result = calculator.MultiplyBy(-2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(-8));
    }

    /// <summary>
    /// Tests the division by a negative number to ensure it yields a correct negative quotient.
    /// </summary>
    [Test]
    public void DivisionTest()
    {
        // Act
        var result = calculator.DivideBy(-2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(-2));
    } 
}
