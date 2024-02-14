namespace CalculatorLibrary;

public class CalculatorSevice
{
    public decimal Add(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    public decimal Subtract(decimal num1, decimal num2)
    {
        return num1 - num2;
    }

    public decimal Multiply(decimal num1, decimal num2)
    {
        return num1 * num2;
    }

    public decimal Divide(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot divide by zero.");
        }
        return num1 / num2;
    }

    public decimal Modulo(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot calculate modulo with zero divisor.");
        }
        return num1 % num2;
    }
}

