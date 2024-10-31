using Calculators;
using NUnit.Framework;

namespace Exercise2Tests;

[QaVerification.Grading]
[TestFixture]
public class Exercise1Tests
{

    private SimpleCalculator calculator;

    [SetUp]
    public void Setup()
    {
        // Arrange 
        calculator = new SimpleCalculator();
        calculator.Enter(4);
    }
    [TearDown]
    public void Teardown()
    {
        calculator.Reset();
    }

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