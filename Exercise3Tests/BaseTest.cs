using Calculators;
using NUnit.Framework;

/// <summary>
/// BaseTest class for setting up and tearing down common 
/// resources needed for SimpleCalculator tests.
/// </summary>
public class BaseTest 
{
    /// <summary>
    /// A protected instance of SimpleCalculator to be used by derived test classes.
    /// </summary>
    protected SimpleCalculator calculator { get; set; }

    /// <summary>
    /// SetUp method initializes the SimpleCalculator instance
    /// and performs initial configuration before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        // Arrange
        calculator = new SimpleCalculator();
        calculator.Enter(4);
        TestContext.Progress.WriteLine("BaseTest Setup Method Invoked!");
    }

    /// <summary>
    /// TearDown method resets the SimpleCalculator instance 
    /// after each test to ensure a clean state for the next test.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
        calculator.Reset();
        TestContext.Progress.WriteLine("BaseTest Teardown Method Invoked!");
    }
}
