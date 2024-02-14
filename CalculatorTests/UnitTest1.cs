using CalculatorLibrary;

namespace CalculatorTests;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()

    {
       CalculatorSevice calculator = new CalculatorSevice();
       decimal result = calculator.Add(1, 2);
         Assert.Equal(3, result); 
    }
    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }
    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Multiply(2, 3);
        Assert.Equal(6, result);
    }
    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ShouldThrowExceptionWhenDivisorIsZero()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
    }

    [Fact]
    public void Modulo_ShouldReturnCorrectRemainder()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Modulo(10, 3);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Modulo_ShouldThrowExceptionWhenDivisorIsZero()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        Assert.Throws<ArgumentException>(() => calculator.Modulo(10, 0));
    }

}