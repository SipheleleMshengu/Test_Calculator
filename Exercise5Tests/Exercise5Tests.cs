﻿using System.Collections;
using Calculators;

namespace Exercise5Tests;

[TestFixture]
public class Exercise5Tests
{
    private SimpleCalculator Calculator { get; } = new();

    [QaVerification.Grading]
    // use the [TestCase] annotation here
    [TestCase(5.0, 7.0, 12.0)]
    [TestCase(2.0,-3.0,-1)]
    public void ValuesBasedDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        // complete this method

        // Act
    
        var result = Calculator.Enter(value1).Plus(value2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(expected)); 


    }
    
    private static IEnumerable AdditionTestData()
    {
        yield return new TestCaseData(1m, 1m, 2m);
        yield return new TestCaseData(1m, 2m, 3m);
        yield return new TestCaseData(-1m, -1m, -2m);
    }

    [QaVerification.Grading]
    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        // Act
        decimal result = Calculator.Reset().Enter(value1).Plus(value2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}