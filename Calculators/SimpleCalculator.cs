using QaVerification;

namespace Calculators;

/// <summary>
/// Represents a simple calculator capable of performing basic arithmetic operations
/// such as addition, subtraction, multiplication, and division.
/// </summary>
[Grading]
public class SimpleCalculator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SimpleCalculator"/> class
    /// and resets the calculator's last result to zero.
    /// </summary>
    public SimpleCalculator()
    {
        Reset();
    }

    /// <summary>
    /// Gets or sets the last computed result of the calculator.
    /// </summary>
    private decimal LastResult { get; set; }

    /// <summary>
    /// Resets the calculator's result to zero.
    /// </summary>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator Reset()
    {
        LastResult = 0.0M;
        return this;
    }

    /// <summary>
    /// Sets the calculator's current value to the specified number.
    /// </summary>
    /// <param name="number">The number to enter into the calculator.</param>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator Enter(decimal number)
    {
        LastResult = number;
        return this;
    }

    /// <summary>
    /// Adds the specified number to the current value.
    /// </summary>
    /// <param name="number">The number to add.</param>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator Plus(decimal number)
    {
        LastResult += number;
        return this;
    }

    /// <summary>
    /// Subtracts the specified number from the current value.
    /// </summary>
    /// <param name="number">The number to subtract.</param>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator Minus(decimal number)
    {
        LastResult -= number;
        return this;
    }

    /// <summary>
    /// Multiplies the current value by the specified number.
    /// </summary>
    /// <param name="number">The number to multiply by.</param>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator MultiplyBy(decimal number)
    {
        LastResult *= number;
        return this;
    }

    /// <summary>
    /// Divides the current value by the specified number.
    /// </summary>
    /// <param name="number">The number to divide by.</param>
    /// <returns>The current <see cref="SimpleCalculator"/> instance.</returns>
    public SimpleCalculator DivideBy(decimal number)
    {
        LastResult /= number;
        return this;
    }

    /// <summary>
    /// Returns the current computed result.
    /// </summary>
    /// <returns>The result of the last calculation as a decimal.</returns>
    public decimal Equals()
    {
        return LastResult;
    }
}
