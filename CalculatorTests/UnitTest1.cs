using CalculatorLibrary;

namespace CalculatorTests;

public class UnitTest1
{
    [Fact]
    public void AddTest3()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void AddTest21()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Add(1, 20);
        Assert.Equal(21, result);
    }
    [Fact]
    public void AddTest23()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Add(3, 20);
        Assert.Equal(23, result);
    }
    [Fact]
    public void AddTest4()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Add(2, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void AddTest5()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Add(3, 2);
        Assert.Equal(5, result);
    }
    [Fact]
    public void Subtract1()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Subtract2()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(5, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Subtract3()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(10, 3);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract4()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(4, 3);
        Assert.Equal(1, result);
    }
    [Fact]
    public void Subtract5()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Subtract(20, 10);
        Assert.Equal(10, result);
    }
    [Fact]
    public void Multiply1()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Multiply(2, 3);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply2()
    {
        CalculatorSevice calculator = new();
        decimal result = calculator.Multiply(6, 3);
        Assert.Equal(18, result);
    }

    [Fact]
    public void Multiply3()
    {
        CalculatorSevice calculator = new();
        decimal result = calculator.Multiply(4, 3);
        Assert.Equal(12, result);
    }
    [Fact]
    public void Multiply4()
    {
        CalculatorSevice calculator = new();
        decimal result = calculator.Multiply(2, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Multiply5()
    {
        CalculatorSevice calculator = new();
        decimal result = calculator.Multiply(1, 3);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Divide1()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide2()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Divide(4, 2);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide3()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Divide(6, 2);
        Assert.Equal(3, result);
    }
    [Fact]
    public void Divide4()
    {
        CalculatorSevice calculator = new CalculatorSevice();
        decimal result = calculator.Divide(8, 4);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Divide5()
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