using System.ComponentModel;
using Calculators;

namespace Exercise4Tests
{
    /// <summary>
    /// A factory class for creating instances of SimpleCalculator with a specified initial state.
    /// </summary>
    public class CalculatorFactory
    {
        /// <summary>
        /// Creates an instance of SimpleCalculator and sets an initial state.
        /// </summary>
        /// <param name="initialState">The initial state (value) to set in the calculator.</param>
        /// <returns>A SimpleCalculator instance with the specified initial state.</returns>
        public SimpleCalculator CreateWithInitialStateOf(decimal initialState)
        {
            var calculator = new SimpleCalculator();
            calculator.Enter(initialState);

            return calculator;
        }
    }
}
