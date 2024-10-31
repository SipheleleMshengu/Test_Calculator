using System.ComponentModel;
using Calculators;

namespace Exercise4Tests;

public class CalculatorFactory
{
    
    public SimpleCalculator CreateWithInitialStateOf(decimal initialState){
        var calculator = new SimpleCalculator ();
        calculator.Enter( initialState);

        return calculator ; 
    }
}