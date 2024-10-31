using System.Xml.Serialization;
using Calculators;

namespace Exercise4Tests;

[QaVerification.Grading]
[TestFixture]
public class Exercise4Tests
{
    private CalculatorFactory calculator_Factory; 

    [SetUp]
    public void Setup(){
        // Arrange
            calculator_Factory = new CalculatorFactory();
    }

    [Test]
    public void AdditionTest()
    {
        // Act
        var result = calculator_Factory.CreateWithInitialStateOf(100).Plus(20).Equals();
        // AAssert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void SubtractionTest()
    {
        // Act
        var result = calculator_Factory.CreateWithInitialStateOf(10).Minus(5).Equals();
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void MultiplicationTest()
    {
        // Act 
        var result = calculator_Factory.CreateWithInitialStateOf(25).MultiplyBy(4).Equals();
        // Assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void DivisionTest()
    {
        // Act
        var result = calculator_Factory.CreateWithInitialStateOf(33).DivideBy(11).Equals();
        // Assert
        Assert.That(result,  Is.EqualTo(3));


    }
}