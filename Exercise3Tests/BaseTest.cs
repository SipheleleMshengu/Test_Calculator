using Calculators;
using NUnit.Framework;

public class BaseTest {

    protected SimpleCalculator calculator { get; set;}

    [SetUp]
    public void Setup()
    {
        //Arrange
        calculator = new SimpleCalculator();
        calculator.Enter(4);
        TestContext.Progress.WriteLine(" BaseTest Setup Method Invoked ! ");
    }

    [TearDown]

    public void Teardown()
    {
        calculator.Reset();
        TestContext.Progress.WriteLine(" BaseTest Teardown Method Invoked ! ");

    }





}